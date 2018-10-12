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
    public class TaskBaseWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(TaskBase);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 8, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Stop", _m_Stop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddTask", _m_AddTask);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnExecute", _m_OnExecute);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsValid", _g_get_IsValid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentTaskName", _g_get_currentTaskName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "progress", _g_get_progress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allStaskCount", _g_get_allStaskCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFinished", _g_get_isFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "taskItemFinished", _g_get_taskItemFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mFinished", _g_get_mFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mFailure", _g_get_mFailure);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentTaskName", _s_set_currentTaskName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "progress", _s_set_progress);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allStaskCount", _s_set_allStaskCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isFinished", _s_set_isFinished);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "taskItemFinished", _s_set_taskItemFinished);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mFinished", _s_set_mFinished);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mFailure", _s_set_mFailure);
            
			
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
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2) && translator.Assignable<System.Action>(L, 3) && translator.Assignable<System.Action<string, string>>(L, 4))
				{
					bool failureStop = LuaAPI.lua_toboolean(L, 2);
					System.Action finished = translator.GetDelegate<System.Action>(L, 3);
					System.Action<string, string> failure = translator.GetDelegate<System.Action<string, string>>(L, 4);
					
					TaskBase __cl_gen_ret = new TaskBase(failureStop, finished, failure);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to TaskBase constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Stop(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Stop(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddTask(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ITask task = (ITask)translator.GetObject(L, 2, typeof(ITask));
                    
                    __cl_gen_to_be_invoked.AddTask( task );
                    
                    
                    
                    return 0;
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
            
            
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnExecute(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsValid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.IsValid);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentTaskName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.currentTaskName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_progress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.progress);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allStaskCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.allStaskCount);
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
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_taskItemFinished(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.taskItemFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mFinished(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mFailure(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mFailure);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentTaskName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.currentTaskName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_progress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.progress = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allStaskCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.allStaskCount = LuaAPI.xlua_tointeger(L, 2);
            
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
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isFinished = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_taskItemFinished(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.taskItemFinished = translator.GetDelegate<System.Action<ITask>>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mFinished(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mFinished = translator.GetDelegate<System.Action>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mFailure(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                TaskBase __cl_gen_to_be_invoked = (TaskBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mFailure = translator.GetDelegate<System.Action<string, string>>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
