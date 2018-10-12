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
    public class UnityEngineTexture2DWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Texture2D);
			Utils.BeginObjectRegister(type, L, translator, 0, 19, 3, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateExternalTexture", _m_UpdateExternalTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixel", _m_SetPixel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixel", _m_GetPixel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixelBilinear", _m_GetPixelBilinear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixels", _m_SetPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixels32", _m_SetPixels32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadImage", _m_LoadImage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadRawTextureData", _m_LoadRawTextureData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRawTextureData", _m_GetRawTextureData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixels", _m_GetPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixels32", _m_GetPixels32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Apply", _m_Apply);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Resize", _m_Resize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Compress", _m_Compress);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PackTextures", _m_PackTextures);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadPixels", _m_ReadPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EncodeToPNG", _m_EncodeToPNG);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EncodeToJPG", _m_EncodeToJPG);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EncodeToEXR", _m_EncodeToEXR);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "mipmapCount", _g_get_mipmapCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "format", _g_get_format);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alphaIsTransparency", _g_get_alphaIsTransparency);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "alphaIsTransparency", _s_set_alphaIsTransparency);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 2, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateExternalTexture", _m_CreateExternalTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GenerateAtlas", _m_GenerateAtlas_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "whiteTexture", _g_get_whiteTexture);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "blackTexture", _g_get_blackTexture);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					int width = LuaAPI.xlua_tointeger(L, 2);
					int height = LuaAPI.xlua_tointeger(L, 3);
					
					UnityEngine.Texture2D __cl_gen_ret = new UnityEngine.Texture2D(width, height);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.TextureFormat>(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5))
				{
					int width = LuaAPI.xlua_tointeger(L, 2);
					int height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.TextureFormat format;translator.Get(L, 4, out format);
					bool mipmap = LuaAPI.lua_toboolean(L, 5);
					
					UnityEngine.Texture2D __cl_gen_ret = new UnityEngine.Texture2D(width, height, format, mipmap);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.TextureFormat>(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					int width = LuaAPI.xlua_tointeger(L, 2);
					int height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.TextureFormat format;translator.Get(L, 4, out format);
					bool mipmap = LuaAPI.lua_toboolean(L, 5);
					bool linear = LuaAPI.lua_toboolean(L, 6);
					
					UnityEngine.Texture2D __cl_gen_ret = new UnityEngine.Texture2D(width, height, format, mipmap, linear);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateExternalTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int width = LuaAPI.xlua_tointeger(L, 1);
                    int height = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.TextureFormat format;translator.Get(L, 3, out format);
                    bool mipmap = LuaAPI.lua_toboolean(L, 4);
                    bool linear = LuaAPI.lua_toboolean(L, 5);
                    System.IntPtr nativeTex = LuaAPI.lua_touserdata(L, 6);
                    
                        UnityEngine.Texture2D __cl_gen_ret = UnityEngine.Texture2D.CreateExternalTexture( width, height, format, mipmap, linear, nativeTex );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateExternalTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr nativeTex = LuaAPI.lua_touserdata(L, 2);
                    
                    __cl_gen_to_be_invoked.UpdateExternalTexture( nativeTex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int x = LuaAPI.xlua_tointeger(L, 2);
                    int y = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Color color;translator.Get(L, 4, out color);
                    
                    __cl_gen_to_be_invoked.SetPixel( x, y, color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int x = LuaAPI.xlua_tointeger(L, 2);
                    int y = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Color __cl_gen_ret = __cl_gen_to_be_invoked.GetPixel( x, y );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixelBilinear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float u = (float)LuaAPI.lua_tonumber(L, 2);
                    float v = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Color __cl_gen_ret = __cl_gen_to_be_invoked.GetPixelBilinear( u, v );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Color[]>(L, 2)) 
                {
                    UnityEngine.Color[] colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    
                    __cl_gen_to_be_invoked.SetPixels( colors );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Color[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Color[] colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    int miplevel = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetPixels( colors, miplevel );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Color[]>(L, 6)) 
                {
                    int x = LuaAPI.xlua_tointeger(L, 2);
                    int y = LuaAPI.xlua_tointeger(L, 3);
                    int blockWidth = LuaAPI.xlua_tointeger(L, 4);
                    int blockHeight = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Color[] colors = (UnityEngine.Color[])translator.GetObject(L, 6, typeof(UnityEngine.Color[]));
                    
                    __cl_gen_to_be_invoked.SetPixels( x, y, blockWidth, blockHeight, colors );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Color[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    int x = LuaAPI.xlua_tointeger(L, 2);
                    int y = LuaAPI.xlua_tointeger(L, 3);
                    int blockWidth = LuaAPI.xlua_tointeger(L, 4);
                    int blockHeight = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Color[] colors = (UnityEngine.Color[])translator.GetObject(L, 6, typeof(UnityEngine.Color[]));
                    int miplevel = LuaAPI.xlua_tointeger(L, 7);
                    
                    __cl_gen_to_be_invoked.SetPixels( x, y, blockWidth, blockHeight, colors, miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.SetPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixels32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Color32[]>(L, 2)) 
                {
                    UnityEngine.Color32[] colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
                    
                    __cl_gen_to_be_invoked.SetPixels32( colors );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Color32[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Color32[] colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
                    int miplevel = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetPixels32( colors, miplevel );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Color32[]>(L, 6)) 
                {
                    int x = LuaAPI.xlua_tointeger(L, 2);
                    int y = LuaAPI.xlua_tointeger(L, 3);
                    int blockWidth = LuaAPI.xlua_tointeger(L, 4);
                    int blockHeight = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Color32[] colors = (UnityEngine.Color32[])translator.GetObject(L, 6, typeof(UnityEngine.Color32[]));
                    
                    __cl_gen_to_be_invoked.SetPixels32( x, y, blockWidth, blockHeight, colors );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Color32[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    int x = LuaAPI.xlua_tointeger(L, 2);
                    int y = LuaAPI.xlua_tointeger(L, 3);
                    int blockWidth = LuaAPI.xlua_tointeger(L, 4);
                    int blockHeight = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Color32[] colors = (UnityEngine.Color32[])translator.GetObject(L, 6, typeof(UnityEngine.Color32[]));
                    int miplevel = LuaAPI.xlua_tointeger(L, 7);
                    
                    __cl_gen_to_be_invoked.SetPixels32( x, y, blockWidth, blockHeight, colors, miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.SetPixels32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadImage(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] data = LuaAPI.lua_tobytes(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.LoadImage( data );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    byte[] data = LuaAPI.lua_tobytes(L, 2);
                    bool markNonReadable = LuaAPI.lua_toboolean(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.LoadImage( data, markNonReadable );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.LoadImage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadRawTextureData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr data = LuaAPI.lua_touserdata(L, 2);
                    int size = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.LoadRawTextureData( data, size );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] data = LuaAPI.lua_tobytes(L, 2);
                    
                    __cl_gen_to_be_invoked.LoadRawTextureData( data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.LoadRawTextureData!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRawTextureData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        byte[] __cl_gen_ret = __cl_gen_to_be_invoked.GetRawTextureData(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        UnityEngine.Color[] __cl_gen_ret = __cl_gen_to_be_invoked.GetPixels(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int miplevel = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Color[] __cl_gen_ret = __cl_gen_to_be_invoked.GetPixels( miplevel );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int x = LuaAPI.xlua_tointeger(L, 2);
                    int y = LuaAPI.xlua_tointeger(L, 3);
                    int blockWidth = LuaAPI.xlua_tointeger(L, 4);
                    int blockHeight = LuaAPI.xlua_tointeger(L, 5);
                    
                        UnityEngine.Color[] __cl_gen_ret = __cl_gen_to_be_invoked.GetPixels( x, y, blockWidth, blockHeight );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    int x = LuaAPI.xlua_tointeger(L, 2);
                    int y = LuaAPI.xlua_tointeger(L, 3);
                    int blockWidth = LuaAPI.xlua_tointeger(L, 4);
                    int blockHeight = LuaAPI.xlua_tointeger(L, 5);
                    int miplevel = LuaAPI.xlua_tointeger(L, 6);
                    
                        UnityEngine.Color[] __cl_gen_ret = __cl_gen_to_be_invoked.GetPixels( x, y, blockWidth, blockHeight, miplevel );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.GetPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixels32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        UnityEngine.Color32[] __cl_gen_ret = __cl_gen_to_be_invoked.GetPixels32(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int miplevel = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Color32[] __cl_gen_ret = __cl_gen_to_be_invoked.GetPixels32( miplevel );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.GetPixels32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Apply(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Apply(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool updateMipmaps = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Apply( updateMipmaps );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    bool updateMipmaps = LuaAPI.lua_toboolean(L, 2);
                    bool makeNoLongerReadable = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.Apply( updateMipmaps, makeNoLongerReadable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.Apply!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Resize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int width = LuaAPI.xlua_tointeger(L, 2);
                    int height = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Resize( width, height );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.TextureFormat>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    int width = LuaAPI.xlua_tointeger(L, 2);
                    int height = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.TextureFormat format;translator.Get(L, 4, out format);
                    bool hasMipMap = LuaAPI.lua_toboolean(L, 5);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Resize( width, height, format, hasMipMap );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.Resize!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Compress(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool highQuality = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Compress( highQuality );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PackTextures(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Texture2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Texture2D[] textures = (UnityEngine.Texture2D[])translator.GetObject(L, 2, typeof(UnityEngine.Texture2D[]));
                    int padding = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Rect[] __cl_gen_ret = __cl_gen_to_be_invoked.PackTextures( textures, padding );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Texture2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Texture2D[] textures = (UnityEngine.Texture2D[])translator.GetObject(L, 2, typeof(UnityEngine.Texture2D[]));
                    int padding = LuaAPI.xlua_tointeger(L, 3);
                    int maximumAtlasSize = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.Rect[] __cl_gen_ret = __cl_gen_to_be_invoked.PackTextures( textures, padding, maximumAtlasSize );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Texture2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Texture2D[] textures = (UnityEngine.Texture2D[])translator.GetObject(L, 2, typeof(UnityEngine.Texture2D[]));
                    int padding = LuaAPI.xlua_tointeger(L, 3);
                    int maximumAtlasSize = LuaAPI.xlua_tointeger(L, 4);
                    bool makeNoLongerReadable = LuaAPI.lua_toboolean(L, 5);
                    
                        UnityEngine.Rect[] __cl_gen_ret = __cl_gen_to_be_invoked.PackTextures( textures, padding, maximumAtlasSize, makeNoLongerReadable );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.PackTextures!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GenerateAtlas_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector2[] sizes = (UnityEngine.Vector2[])translator.GetObject(L, 1, typeof(UnityEngine.Vector2[]));
                    int padding = LuaAPI.xlua_tointeger(L, 2);
                    int atlasSize = LuaAPI.xlua_tointeger(L, 3);
                    System.Collections.Generic.List<UnityEngine.Rect> results = (System.Collections.Generic.List<UnityEngine.Rect>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Rect>));
                    
                        bool __cl_gen_ret = UnityEngine.Texture2D.GenerateAtlas( sizes, padding, atlasSize, results );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadPixels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect source;translator.Get(L, 2, out source);
                    int destX = LuaAPI.xlua_tointeger(L, 3);
                    int destY = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.ReadPixels( source, destX, destY );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Rect source;translator.Get(L, 2, out source);
                    int destX = LuaAPI.xlua_tointeger(L, 3);
                    int destY = LuaAPI.xlua_tointeger(L, 4);
                    bool recalculateMipMaps = LuaAPI.lua_toboolean(L, 5);
                    
                    __cl_gen_to_be_invoked.ReadPixels( source, destX, destY, recalculateMipMaps );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.ReadPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeToPNG(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        byte[] __cl_gen_ret = __cl_gen_to_be_invoked.EncodeToPNG(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeToJPG(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        byte[] __cl_gen_ret = __cl_gen_to_be_invoked.EncodeToJPG(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int quality = LuaAPI.xlua_tointeger(L, 2);
                    
                        byte[] __cl_gen_ret = __cl_gen_to_be_invoked.EncodeToJPG( quality );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.EncodeToJPG!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeToEXR(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        byte[] __cl_gen_ret = __cl_gen_to_be_invoked.EncodeToEXR(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Texture2D.EXRFlags>(L, 2)) 
                {
                    UnityEngine.Texture2D.EXRFlags flags;translator.Get(L, 2, out flags);
                    
                        byte[] __cl_gen_ret = __cl_gen_to_be_invoked.EncodeToEXR( flags );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2D.EncodeToEXR!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mipmapCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.mipmapCount);
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
			
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.format);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_whiteTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Texture2D.whiteTexture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blackTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Texture2D.blackTexture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alphaIsTransparency(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.alphaIsTransparency);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alphaIsTransparency(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2D __cl_gen_to_be_invoked = (UnityEngine.Texture2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.alphaIsTransparency = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
