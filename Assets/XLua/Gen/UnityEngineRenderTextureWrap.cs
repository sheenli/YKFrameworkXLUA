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
    public class UnityEngineRenderTextureWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.RenderTexture);
			Utils.BeginObjectRegister(type, L, translator, 0, 8, 14, 11);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Create", _m_Create);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Release", _m_Release);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsCreated", _m_IsCreated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DiscardContents", _m_DiscardContents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MarkRestoreExpected", _m_MarkRestoreExpected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GenerateMips", _m_GenerateMips);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNativeDepthBufferPtr", _m_GetNativeDepthBufferPtr);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalShaderProperty", _m_SetGlobalShaderProperty);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "width", _g_get_width);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "height", _g_get_height);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPowerOfTwo", _g_get_isPowerOfTwo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sRGB", _g_get_sRGB);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "format", _g_get_format);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useMipMap", _g_get_useMipMap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoGenerateMips", _g_get_autoGenerateMips);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dimension", _g_get_dimension);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "volumeDepth", _g_get_volumeDepth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "antiAliasing", _g_get_antiAliasing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableRandomWrite", _g_get_enableRandomWrite);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorBuffer", _g_get_colorBuffer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depthBuffer", _g_get_depthBuffer);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "width", _s_set_width);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "height", _s_set_height);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depth", _s_set_depth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isPowerOfTwo", _s_set_isPowerOfTwo);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "format", _s_set_format);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useMipMap", _s_set_useMipMap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoGenerateMips", _s_set_autoGenerateMips);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dimension", _s_set_dimension);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "volumeDepth", _s_set_volumeDepth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "antiAliasing", _s_set_antiAliasing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableRandomWrite", _s_set_enableRandomWrite);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTemporary", _m_GetTemporary_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReleaseTemporary", _m_ReleaseTemporary_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SupportsStencil", _m_SupportsStencil_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "active", _g_get_active);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "active", _s_set_active);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.RenderTextureFormat>(L, 5) && translator.Assignable<UnityEngine.RenderTextureReadWrite>(L, 6))
				{
					int width = LuaAPI.xlua_tointeger(L, 2);
					int height = LuaAPI.xlua_tointeger(L, 3);
					int depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.RenderTextureFormat format;translator.Get(L, 5, out format);
					UnityEngine.RenderTextureReadWrite readWrite;translator.Get(L, 6, out readWrite);
					
					UnityEngine.RenderTexture __cl_gen_ret = new UnityEngine.RenderTexture(width, height, depth, format, readWrite);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.RenderTextureFormat>(L, 5))
				{
					int width = LuaAPI.xlua_tointeger(L, 2);
					int height = LuaAPI.xlua_tointeger(L, 3);
					int depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.RenderTextureFormat format;translator.Get(L, 5, out format);
					
					UnityEngine.RenderTexture __cl_gen_ret = new UnityEngine.RenderTexture(width, height, depth, format);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					int width = LuaAPI.xlua_tointeger(L, 2);
					int height = LuaAPI.xlua_tointeger(L, 3);
					int depth = LuaAPI.xlua_tointeger(L, 4);
					
					UnityEngine.RenderTexture __cl_gen_ret = new UnityEngine.RenderTexture(width, height, depth);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RenderTexture constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTemporary_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int width = LuaAPI.xlua_tointeger(L, 1);
                    int height = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.RenderTexture __cl_gen_ret = UnityEngine.RenderTexture.GetTemporary( width, height );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int width = LuaAPI.xlua_tointeger(L, 1);
                    int height = LuaAPI.xlua_tointeger(L, 2);
                    int depthBuffer = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.RenderTexture __cl_gen_ret = UnityEngine.RenderTexture.GetTemporary( width, height, depthBuffer );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.RenderTextureFormat>(L, 4)) 
                {
                    int width = LuaAPI.xlua_tointeger(L, 1);
                    int height = LuaAPI.xlua_tointeger(L, 2);
                    int depthBuffer = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.RenderTextureFormat format;translator.Get(L, 4, out format);
                    
                        UnityEngine.RenderTexture __cl_gen_ret = UnityEngine.RenderTexture.GetTemporary( width, height, depthBuffer, format );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.RenderTextureFormat>(L, 4)&& translator.Assignable<UnityEngine.RenderTextureReadWrite>(L, 5)) 
                {
                    int width = LuaAPI.xlua_tointeger(L, 1);
                    int height = LuaAPI.xlua_tointeger(L, 2);
                    int depthBuffer = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.RenderTextureFormat format;translator.Get(L, 4, out format);
                    UnityEngine.RenderTextureReadWrite readWrite;translator.Get(L, 5, out readWrite);
                    
                        UnityEngine.RenderTexture __cl_gen_ret = UnityEngine.RenderTexture.GetTemporary( width, height, depthBuffer, format, readWrite );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.RenderTextureFormat>(L, 4)&& translator.Assignable<UnityEngine.RenderTextureReadWrite>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    int width = LuaAPI.xlua_tointeger(L, 1);
                    int height = LuaAPI.xlua_tointeger(L, 2);
                    int depthBuffer = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.RenderTextureFormat format;translator.Get(L, 4, out format);
                    UnityEngine.RenderTextureReadWrite readWrite;translator.Get(L, 5, out readWrite);
                    int antiAliasing = LuaAPI.xlua_tointeger(L, 6);
                    
                        UnityEngine.RenderTexture __cl_gen_ret = UnityEngine.RenderTexture.GetTemporary( width, height, depthBuffer, format, readWrite, antiAliasing );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RenderTexture.GetTemporary!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleaseTemporary_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.RenderTexture temp = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    
                    UnityEngine.RenderTexture.ReleaseTemporary( temp );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Create(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Release(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Release(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsCreated(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsCreated(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DiscardContents(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.DiscardContents(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    bool discardColor = LuaAPI.lua_toboolean(L, 2);
                    bool discardDepth = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.DiscardContents( discardColor, discardDepth );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RenderTexture.DiscardContents!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MarkRestoreExpected(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.MarkRestoreExpected(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GenerateMips(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.GenerateMips(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNativeDepthBufferPtr(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.IntPtr __cl_gen_ret = __cl_gen_to_be_invoked.GetNativeDepthBufferPtr(  );
                        LuaAPI.lua_pushlightuserdata(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalShaderProperty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string propertyName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.SetGlobalShaderProperty( propertyName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SupportsStencil_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.RenderTexture rt = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    
                        bool __cl_gen_ret = UnityEngine.RenderTexture.SupportsStencil( rt );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_width(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.width);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_height(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.height);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.depth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isPowerOfTwo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isPowerOfTwo);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sRGB(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.sRGB);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_format(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.format);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useMipMap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useMipMap);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoGenerateMips(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.autoGenerateMips);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dimension(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.dimension);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_volumeDepth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.volumeDepth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_antiAliasing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.antiAliasing);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableRandomWrite(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.enableRandomWrite);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colorBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.colorBuffer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depthBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.depthBuffer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_active(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.RenderTexture.active);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_width(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.width = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_height(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.height = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.depth = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isPowerOfTwo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isPowerOfTwo = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_format(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                UnityEngine.RenderTextureFormat __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.format = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useMipMap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useMipMap = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoGenerateMips(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.autoGenerateMips = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dimension(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                UnityEngine.Rendering.TextureDimension __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.dimension = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_volumeDepth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.volumeDepth = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_antiAliasing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.antiAliasing = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableRandomWrite(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTexture __cl_gen_to_be_invoked = (UnityEngine.RenderTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.enableRandomWrite = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_active(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    UnityEngine.RenderTexture.active = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
