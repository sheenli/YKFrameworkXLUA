#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class TweenUtilsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(TweenUtils);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SetDelay", _m_SetDelay_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetLoops", _m_SetLoops_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetTarget", _m_SetTarget_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "TweenUtils does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDelay_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    DG.Tweening.Tweener tweener = (DG.Tweening.Tweener)translator.GetObject(L, 1, typeof(DG.Tweening.Tweener));
                    float delay = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    TweenUtils.SetDelay( tweener, delay );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLoops_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<DG.Tweening.Tweener>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    DG.Tweening.Tweener tweener = (DG.Tweening.Tweener)translator.GetObject(L, 1, typeof(DG.Tweening.Tweener));
                    int loops = LuaAPI.xlua_tointeger(L, 2);
                    
                    TweenUtils.SetLoops( tweener, loops );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<DG.Tweening.Tweener>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    DG.Tweening.Tweener tweener = (DG.Tweening.Tweener)translator.GetObject(L, 1, typeof(DG.Tweening.Tweener));
                    int loops = LuaAPI.xlua_tointeger(L, 2);
                    bool yoyo = LuaAPI.lua_toboolean(L, 3);
                    
                    TweenUtils.SetLoops( tweener, loops, yoyo );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to TweenUtils.SetLoops!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTarget_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    DG.Tweening.Tweener tweener = (DG.Tweening.Tweener)translator.GetObject(L, 1, typeof(DG.Tweening.Tweener));
                    object target = translator.GetObject(L, 2, typeof(object));
                    
                    TweenUtils.SetTarget( tweener, target );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
