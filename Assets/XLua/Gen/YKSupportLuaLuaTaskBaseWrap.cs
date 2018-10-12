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
    public class YKSupportLuaLuaTaskBaseWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(YKSupportLua.LuaTaskBase);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 6, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLuaTalbe", _m_SetLuaTalbe);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TaskName", _m_TaskName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnExecute", _m_OnExecute);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FailureInfo", _m_FailureInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rest", _m_Rest);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsFailure", _g_get_IsFailure);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsFinished", _g_get_IsFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "failureInfo", _g_get_failureInfo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "taskName", _g_get_taskName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFailure", _g_get_isFailure);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFinished", _g_get_isFinished);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "failureInfo", _s_set_failureInfo);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "taskName", _s_set_taskName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isFailure", _s_set_isFailure);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isFinished", _s_set_isFinished);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					YKSupportLua.LuaTaskBase __cl_gen_ret = new YKSupportLua.LuaTaskBase();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to YKSupportLua.LuaTaskBase constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLuaTalbe(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    XLua.LuaTable peerTable = (XLua.LuaTable)translator.GetObject(L, 2, typeof(XLua.LuaTable));
                    
                    __cl_gen_to_be_invoked.SetLuaTalbe( peerTable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TaskName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.TaskName(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnExecute(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnExecute(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FailureInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.FailureInfo(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Rest(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Rest(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsFailure(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.IsFailure);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsFinished(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.IsFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_failureInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.failureInfo);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_taskName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.taskName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFailure(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isFailure);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFinished(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_failureInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.failureInfo = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_taskName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.taskName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isFailure(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isFailure = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isFinished(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaTaskBase __cl_gen_to_be_invoked = (YKSupportLua.LuaTaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isFinished = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
