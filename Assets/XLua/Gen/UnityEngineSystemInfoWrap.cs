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
    public class UnityEngineSystemInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.SystemInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 45, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SupportsRenderTextureFormat", _m_SupportsRenderTextureFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SupportsTextureFormat", _m_SupportsTextureFormat_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "unsupportedIdentifier", UnityEngine.SystemInfo.unsupportedIdentifier);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "batteryLevel", _g_get_batteryLevel);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "batteryStatus", _g_get_batteryStatus);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "operatingSystem", _g_get_operatingSystem);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "operatingSystemFamily", _g_get_operatingSystemFamily);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "processorType", _g_get_processorType);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "processorFrequency", _g_get_processorFrequency);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "processorCount", _g_get_processorCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "systemMemorySize", _g_get_systemMemorySize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsMemorySize", _g_get_graphicsMemorySize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceName", _g_get_graphicsDeviceName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceVendor", _g_get_graphicsDeviceVendor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceID", _g_get_graphicsDeviceID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceVendorID", _g_get_graphicsDeviceVendorID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceType", _g_get_graphicsDeviceType);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsUVStartsAtTop", _g_get_graphicsUVStartsAtTop);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceVersion", _g_get_graphicsDeviceVersion);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsShaderLevel", _g_get_graphicsShaderLevel);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsMultiThreaded", _g_get_graphicsMultiThreaded);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsShadows", _g_get_supportsShadows);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsRawShadowDepthSampling", _g_get_supportsRawShadowDepthSampling);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsMotionVectors", _g_get_supportsMotionVectors);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsRenderToCubemap", _g_get_supportsRenderToCubemap);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsImageEffects", _g_get_supportsImageEffects);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supports3DTextures", _g_get_supports3DTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supports2DArrayTextures", _g_get_supports2DArrayTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supports3DRenderTextures", _g_get_supports3DRenderTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsCubemapArrayTextures", _g_get_supportsCubemapArrayTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "copyTextureSupport", _g_get_copyTextureSupport);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsComputeShaders", _g_get_supportsComputeShaders);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsInstancing", _g_get_supportsInstancing);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsSparseTextures", _g_get_supportsSparseTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportedRenderTargetCount", _g_get_supportedRenderTargetCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "usesReversedZBuffer", _g_get_usesReversedZBuffer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "npotSupport", _g_get_npotSupport);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deviceUniqueIdentifier", _g_get_deviceUniqueIdentifier);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deviceName", _g_get_deviceName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deviceModel", _g_get_deviceModel);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsAccelerometer", _g_get_supportsAccelerometer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsGyroscope", _g_get_supportsGyroscope);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsLocationService", _g_get_supportsLocationService);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsVibration", _g_get_supportsVibration);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsAudio", _g_get_supportsAudio);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deviceType", _g_get_deviceType);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxTextureSize", _g_get_maxTextureSize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxCubemapSize", _g_get_maxCubemapSize);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.SystemInfo __cl_gen_ret = new UnityEngine.SystemInfo();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SystemInfo constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SupportsRenderTextureFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.RenderTextureFormat format;translator.Get(L, 1, out format);
                    
                        bool __cl_gen_ret = UnityEngine.SystemInfo.SupportsRenderTextureFormat( format );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SupportsTextureFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.TextureFormat format;translator.Get(L, 1, out format);
                    
                        bool __cl_gen_ret = UnityEngine.SystemInfo.SupportsTextureFormat( format );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_batteryLevel(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.SystemInfo.batteryLevel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_batteryStatus(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.batteryStatus);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_operatingSystem(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.operatingSystem);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_operatingSystemFamily(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.operatingSystemFamily);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_processorType(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.processorType);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_processorFrequency(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.processorFrequency);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_processorCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.processorCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_systemMemorySize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.systemMemorySize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsMemorySize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.graphicsMemorySize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.graphicsDeviceName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceVendor(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.graphicsDeviceVendor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceID(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.graphicsDeviceID);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceVendorID(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.graphicsDeviceVendorID);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.graphicsDeviceType);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsUVStartsAtTop(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.graphicsUVStartsAtTop);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceVersion(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.graphicsDeviceVersion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsShaderLevel(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.graphicsShaderLevel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsMultiThreaded(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.graphicsMultiThreaded);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsShadows(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsShadows);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsRawShadowDepthSampling(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsRawShadowDepthSampling);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsMotionVectors(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsMotionVectors);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsRenderToCubemap(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsRenderToCubemap);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsImageEffects(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsImageEffects);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supports3DTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supports3DTextures);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supports2DArrayTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supports2DArrayTextures);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supports3DRenderTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supports3DRenderTextures);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsCubemapArrayTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsCubemapArrayTextures);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_copyTextureSupport(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.copyTextureSupport);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsComputeShaders(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsComputeShaders);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsInstancing(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsInstancing);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsSparseTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsSparseTextures);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportedRenderTargetCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.supportedRenderTargetCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usesReversedZBuffer(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.usesReversedZBuffer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_npotSupport(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.npotSupport);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceUniqueIdentifier(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.deviceUniqueIdentifier);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.deviceName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceModel(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.deviceModel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsAccelerometer(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsAccelerometer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsGyroscope(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsGyroscope);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsLocationService(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsLocationService);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsVibration(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsVibration);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsAudio(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsAudio);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.deviceType);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxTextureSize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxTextureSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxCubemapSize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxCubemapSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
