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
    public class UnityEngineScreenWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Screen);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 12, 7);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SetResolution", _m_SetResolution_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "resolutions", _g_get_resolutions);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "currentResolution", _g_get_currentResolution);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "width", _g_get_width);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "height", _g_get_height);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "dpi", _g_get_dpi);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fullScreen", _g_get_fullScreen);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "autorotateToPortrait", _g_get_autorotateToPortrait);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "autorotateToPortraitUpsideDown", _g_get_autorotateToPortraitUpsideDown);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "autorotateToLandscapeLeft", _g_get_autorotateToLandscapeLeft);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "autorotateToLandscapeRight", _g_get_autorotateToLandscapeRight);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "orientation", _g_get_orientation);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sleepTimeout", _g_get_sleepTimeout);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fullScreen", _s_set_fullScreen);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "autorotateToPortrait", _s_set_autorotateToPortrait);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "autorotateToPortraitUpsideDown", _s_set_autorotateToPortraitUpsideDown);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "autorotateToLandscapeLeft", _s_set_autorotateToLandscapeLeft);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "autorotateToLandscapeRight", _s_set_autorotateToLandscapeRight);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "orientation", _s_set_orientation);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "sleepTimeout", _s_set_sleepTimeout);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Screen __cl_gen_ret = new UnityEngine.Screen();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Screen constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetResolution_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int width = LuaAPI.xlua_tointeger(L, 1);
                    int height = LuaAPI.xlua_tointeger(L, 2);
                    bool fullscreen = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Screen.SetResolution( width, height, fullscreen );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int width = LuaAPI.xlua_tointeger(L, 1);
                    int height = LuaAPI.xlua_tointeger(L, 2);
                    bool fullscreen = LuaAPI.lua_toboolean(L, 3);
                    int preferredRefreshRate = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Screen.SetResolution( width, height, fullscreen, preferredRefreshRate );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Screen.SetResolution!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_resolutions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Screen.resolutions);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Screen.currentResolution);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_width(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Screen.width);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_height(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Screen.height);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dpi(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Screen.dpi);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fullScreen(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Screen.fullScreen);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autorotateToPortrait(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Screen.autorotateToPortrait);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autorotateToPortraitUpsideDown(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Screen.autorotateToPortraitUpsideDown);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autorotateToLandscapeLeft(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Screen.autorotateToLandscapeLeft);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autorotateToLandscapeRight(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Screen.autorotateToLandscapeRight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_orientation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Screen.orientation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sleepTimeout(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Screen.sleepTimeout);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fullScreen(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Screen.fullScreen = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autorotateToPortrait(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Screen.autorotateToPortrait = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autorotateToPortraitUpsideDown(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Screen.autorotateToPortraitUpsideDown = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autorotateToLandscapeLeft(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Screen.autorotateToLandscapeLeft = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autorotateToLandscapeRight(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Screen.autorotateToLandscapeRight = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_orientation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.ScreenOrientation __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.Screen.orientation = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sleepTimeout(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Screen.sleepTimeout = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
