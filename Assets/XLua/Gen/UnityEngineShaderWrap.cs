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
    public class UnityEngineShaderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Shader);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 3, 1);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSupported", _g_get_isSupported);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maximumLOD", _g_get_maximumLOD);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderQueue", _g_get_renderQueue);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "maximumLOD", _s_set_maximumLOD);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 26, 2, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Find", _m_Find_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EnableKeyword", _m_EnableKeyword_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DisableKeyword", _m_DisableKeyword_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsKeywordEnabled", _m_IsKeywordEnabled_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalBuffer", _m_SetGlobalBuffer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PropertyToID", _m_PropertyToID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WarmupAllShaders", _m_WarmupAllShaders_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalFloat", _m_SetGlobalFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalInt", _m_SetGlobalInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalVector", _m_SetGlobalVector_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalColor", _m_SetGlobalColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalMatrix", _m_SetGlobalMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalTexture", _m_SetGlobalTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalFloatArray", _m_SetGlobalFloatArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalVectorArray", _m_SetGlobalVectorArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalMatrixArray", _m_SetGlobalMatrixArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalFloat", _m_GetGlobalFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalInt", _m_GetGlobalInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalVector", _m_GetGlobalVector_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalColor", _m_GetGlobalColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalMatrix", _m_GetGlobalMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalTexture", _m_GetGlobalTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalFloatArray", _m_GetGlobalFloatArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalVectorArray", _m_GetGlobalVectorArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalMatrixArray", _m_GetGlobalMatrixArray_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "globalMaximumLOD", _g_get_globalMaximumLOD);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "globalRenderPipeline", _g_get_globalRenderPipeline);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "globalMaximumLOD", _s_set_globalMaximumLOD);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "globalRenderPipeline", _s_set_globalRenderPipeline);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Shader __cl_gen_ret = new UnityEngine.Shader();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Find_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Shader __cl_gen_ret = UnityEngine.Shader.Find( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnableKeyword_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string keyword = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Shader.EnableKeyword( keyword );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisableKeyword_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string keyword = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Shader.DisableKeyword( keyword );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsKeywordEnabled_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string keyword = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = UnityEngine.Shader.IsKeywordEnabled( keyword );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalBuffer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.ComputeBuffer buffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Shader.SetGlobalBuffer( nameID, buffer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.ComputeBuffer buffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Shader.SetGlobalBuffer( name, buffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalBuffer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PropertyToID_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.Shader.PropertyToID( name );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WarmupAllShaders_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.Shader.WarmupAllShaders(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalFloat_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Shader.SetGlobalFloat( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Shader.SetGlobalFloat( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalInt_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    int value = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Shader.SetGlobalInt( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    int value = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Shader.SetGlobalInt( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalVector_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Vector4>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Vector4 value;translator.Get(L, 2, out value);
                    
                    UnityEngine.Shader.SetGlobalVector( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector4>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Vector4 value;translator.Get(L, 2, out value);
                    
                    UnityEngine.Shader.SetGlobalVector( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Color>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Color value;translator.Get(L, 2, out value);
                    
                    UnityEngine.Shader.SetGlobalColor( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Color>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Color value;translator.Get(L, 2, out value);
                    
                    UnityEngine.Shader.SetGlobalColor( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Matrix4x4 value;translator.Get(L, 2, out value);
                    
                    UnityEngine.Shader.SetGlobalMatrix( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Matrix4x4 value;translator.Get(L, 2, out value);
                    
                    UnityEngine.Shader.SetGlobalMatrix( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture value = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Shader.SetGlobalTexture( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Texture value = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Shader.SetGlobalTexture( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalFloatArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<float> values = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    UnityEngine.Shader.SetGlobalFloatArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<float[]>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    float[] values = (float[])translator.GetObject(L, 2, typeof(float[]));
                    
                    UnityEngine.Shader.SetGlobalFloatArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<float> values = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    UnityEngine.Shader.SetGlobalFloatArray( name, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<float[]>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    float[] values = (float[])translator.GetObject(L, 2, typeof(float[]));
                    
                    UnityEngine.Shader.SetGlobalFloatArray( name, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalFloatArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalVectorArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<UnityEngine.Vector4> values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.Shader.SetGlobalVectorArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Vector4[]>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Vector4[] values = (UnityEngine.Vector4[])translator.GetObject(L, 2, typeof(UnityEngine.Vector4[]));
                    
                    UnityEngine.Shader.SetGlobalVectorArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<UnityEngine.Vector4> values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.Shader.SetGlobalVectorArray( name, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector4[]>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Vector4[] values = (UnityEngine.Vector4[])translator.GetObject(L, 2, typeof(UnityEngine.Vector4[]));
                    
                    UnityEngine.Shader.SetGlobalVectorArray( name, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalVectorArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalMatrixArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    UnityEngine.Shader.SetGlobalMatrixArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Matrix4x4[] values = (UnityEngine.Matrix4x4[])translator.GetObject(L, 2, typeof(UnityEngine.Matrix4x4[]));
                    
                    UnityEngine.Shader.SetGlobalMatrixArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    UnityEngine.Shader.SetGlobalMatrixArray( name, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Matrix4x4[] values = (UnityEngine.Matrix4x4[])translator.GetObject(L, 2, typeof(UnityEngine.Matrix4x4[]));
                    
                    UnityEngine.Shader.SetGlobalMatrixArray( name, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalMatrixArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalFloat_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        float __cl_gen_ret = UnityEngine.Shader.GetGlobalFloat( nameID );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        float __cl_gen_ret = UnityEngine.Shader.GetGlobalFloat( name );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalInt_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.Shader.GetGlobalInt( nameID );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.Shader.GetGlobalInt( name );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalVector_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.Vector4 __cl_gen_ret = UnityEngine.Shader.GetGlobalVector( nameID );
                        translator.PushUnityEngineVector4(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Vector4 __cl_gen_ret = UnityEngine.Shader.GetGlobalVector( name );
                        translator.PushUnityEngineVector4(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.Color __cl_gen_ret = UnityEngine.Shader.GetGlobalColor( nameID );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Color __cl_gen_ret = UnityEngine.Shader.GetGlobalColor( name );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.Matrix4x4 __cl_gen_ret = UnityEngine.Shader.GetGlobalMatrix( nameID );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Matrix4x4 __cl_gen_ret = UnityEngine.Shader.GetGlobalMatrix( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.Texture __cl_gen_ret = UnityEngine.Shader.GetGlobalTexture( nameID );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Texture __cl_gen_ret = UnityEngine.Shader.GetGlobalTexture( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalFloatArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        float[] __cl_gen_ret = UnityEngine.Shader.GetGlobalFloatArray( nameID );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        float[] __cl_gen_ret = UnityEngine.Shader.GetGlobalFloatArray( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<float> values = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    UnityEngine.Shader.GetGlobalFloatArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<float> values = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    UnityEngine.Shader.GetGlobalFloatArray( name, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalFloatArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalVectorArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.Vector4[] __cl_gen_ret = UnityEngine.Shader.GetGlobalVectorArray( nameID );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Vector4[] __cl_gen_ret = UnityEngine.Shader.GetGlobalVectorArray( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<UnityEngine.Vector4> values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.Shader.GetGlobalVectorArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<UnityEngine.Vector4> values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.Shader.GetGlobalVectorArray( name, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalVectorArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalMatrixArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.Matrix4x4[] __cl_gen_ret = UnityEngine.Shader.GetGlobalMatrixArray( nameID );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Matrix4x4[] __cl_gen_ret = UnityEngine.Shader.GetGlobalMatrixArray( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 2)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    UnityEngine.Shader.GetGlobalMatrixArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    UnityEngine.Shader.GetGlobalMatrixArray( name, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalMatrixArray!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isSupported(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Shader __cl_gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isSupported);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maximumLOD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Shader __cl_gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.maximumLOD);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_globalMaximumLOD(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Shader.globalMaximumLOD);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_globalRenderPipeline(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.Shader.globalRenderPipeline);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderQueue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Shader __cl_gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.renderQueue);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maximumLOD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Shader __cl_gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maximumLOD = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_globalMaximumLOD(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Shader.globalMaximumLOD = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_globalRenderPipeline(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Shader.globalRenderPipeline = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
