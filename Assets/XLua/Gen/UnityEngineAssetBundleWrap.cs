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
    public class UnityEngineAssetBundleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.AssetBundle);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Contains", _m_Contains);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAsset", _m_LoadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetAsync", _m_LoadAssetAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetWithSubAssets", _m_LoadAssetWithSubAssets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetWithSubAssetsAsync", _m_LoadAssetWithSubAssetsAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAllAssets", _m_LoadAllAssets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAllAssetsAsync", _m_LoadAllAssetsAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Unload", _m_Unload);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllAssetNames", _m_GetAllAssetNames);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllScenePaths", _m_GetAllScenePaths);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainAsset", _g_get_mainAsset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isStreamedSceneAssetBundle", _g_get_isStreamedSceneAssetBundle);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadFromFileAsync", _m_LoadFromFileAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadFromFile", _m_LoadFromFile_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadFromMemoryAsync", _m_LoadFromMemoryAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadFromMemory", _m_LoadFromMemory_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.AssetBundle __cl_gen_ret = new UnityEngine.AssetBundle();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromFileAsync_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string path = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.AssetBundleCreateRequest __cl_gen_ret = UnityEngine.AssetBundle.LoadFromFileAsync( path );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string path = LuaAPI.lua_tostring(L, 1);
                    uint crc = LuaAPI.xlua_touint(L, 2);
                    
                        UnityEngine.AssetBundleCreateRequest __cl_gen_ret = UnityEngine.AssetBundle.LoadFromFileAsync( path, crc );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isuint64(L, 3))) 
                {
                    string path = LuaAPI.lua_tostring(L, 1);
                    uint crc = LuaAPI.xlua_touint(L, 2);
                    ulong offset = LuaAPI.lua_touint64(L, 3);
                    
                        UnityEngine.AssetBundleCreateRequest __cl_gen_ret = UnityEngine.AssetBundle.LoadFromFileAsync( path, crc, offset );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle.LoadFromFileAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromFile_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string path = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.AssetBundle __cl_gen_ret = UnityEngine.AssetBundle.LoadFromFile( path );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string path = LuaAPI.lua_tostring(L, 1);
                    uint crc = LuaAPI.xlua_touint(L, 2);
                    
                        UnityEngine.AssetBundle __cl_gen_ret = UnityEngine.AssetBundle.LoadFromFile( path, crc );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isuint64(L, 3))) 
                {
                    string path = LuaAPI.lua_tostring(L, 1);
                    uint crc = LuaAPI.xlua_touint(L, 2);
                    ulong offset = LuaAPI.lua_touint64(L, 3);
                    
                        UnityEngine.AssetBundle __cl_gen_ret = UnityEngine.AssetBundle.LoadFromFile( path, crc, offset );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle.LoadFromFile!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromMemoryAsync_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] binary = LuaAPI.lua_tobytes(L, 1);
                    
                        UnityEngine.AssetBundleCreateRequest __cl_gen_ret = UnityEngine.AssetBundle.LoadFromMemoryAsync( binary );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] binary = LuaAPI.lua_tobytes(L, 1);
                    uint crc = LuaAPI.xlua_touint(L, 2);
                    
                        UnityEngine.AssetBundleCreateRequest __cl_gen_ret = UnityEngine.AssetBundle.LoadFromMemoryAsync( binary, crc );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle.LoadFromMemoryAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromMemory_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] binary = LuaAPI.lua_tobytes(L, 1);
                    
                        UnityEngine.AssetBundle __cl_gen_ret = UnityEngine.AssetBundle.LoadFromMemory( binary );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] binary = LuaAPI.lua_tobytes(L, 1);
                    uint crc = LuaAPI.xlua_touint(L, 2);
                    
                        UnityEngine.AssetBundle __cl_gen_ret = UnityEngine.AssetBundle.LoadFromMemory( binary, crc );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle.LoadFromMemory!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Contains(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Contains( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
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
            
            
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Object __cl_gen_ret = __cl_gen_to_be_invoked.LoadAsset( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        UnityEngine.Object __cl_gen_ret = __cl_gen_to_be_invoked.LoadAsset( name, type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle.LoadAsset!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.AssetBundleRequest __cl_gen_ret = __cl_gen_to_be_invoked.LoadAssetAsync( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        UnityEngine.AssetBundleRequest __cl_gen_ret = __cl_gen_to_be_invoked.LoadAssetAsync( name, type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle.LoadAssetAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetWithSubAssets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Object[] __cl_gen_ret = __cl_gen_to_be_invoked.LoadAssetWithSubAssets( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        UnityEngine.Object[] __cl_gen_ret = __cl_gen_to_be_invoked.LoadAssetWithSubAssets( name, type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle.LoadAssetWithSubAssets!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetWithSubAssetsAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.AssetBundleRequest __cl_gen_ret = __cl_gen_to_be_invoked.LoadAssetWithSubAssetsAsync( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        UnityEngine.AssetBundleRequest __cl_gen_ret = __cl_gen_to_be_invoked.LoadAssetWithSubAssetsAsync( name, type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle.LoadAssetWithSubAssetsAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAllAssets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        UnityEngine.Object[] __cl_gen_ret = __cl_gen_to_be_invoked.LoadAllAssets(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Object[] __cl_gen_ret = __cl_gen_to_be_invoked.LoadAllAssets( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle.LoadAllAssets!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAllAssetsAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        UnityEngine.AssetBundleRequest __cl_gen_ret = __cl_gen_to_be_invoked.LoadAllAssetsAsync(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.AssetBundleRequest __cl_gen_ret = __cl_gen_to_be_invoked.LoadAllAssetsAsync( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundle.LoadAllAssetsAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Unload(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool unloadAllLoadedObjects = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Unload( unloadAllLoadedObjects );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllAssetNames(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllAssetNames(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllScenePaths(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllScenePaths(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mainAsset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mainAsset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isStreamedSceneAssetBundle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AssetBundle __cl_gen_to_be_invoked = (UnityEngine.AssetBundle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isStreamedSceneAssetBundle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
