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
    public class SceneMgrWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(SceneMgr);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Awake", _m_Awake);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GotoScene", _m_GotoScene);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDestroy", _m_OnDestroy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetScnene", _m_GetScnene);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnHanderEvent", _m_OnHanderEvent);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "OpenLoadUI", _g_get_OpenLoadUI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CloseLoadUI", _g_get_CloseLoadUI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "oldScenes", _g_get_oldScenes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentScene", _g_get_currentScene);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "OpenLoadUI", _s_set_OpenLoadUI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CloseLoadUI", _s_set_CloseLoadUI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "oldScenes", _s_set_oldScenes);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentScene", _s_set_currentScene);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 1, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ChangeSceneFinished", SceneMgr.ChangeSceneFinished);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					SceneMgr __cl_gen_ret = new SceneMgr();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to SceneMgr constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Awake(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Awake(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GotoScene(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<System.Func<SceneBase>>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string scneneType = LuaAPI.lua_tostring(L, 2);
                    System.Type t = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    System.Func<SceneBase> func = translator.GetDelegate<System.Func<SceneBase>>(L, 4);
                    object param = translator.GetObject(L, 5, typeof(object));
                    
                    __cl_gen_to_be_invoked.GotoScene( scneneType, t, func, param );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<System.Func<SceneBase>>(L, 4)) 
                {
                    string scneneType = LuaAPI.lua_tostring(L, 2);
                    System.Type t = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    System.Func<SceneBase> func = translator.GetDelegate<System.Func<SceneBase>>(L, 4);
                    
                    __cl_gen_to_be_invoked.GotoScene( scneneType, t, func );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    string scneneType = LuaAPI.lua_tostring(L, 2);
                    System.Type t = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                    __cl_gen_to_be_invoked.GotoScene( scneneType, t );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string scneneType = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.GotoScene( scneneType );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to SceneMgr.GotoScene!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDestroy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnDestroy(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetScnene(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    
                        SceneBase __cl_gen_ret = __cl_gen_to_be_invoked.GetScnene( sceneName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnHanderEvent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    EventData data = (EventData)translator.GetObject(L, 2, typeof(EventData));
                    
                    __cl_gen_to_be_invoked.OnHanderEvent( data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, SceneMgr.Instance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OpenLoadUI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.OpenLoadUI);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CloseLoadUI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.CloseLoadUI);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_oldScenes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.oldScenes);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentScene(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.currentScene);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OpenLoadUI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.OpenLoadUI = translator.GetDelegate<System.Action<System.Collections.Generic.List<TaskBase>>>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CloseLoadUI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.CloseLoadUI = translator.GetDelegate<System.Action>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_oldScenes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.oldScenes = (System.Collections.Generic.Queue<SceneBase>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Queue<SceneBase>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentScene(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SceneMgr __cl_gen_to_be_invoked = (SceneMgr)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.currentScene = (SceneBase)translator.GetObject(L, 2, typeof(SceneBase));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
