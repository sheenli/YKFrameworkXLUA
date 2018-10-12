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
    public class ResMgrWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ResMgr);
			Utils.BeginObjectRegister(type, L, translator, 0, 18, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Awake", _m_Awake);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAsset", _m_GetAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetABRefCount", _m_GetABRefCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetAsync", _m_GetAssetAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAsset", _m_LoadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetAsync", _m_LoadAssetAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PrLoadAudioClip", _m_PrLoadAudioClip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAll", _m_LoadAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadGroup", _m_LoadGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogAll", _m_LogAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushRes", _m_PushRes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnLoadAsset", _m_UnLoadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnLoadAll", _m_UnLoadAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GC", _m_GC);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryAddFairyGuiRes", _m_TryAddFairyGuiRes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryUnLoadFariryGUIRes", _m_TryUnLoadFariryGUIRes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindAssetPath", _m_FindAssetPath);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Intstance", _g_get_Intstance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					ResMgr __cl_gen_ret = new ResMgr();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ResMgr constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Awake(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Awake(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Object __cl_gen_ret = __cl_gen_to_be_invoked.GetAsset( assetName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetABRefCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string abName = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetABRefCount( abName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.Object> callBack = translator.GetDelegate<System.Action<UnityEngine.Object>>(L, 3);
                    
                    __cl_gen_to_be_invoked.GetAssetAsync( assetName, callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.Object>>(L, 3)) 
                {
                    string assteName = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.Object> callBaclk = translator.GetDelegate<System.Action<UnityEngine.Object>>(L, 3);
                    
                    __cl_gen_to_be_invoked.LoadAsset( assteName, callBaclk );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string assteName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.LoadAsset( assteName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<System.Action<UnityEngine.Object>>(L, 4)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    System.Action<UnityEngine.Object> callBaclk = translator.GetDelegate<System.Action<UnityEngine.Object>>(L, 4);
                    
                    __cl_gen_to_be_invoked.LoadAsset( assetName, type, callBaclk );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                    __cl_gen_to_be_invoked.LoadAsset( assetName, type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ResMgr.LoadAsset!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AssetBundle ab = (UnityEngine.AssetBundle)translator.GetObject(L, 2, typeof(UnityEngine.AssetBundle));
                    string assteName = LuaAPI.lua_tostring(L, 3);
                    System.Type type = (System.Type)translator.GetObject(L, 4, typeof(System.Type));
                    System.Action<UnityEngine.Object> callBack = translator.GetDelegate<System.Action<UnityEngine.Object>>(L, 5);
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked.LoadAssetAsync( ab, assteName, type, callBack );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PrLoadAudioClip(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AudioClip audioClip = (UnityEngine.AudioClip)translator.GetObject(L, 2, typeof(UnityEngine.AudioClip));
                    System.Action callBack = translator.GetDelegate<System.Action>(L, 3);
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked.PrLoadAudioClip( audioClip, callBack );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAll(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)) 
                {
                    string abName = LuaAPI.lua_tostring(L, 2);
                    System.Action callBack = translator.GetDelegate<System.Action>(L, 3);
                    
                    __cl_gen_to_be_invoked.LoadAll( abName, callBack );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string abName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.LoadAll( abName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ResMgr.LoadAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string groupName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.LoadGroup( groupName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<ResGroupCfg>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    ResGroupCfg groupData = (ResGroupCfg)translator.GetObject(L, 2, typeof(ResGroupCfg));
                    string groupName = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.LoadGroup( groupData, groupName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ResMgr.LoadGroup!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogAll(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.LogAll(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushRes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.PushRes(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnLoadAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    bool immediate = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.UnLoadAsset( assetName, immediate );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.UnLoadAsset( assetName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ResMgr.UnLoadAsset!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnLoadAll(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool forced = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.UnLoadAll( forced );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.UnLoadAll(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ResMgr.UnLoadAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GC(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked.GC(  );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryAddFairyGuiRes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.TryAddFairyGuiRes(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryUnLoadFariryGUIRes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    bool all = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.TryUnLoadFariryGUIRes( assetName, all );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.TryUnLoadFariryGUIRes( assetName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.TryUnLoadFariryGUIRes(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ResMgr.TryUnLoadFariryGUIRes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Init(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindAssetPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResMgr __cl_gen_to_be_invoked = (ResMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.FindAssetPath( assetName );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Intstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ResMgr.Intstance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
