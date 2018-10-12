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
    public class UnityEngineGLWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GL);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 32, 4, 4);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Vertex3", _m_Vertex3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Vertex", _m_Vertex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Color", _m_Color_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TexCoord", _m_TexCoord_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TexCoord2", _m_TexCoord2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TexCoord3", _m_TexCoord3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MultiTexCoord2", _m_MultiTexCoord2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MultiTexCoord3", _m_MultiTexCoord3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MultiTexCoord", _m_MultiTexCoord_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Begin", _m_Begin_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "End", _m_End_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PushMatrix", _m_PushMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PopMatrix", _m_PopMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadIdentity", _m_LoadIdentity_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadOrtho", _m_LoadOrtho_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadPixelMatrix", _m_LoadPixelMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Viewport", _m_Viewport_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadProjectionMatrix", _m_LoadProjectionMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MultMatrix", _m_MultMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGPUProjectionMatrix", _m_GetGPUProjectionMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Clear", _m_Clear_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearWithSkybox", _m_ClearWithSkybox_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Flush", _m_Flush_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "InvalidateState", _m_InvalidateState_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IssuePluginEvent", _m_IssuePluginEvent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RenderTargetBarrier", _m_RenderTargetBarrier_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TRIANGLES", UnityEngine.GL.TRIANGLES);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TRIANGLE_STRIP", UnityEngine.GL.TRIANGLE_STRIP);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QUADS", UnityEngine.GL.QUADS);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LINES", UnityEngine.GL.LINES);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LINE_STRIP", UnityEngine.GL.LINE_STRIP);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "modelview", _g_get_modelview);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "wireframe", _g_get_wireframe);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sRGBWrite", _g_get_sRGBWrite);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "invertCulling", _g_get_invertCulling);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "modelview", _s_set_modelview);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "wireframe", _s_set_wireframe);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "sRGBWrite", _s_set_sRGBWrite);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "invertCulling", _s_set_invertCulling);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.GL __cl_gen_ret = new UnityEngine.GL();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GL constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Vertex3_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 1);
                    float y = (float)LuaAPI.lua_tonumber(L, 2);
                    float z = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.GL.Vertex3( x, y, z );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Vertex_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 v;translator.Get(L, 1, out v);
                    
                    UnityEngine.GL.Vertex( v );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Color_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Color c;translator.Get(L, 1, out c);
                    
                    UnityEngine.GL.Color( c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TexCoord_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 v;translator.Get(L, 1, out v);
                    
                    UnityEngine.GL.TexCoord( v );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TexCoord2_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 1);
                    float y = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.GL.TexCoord2( x, y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TexCoord3_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 1);
                    float y = (float)LuaAPI.lua_tonumber(L, 2);
                    float z = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.GL.TexCoord3( x, y, z );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MultiTexCoord2_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int unit = LuaAPI.xlua_tointeger(L, 1);
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.GL.MultiTexCoord2( unit, x, y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MultiTexCoord3_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int unit = LuaAPI.xlua_tointeger(L, 1);
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    UnityEngine.GL.MultiTexCoord3( unit, x, y, z );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MultiTexCoord_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int unit = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Vector3 v;translator.Get(L, 2, out v);
                    
                    UnityEngine.GL.MultiTexCoord( unit, v );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Begin_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int mode = LuaAPI.xlua_tointeger(L, 1);
                    
                    UnityEngine.GL.Begin( mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_End_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.End(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.PushMatrix(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PopMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.PopMatrix(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadIdentity_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.LoadIdentity(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadOrtho_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.LoadOrtho(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadPixelMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 0) 
                {
                    
                    UnityEngine.GL.LoadPixelMatrix(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float left = (float)LuaAPI.lua_tonumber(L, 1);
                    float right = (float)LuaAPI.lua_tonumber(L, 2);
                    float bottom = (float)LuaAPI.lua_tonumber(L, 3);
                    float top = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    UnityEngine.GL.LoadPixelMatrix( left, right, bottom, top );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GL.LoadPixelMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Viewport_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Rect pixelRect;translator.Get(L, 1, out pixelRect);
                    
                    UnityEngine.GL.Viewport( pixelRect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadProjectionMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Matrix4x4 mat;translator.Get(L, 1, out mat);
                    
                    UnityEngine.GL.LoadProjectionMatrix( mat );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MultMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Matrix4x4 mat;translator.Get(L, 1, out mat);
                    
                    UnityEngine.GL.MultMatrix( mat );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGPUProjectionMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Matrix4x4 proj;translator.Get(L, 1, out proj);
                    bool renderIntoTexture = LuaAPI.lua_toboolean(L, 2);
                    
                        UnityEngine.Matrix4x4 __cl_gen_ret = UnityEngine.GL.GetGPUProjectionMatrix( proj, renderIntoTexture );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    bool clearDepth = LuaAPI.lua_toboolean(L, 1);
                    bool clearColor = LuaAPI.lua_toboolean(L, 2);
                    UnityEngine.Color backgroundColor;translator.Get(L, 3, out backgroundColor);
                    
                    UnityEngine.GL.Clear( clearDepth, clearColor, backgroundColor );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    bool clearDepth = LuaAPI.lua_toboolean(L, 1);
                    bool clearColor = LuaAPI.lua_toboolean(L, 2);
                    UnityEngine.Color backgroundColor;translator.Get(L, 3, out backgroundColor);
                    float depth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    UnityEngine.GL.Clear( clearDepth, clearColor, backgroundColor, depth );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GL.Clear!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearWithSkybox_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    bool clearDepth = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
                    
                    UnityEngine.GL.ClearWithSkybox( clearDepth, camera );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Flush_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.Flush(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InvalidateState_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.InvalidateState(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IssuePluginEvent_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr callback = LuaAPI.lua_touserdata(L, 1);
                    int eventID = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.GL.IssuePluginEvent( callback, eventID );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RenderTargetBarrier_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.RenderTargetBarrier(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_modelview(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.GL.modelview);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wireframe(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.GL.wireframe);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sRGBWrite(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.GL.sRGBWrite);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_invertCulling(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.GL.invertCulling);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_modelview(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Matrix4x4 __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.GL.modelview = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wireframe(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.GL.wireframe = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sRGBWrite(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.GL.sRGBWrite = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_invertCulling(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.GL.invertCulling = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
