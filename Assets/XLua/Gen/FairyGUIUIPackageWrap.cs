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
    public class FairyGUIUIPackageWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.UIPackage);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 4, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixelHitTestData", _m_GetPixelHitTestData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateObject", _m_CreateObject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateObjectAsync", _m_CreateObjectAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItemAsset", _m_GetItemAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItems", _m_GetItems);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItem", _m_GetItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItemByName", _m_GetItemByName);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "id", _g_get_id);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "name", _g_get_name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "assetPath", _g_get_assetPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "customId", _g_get_customId);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "customId", _s_set_customId);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 16, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetById", _m_GetById_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetByName", _m_GetByName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddPackage", _m_AddPackage_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemovePackage", _m_RemovePackage_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveAllPackages", _m_RemoveAllPackages_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPackages", _m_GetPackages_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateObject", _m_CreateObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateObjectFromURL", _m_CreateObjectFromURL_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateObjectAsync", _m_CreateObjectAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetItemAsset", _m_GetItemAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetItemAssetByURL", _m_GetItemAssetByURL_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetItemURL", _m_GetItemURL_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetItemByURL", _m_GetItemByURL_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NormalizeURL", _m_NormalizeURL_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStringsSource", _m_SetStringsSource_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					FairyGUI.UIPackage __cl_gen_ret = new FairyGUI.UIPackage();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.UIPackage constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetById_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string id = LuaAPI.lua_tostring(L, 1);
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.GetById( id );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetByName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.GetByName( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddPackage_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.AssetBundle>(L, 1)) 
                {
                    UnityEngine.AssetBundle bundle = (UnityEngine.AssetBundle)translator.GetObject(L, 1, typeof(UnityEngine.AssetBundle));
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.AddPackage( bundle );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string descFilePath = LuaAPI.lua_tostring(L, 1);
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.AddPackage( descFilePath );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.AssetBundle>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.AssetBundle bundle = (UnityEngine.AssetBundle)translator.GetObject(L, 1, typeof(UnityEngine.AssetBundle));
                    bool unloadBundleAfterLoaded = LuaAPI.lua_toboolean(L, 2);
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.AddPackage( bundle, unloadBundleAfterLoaded );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.AssetBundle>(L, 1)&& translator.Assignable<UnityEngine.AssetBundle>(L, 2)) 
                {
                    UnityEngine.AssetBundle desc = (UnityEngine.AssetBundle)translator.GetObject(L, 1, typeof(UnityEngine.AssetBundle));
                    UnityEngine.AssetBundle res = (UnityEngine.AssetBundle)translator.GetObject(L, 2, typeof(UnityEngine.AssetBundle));
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.AddPackage( desc, res );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<FairyGUI.UIPackage.LoadResource>(L, 2)) 
                {
                    string assetPath = LuaAPI.lua_tostring(L, 1);
                    FairyGUI.UIPackage.LoadResource loadFunc = translator.GetDelegate<FairyGUI.UIPackage.LoadResource>(L, 2);
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.AddPackage( assetPath, loadFunc );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.AssetBundle>(L, 1)&& translator.Assignable<UnityEngine.AssetBundle>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.AssetBundle desc = (UnityEngine.AssetBundle)translator.GetObject(L, 1, typeof(UnityEngine.AssetBundle));
                    UnityEngine.AssetBundle res = (UnityEngine.AssetBundle)translator.GetObject(L, 2, typeof(UnityEngine.AssetBundle));
                    bool unloadBundleAfterLoaded = LuaAPI.lua_toboolean(L, 3);
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.AddPackage( desc, res, unloadBundleAfterLoaded );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.AssetBundle>(L, 1)&& translator.Assignable<UnityEngine.AssetBundle>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.AssetBundle desc = (UnityEngine.AssetBundle)translator.GetObject(L, 1, typeof(UnityEngine.AssetBundle));
                    UnityEngine.AssetBundle res = (UnityEngine.AssetBundle)translator.GetObject(L, 2, typeof(UnityEngine.AssetBundle));
                    string mainAssetName = LuaAPI.lua_tostring(L, 3);
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.AddPackage( desc, res, mainAssetName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<FairyGUI.UIPackage.LoadResource>(L, 3)) 
                {
                    byte[] descData = LuaAPI.lua_tobytes(L, 1);
                    string assetNamePrefix = LuaAPI.lua_tostring(L, 2);
                    FairyGUI.UIPackage.LoadResource loadFunc = translator.GetDelegate<FairyGUI.UIPackage.LoadResource>(L, 3);
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.AddPackage( descData, assetNamePrefix, loadFunc );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.AssetBundle>(L, 1)&& translator.Assignable<UnityEngine.AssetBundle>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.AssetBundle desc = (UnityEngine.AssetBundle)translator.GetObject(L, 1, typeof(UnityEngine.AssetBundle));
                    UnityEngine.AssetBundle res = (UnityEngine.AssetBundle)translator.GetObject(L, 2, typeof(UnityEngine.AssetBundle));
                    string mainAssetName = LuaAPI.lua_tostring(L, 3);
                    bool unloadBundleAfterLoaded = LuaAPI.lua_toboolean(L, 4);
                    
                        FairyGUI.UIPackage __cl_gen_ret = FairyGUI.UIPackage.AddPackage( desc, res, mainAssetName, unloadBundleAfterLoaded );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.UIPackage.AddPackage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemovePackage_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string packageIdOrName = LuaAPI.lua_tostring(L, 1);
                    
                    FairyGUI.UIPackage.RemovePackage( packageIdOrName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    string packageIdOrName = LuaAPI.lua_tostring(L, 1);
                    bool allowDestroyingAssets = LuaAPI.lua_toboolean(L, 2);
                    
                    FairyGUI.UIPackage.RemovePackage( packageIdOrName, allowDestroyingAssets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.UIPackage.RemovePackage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveAllPackages_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 0) 
                {
                    
                    FairyGUI.UIPackage.RemoveAllPackages(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool allowDestroyAssets = LuaAPI.lua_toboolean(L, 1);
                    
                    FairyGUI.UIPackage.RemoveAllPackages( allowDestroyAssets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.UIPackage.RemoveAllPackages!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPackages_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        System.Collections.Generic.List<FairyGUI.UIPackage> __cl_gen_ret = FairyGUI.UIPackage.GetPackages(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string pkgName = LuaAPI.lua_tostring(L, 1);
                    string resName = LuaAPI.lua_tostring(L, 2);
                    
                        FairyGUI.GObject __cl_gen_ret = FairyGUI.UIPackage.CreateObject( pkgName, resName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    string pkgName = LuaAPI.lua_tostring(L, 1);
                    string resName = LuaAPI.lua_tostring(L, 2);
                    System.Type userClass = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        FairyGUI.GObject __cl_gen_ret = FairyGUI.UIPackage.CreateObject( pkgName, resName, userClass );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.UIPackage.CreateObject!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateObjectFromURL_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    
                        FairyGUI.GObject __cl_gen_ret = FairyGUI.UIPackage.CreateObjectFromURL( url );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 2)) 
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    System.Type userClass = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        FairyGUI.GObject __cl_gen_ret = FairyGUI.UIPackage.CreateObjectFromURL( url, userClass );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<FairyGUI.UIPackage.CreateObjectCallback>(L, 2)) 
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    FairyGUI.UIPackage.CreateObjectCallback callback = translator.GetDelegate<FairyGUI.UIPackage.CreateObjectCallback>(L, 2);
                    
                    FairyGUI.UIPackage.CreateObjectFromURL( url, callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.UIPackage.CreateObjectFromURL!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateObjectAsync_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string pkgName = LuaAPI.lua_tostring(L, 1);
                    string resName = LuaAPI.lua_tostring(L, 2);
                    FairyGUI.UIPackage.CreateObjectCallback callback = translator.GetDelegate<FairyGUI.UIPackage.CreateObjectCallback>(L, 3);
                    
                    FairyGUI.UIPackage.CreateObjectAsync( pkgName, resName, callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItemAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string pkgName = LuaAPI.lua_tostring(L, 1);
                    string resName = LuaAPI.lua_tostring(L, 2);
                    
                        object __cl_gen_ret = FairyGUI.UIPackage.GetItemAsset( pkgName, resName );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItemAssetByURL_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    
                        object __cl_gen_ret = FairyGUI.UIPackage.GetItemAssetByURL( url );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItemURL_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string pkgName = LuaAPI.lua_tostring(L, 1);
                    string resName = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = FairyGUI.UIPackage.GetItemURL( pkgName, resName );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItemByURL_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    
                        FairyGUI.PackageItem __cl_gen_ret = FairyGUI.UIPackage.GetItemByURL( url );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NormalizeURL_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = FairyGUI.UIPackage.NormalizeURL( url );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStringsSource_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FairyGUI.Utils.XML source = (FairyGUI.Utils.XML)translator.GetObject(L, 1, typeof(FairyGUI.Utils.XML));
                    
                    FairyGUI.UIPackage.SetStringsSource( source );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixelHitTestData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string itemId = LuaAPI.lua_tostring(L, 2);
                    
                        FairyGUI.PixelHitTestData __cl_gen_ret = __cl_gen_to_be_invoked.GetPixelHitTestData( itemId );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateObject(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string resName = LuaAPI.lua_tostring(L, 2);
                    
                        FairyGUI.GObject __cl_gen_ret = __cl_gen_to_be_invoked.CreateObject( resName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    string resName = LuaAPI.lua_tostring(L, 2);
                    System.Type userClass = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        FairyGUI.GObject __cl_gen_ret = __cl_gen_to_be_invoked.CreateObject( resName, userClass );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.UIPackage.CreateObject!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateObjectAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string resName = LuaAPI.lua_tostring(L, 2);
                    FairyGUI.UIPackage.CreateObjectCallback callback = translator.GetDelegate<FairyGUI.UIPackage.CreateObjectCallback>(L, 3);
                    
                    __cl_gen_to_be_invoked.CreateObjectAsync( resName, callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItemAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string resName = LuaAPI.lua_tostring(L, 2);
                    
                        object __cl_gen_ret = __cl_gen_to_be_invoked.GetItemAsset( resName );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<FairyGUI.PackageItem>(L, 2)) 
                {
                    FairyGUI.PackageItem item = (FairyGUI.PackageItem)translator.GetObject(L, 2, typeof(FairyGUI.PackageItem));
                    
                        object __cl_gen_ret = __cl_gen_to_be_invoked.GetItemAsset( item );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.UIPackage.GetItemAsset!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItems(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.List<FairyGUI.PackageItem> __cl_gen_ret = __cl_gen_to_be_invoked.GetItems(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string itemId = LuaAPI.lua_tostring(L, 2);
                    
                        FairyGUI.PackageItem __cl_gen_ret = __cl_gen_to_be_invoked.GetItem( itemId );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItemByName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string itemName = LuaAPI.lua_tostring(L, 2);
                    
                        FairyGUI.PackageItem __cl_gen_ret = __cl_gen_to_be_invoked.GetItemByName( itemName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_id(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.id);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.name);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_assetPath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.assetPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_customId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.customId);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_customId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.UIPackage __cl_gen_to_be_invoked = (FairyGUI.UIPackage)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.customId = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
