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
    public class AppConstWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(AppConst);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 9, 3);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ToValidFileName", _m_ToValidFileName_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExtName", AppConst.ExtName);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AppExternalDataPath", _g_get_AppExternalDataPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AppExternalDataPathUrl", _g_get_AppExternalDataPathUrl);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "SourceResPathUrl", _g_get_SourceResPathUrl);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LuaPath", _g_get_LuaPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ABPath", _g_get_ABPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "TestAccount", _g_get_TestAccount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "DebugMode", _g_get_DebugMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "serverIP", _g_get_serverIP);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LuaExtNames", _g_get_LuaExtNames);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "DebugMode", _s_set_DebugMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "serverIP", _s_set_serverIP);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LuaExtNames", _s_set_LuaExtNames);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					AppConst __cl_gen_ret = new AppConst();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to AppConst constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToValidFileName_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string rootPath = LuaAPI.lua_tostring(L, 1);
                    string fileName = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = AppConst.ToValidFileName( rootPath, fileName );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AppExternalDataPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, AppConst.AppExternalDataPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AppExternalDataPathUrl(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, AppConst.AppExternalDataPathUrl);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SourceResPathUrl(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, AppConst.SourceResPathUrl);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LuaPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, AppConst.LuaPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ABPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, AppConst.ABPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TestAccount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushAny(L, AppConst.TestAccount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DebugMode(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, AppConst.DebugMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_serverIP(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, AppConst.serverIP);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LuaExtNames(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, AppConst.LuaExtNames);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DebugMode(RealStatePtr L)
        {
		    try {
                
			    AppConst.DebugMode = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_serverIP(RealStatePtr L)
        {
		    try {
                
			    AppConst.serverIP = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LuaExtNames(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    AppConst.LuaExtNames = (System.Collections.Generic.List<string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<string>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
