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
    public class UnityEnginePlayerPrefsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.PlayerPrefs);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SetInt", _m_SetInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetInt", _m_GetInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetFloat", _m_SetFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFloat", _m_GetFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetString", _m_SetString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetString", _m_GetString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HasKey", _m_HasKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DeleteKey", _m_DeleteKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DeleteAll", _m_DeleteAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Save", _m_Save_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.PlayerPrefs __cl_gen_ret = new UnityEngine.PlayerPrefs();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PlayerPrefs constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInt_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    int value = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.PlayerPrefs.SetInt( key, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInt_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.PlayerPrefs.GetInt( key );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    int defaultValue = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = UnityEngine.PlayerPrefs.GetInt( key, defaultValue );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PlayerPrefs.GetInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloat_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.PlayerPrefs.SetFloat( key, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloat_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    
                        float __cl_gen_ret = UnityEngine.PlayerPrefs.GetFloat( key );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    float defaultValue = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        float __cl_gen_ret = UnityEngine.PlayerPrefs.GetFloat( key, defaultValue );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PlayerPrefs.GetFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetString_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    string value = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.PlayerPrefs.SetString( key, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetString_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = UnityEngine.PlayerPrefs.GetString( key );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    string defaultValue = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = UnityEngine.PlayerPrefs.GetString( key, defaultValue );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PlayerPrefs.GetString!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasKey_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = UnityEngine.PlayerPrefs.HasKey( key );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteKey_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string key = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.PlayerPrefs.DeleteKey( key );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.PlayerPrefs.DeleteAll(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Save_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.PlayerPrefs.Save(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
