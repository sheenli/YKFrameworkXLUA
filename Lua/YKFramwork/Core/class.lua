local _class ={}
function class(super,cstype)
    local cs_func_tbl = {}

    local class_type = {
        super = super,
        cs_func_tbl = cs_func_tbl
    }

    class_type.new = function(...)
        local obj={super = super}

        setmetatable(obj, { __index = function(t, k)
            local ret
            local cur_class = class_type
            repeat
                -- 先找本类 和本类的c#函数缓存
                ret = cur_class[k] or cur_class.cs_func_tbl[k]
                if ret then
                    return ret
                end

                -- 找父类
                if cur_class.super then
                    cur_class = cur_class.super
                else
                    -- 没有父类了，找c#类
                    local csuserdata = rawget(obj,"csuserdata")
                    if csuserdata then
                        local csObj = csuserdata[k]
                        if csObj and type(csObj) == "function" then
                            local f = function(_, ...)
                                return csObj(csuserdata, ...)
                            end
                            cur_class.cs_func_tbl[k] = f
                            return f
                        end
                        return csObj
                    end
                    return
                end
            until false
        end })
        do
            local create
            create = function(c,...)
                if c.super then
                    create(c.super,...)
                end
                if c.ctor then
                    c.ctor(obj,...)
                end
            end

            create(class_type,...)
        end
        if cstype then
            obj.csuserdata = cstype()
        end
        if cstype then
            if obj.csuserdata and obj.csuserdata.SetLuaTalbe then
                obj.csuserdata:SetLuaTalbe(obj)
            end
            return obj.csuserdata
        end

        return obj
    end

    return class_type
end

