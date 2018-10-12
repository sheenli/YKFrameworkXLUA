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
    public class SceneBaseWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(SceneBase);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 6, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddTask", _m_AddTask);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddParallelTask", _m_AddParallelTask);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddLoadGrop", _m_AddLoadGrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Loaded", _m_Loaded);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Enter", _m_Enter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFinished", _m_OnFinished);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Leave", _m_Leave);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResStartTask", _m_ResStartTask);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddListener", _m_AddListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDestroy", _m_OnDestroy);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "SceneName", _g_get_SceneName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "GroupName", _g_get_GroupName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventMgr", _g_get_eventMgr);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isLoadingShowWait", _g_get_isLoadingShowWait);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sceneTask", _g_get_sceneTask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parallelTask", _g_get_parallelTask);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "SceneName", _s_set_SceneName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "GroupName", _s_set_GroupName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eventMgr", _s_set_eventMgr);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isLoadingShowWait", _s_set_isLoadingShowWait);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sceneTask", _s_set_sceneTask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "parallelTask", _s_set_parallelTask);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "SceneBase does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddTask(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_AddParallelTask(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ITask task = (ITask)translator.GetObject(L, 2, typeof(ITask));
                    
                    __cl_gen_to_be_invoked.AddParallelTask( task );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddLoadGrop(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string gropName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.AddLoadGrop( gropName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Loaded(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Loaded(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Enter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object param = translator.GetObject(L, 2, typeof(object));
                    
                    __cl_gen_to_be_invoked.Enter( param );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnFinished(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnFinished(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Leave(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Leave(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResStartTask(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.ResStartTask(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddListener(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 5&& translator.Assignable<EventDispatcherNode>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    EventDispatcherNode dis = (EventDispatcherNode)translator.GetObject(L, 2, typeof(EventDispatcherNode));
                    string type = LuaAPI.lua_tostring(L, 3);
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    bool _dispatchOnce = LuaAPI.lua_toboolean(L, 5);
                    
                    __cl_gen_to_be_invoked.AddListener( dis, type, _priority, _dispatchOnce );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<EventDispatcherNode>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    EventDispatcherNode dis = (EventDispatcherNode)translator.GetObject(L, 2, typeof(EventDispatcherNode));
                    string type = LuaAPI.lua_tostring(L, 3);
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.AddListener( dis, type, _priority );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<EventDispatcherNode>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    EventDispatcherNode dis = (EventDispatcherNode)translator.GetObject(L, 2, typeof(EventDispatcherNode));
                    string type = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.AddListener( dis, type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to SceneBase.AddListener!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDestroy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnDestroy(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SceneName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.SceneName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GroupName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.GroupName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventMgr(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.eventMgr);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isLoadingShowWait(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isLoadingShowWait);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sceneTask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sceneTask);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parallelTask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.parallelTask);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SceneName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.SceneName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GroupName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.GroupName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_eventMgr(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.eventMgr = (EventListenerMgr)translator.GetObject(L, 2, typeof(EventListenerMgr));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isLoadingShowWait(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isLoadingShowWait = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sceneTask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sceneTask = (AsynTask)translator.GetObject(L, 2, typeof(AsynTask));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_parallelTask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneBase __cl_gen_to_be_invoked = (SceneBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.parallelTask = (AsynTask)translator.GetObject(L, 2, typeof(AsynTask));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
