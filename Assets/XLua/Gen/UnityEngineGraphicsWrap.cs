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
    public class UnityEngineGraphicsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Graphics);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 16, 3, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawMesh", _m_DrawMesh_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawProcedural", _m_DrawProcedural_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawProceduralIndirect", _m_DrawProceduralIndirect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawMeshInstanced", _m_DrawMeshInstanced_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawMeshInstancedIndirect", _m_DrawMeshInstancedIndirect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawTexture", _m_DrawTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExecuteCommandBuffer", _m_ExecuteCommandBuffer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Blit", _m_Blit_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BlitMultiTap", _m_BlitMultiTap_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetRandomWriteTarget", _m_SetRandomWriteTarget_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearRandomWriteTargets", _m_ClearRandomWriteTargets_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetRenderTarget", _m_SetRenderTarget_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CopyTexture", _m_CopyTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ConvertTexture", _m_ConvertTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawMeshNow", _m_DrawMeshNow_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "activeColorBuffer", _g_get_activeColorBuffer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "activeDepthBuffer", _g_get_activeDepthBuffer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "activeTier", _g_get_activeTier);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "activeTier", _s_set_activeTier);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Graphics __cl_gen_ret = new UnityEngine.Graphics();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMesh_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer, camera );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer, camera, submeshIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer, camera );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer, camera, submeshIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer, camera, submeshIndex, properties );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    bool castShadows = LuaAPI.lua_toboolean(L, 8);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    bool castShadows = LuaAPI.lua_toboolean(L, 8);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    bool castShadows = LuaAPI.lua_toboolean(L, 8);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    bool useLightProbes = LuaAPI.lua_toboolean(L, 10);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer, camera, submeshIndex, properties );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 8, out castShadows);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    bool castShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 8, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    bool castShadows = LuaAPI.lua_toboolean(L, 9);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 11)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    bool castShadows = LuaAPI.lua_toboolean(L, 9);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    bool useLightProbes = LuaAPI.lua_toboolean(L, 11);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 9, out castShadows);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 9, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Transform>(L, 10)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 8, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    UnityEngine.Transform probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 10, typeof(UnityEngine.Transform));
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Transform>(L, 10)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 11)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 8, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    UnityEngine.Transform probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 10, typeof(UnityEngine.Transform));
                    bool useLightProbes = LuaAPI.lua_toboolean(L, 11);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Transform>(L, 11)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 9, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    UnityEngine.Transform probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 11, typeof(UnityEngine.Transform));
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 12&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Transform>(L, 11)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 12)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 9, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    UnityEngine.Transform probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 11, typeof(UnityEngine.Transform));
                    bool useLightProbes = LuaAPI.lua_toboolean(L, 12);
                    
                    UnityEngine.Graphics.DrawMesh( mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawMesh!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawProcedural_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.MeshTopology topology;translator.Get(L, 1, out topology);
                    int vertexCount = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Graphics.DrawProcedural( topology, vertexCount );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.MeshTopology topology;translator.Get(L, 1, out topology);
                    int vertexCount = LuaAPI.xlua_tointeger(L, 2);
                    int instanceCount = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.DrawProcedural( topology, vertexCount, instanceCount );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawProcedural!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawProceduralIndirect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)) 
                {
                    UnityEngine.MeshTopology topology;translator.Get(L, 1, out topology);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( topology, bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.MeshTopology topology;translator.Get(L, 1, out topology);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( topology, bufferWithArgs, argsOffset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawProceduralIndirect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMeshInstanced_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int count = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, count );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, properties );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, count, properties );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 6)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 6, out castShadows);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, properties, castShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 7, out castShadows);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, count, properties, castShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 6, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 7);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 7, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 6, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 7);
                    int layer = LuaAPI.xlua_tointeger(L, 8);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 7, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    int layer = LuaAPI.xlua_tointeger(L, 9);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<UnityEngine.Camera>(L, 9)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 6, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 7);
                    int layer = LuaAPI.xlua_tointeger(L, 8);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 9, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Camera>(L, 10)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 7, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    int layer = LuaAPI.xlua_tointeger(L, 9);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 10, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawMeshInstanced!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMeshInstancedIndirect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds bounds;translator.Get(L, 4, out bounds);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( mesh, submeshIndex, material, bounds, bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds bounds;translator.Get(L, 4, out bounds);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds bounds;translator.Get(L, 4, out bounds);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds bounds;translator.Get(L, 4, out bounds);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 8, out castShadows);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds bounds;translator.Get(L, 4, out bounds);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 8, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds bounds;translator.Get(L, 4, out bounds);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 8, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int layer = LuaAPI.xlua_tointeger(L, 10);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Camera>(L, 11)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds bounds;translator.Get(L, 4, out bounds);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode castShadows;translator.Get(L, 8, out castShadows);
                    bool receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int layer = LuaAPI.xlua_tointeger(L, 10);
                    UnityEngine.Camera camera = (UnityEngine.Camera)translator.GetObject(L, 11, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawMeshInstancedIndirect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    int leftBorder = LuaAPI.xlua_tointeger(L, 3);
                    int rightBorder = LuaAPI.xlua_tointeger(L, 4);
                    int topBorder = LuaAPI.xlua_tointeger(L, 5);
                    int bottomBorder = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, mat );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int pass = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, mat, pass );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Material>(L, 7)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    int leftBorder = LuaAPI.xlua_tointeger(L, 3);
                    int rightBorder = LuaAPI.xlua_tointeger(L, 4);
                    int topBorder = LuaAPI.xlua_tointeger(L, 5);
                    int bottomBorder = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 7, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect sourceRect;translator.Get(L, 3, out sourceRect);
                    int leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Material>(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    int leftBorder = LuaAPI.xlua_tointeger(L, 3);
                    int rightBorder = LuaAPI.xlua_tointeger(L, 4);
                    int topBorder = LuaAPI.xlua_tointeger(L, 5);
                    int bottomBorder = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 7, typeof(UnityEngine.Material));
                    int pass = LuaAPI.xlua_tointeger(L, 8);
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Material>(L, 8)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect sourceRect;translator.Get(L, 3, out sourceRect);
                    int leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 8, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Color>(L, 8)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect sourceRect;translator.Get(L, 3, out sourceRect);
                    int leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Color color;translator.Get(L, 8, out color);
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Material>(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect sourceRect;translator.Get(L, 3, out sourceRect);
                    int leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 8, typeof(UnityEngine.Material));
                    int pass = LuaAPI.xlua_tointeger(L, 9);
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Color>(L, 8)&& translator.Assignable<UnityEngine.Material>(L, 9)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect sourceRect;translator.Get(L, 3, out sourceRect);
                    int leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Color color;translator.Get(L, 8, out color);
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 9, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 10&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Color>(L, 8)&& translator.Assignable<UnityEngine.Material>(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect sourceRect;translator.Get(L, 3, out sourceRect);
                    int leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Color color;translator.Get(L, 8, out color);
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 9, typeof(UnityEngine.Material));
                    int pass = LuaAPI.xlua_tointeger(L, 10);
                    
                    UnityEngine.Graphics.DrawTexture( screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExecuteCommandBuffer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Rendering.CommandBuffer buffer = (UnityEngine.Rendering.CommandBuffer)translator.GetObject(L, 1, typeof(UnityEngine.Rendering.CommandBuffer));
                    
                    UnityEngine.Graphics.ExecuteCommandBuffer( buffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Blit_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)) 
                {
                    UnityEngine.Texture source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    
                    UnityEngine.Graphics.Blit( source, dest );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.Material>(L, 2)) 
                {
                    UnityEngine.Texture source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.Blit( source, mat );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.Material>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Texture source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    int pass = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.Blit( source, mat, pass );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)) 
                {
                    UnityEngine.Texture source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.Blit( source, dest, mat );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Texture source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int pass = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.Blit( source, dest, mat, pass );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.Blit!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BlitMultiTap_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Texture source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Vector2[] offsets = translator.GetParams<UnityEngine.Vector2>(L, 4);
                    
                    UnityEngine.Graphics.BlitMultiTap( source, dest, mat, offsets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRandomWriteTarget_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.RenderTexture uav = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    
                    UnityEngine.Graphics.SetRandomWriteTarget( index, uav );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.ComputeBuffer uav = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Graphics.SetRandomWriteTarget( index, uav );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.ComputeBuffer uav = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    bool preserveCounterValue = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Graphics.SetRandomWriteTarget( index, uav, preserveCounterValue );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.SetRandomWriteTarget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearRandomWriteTargets_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.Graphics.ClearRandomWriteTargets(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRenderTarget_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.RenderTexture>(L, 1)) 
                {
                    UnityEngine.RenderTexture rt = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    
                    UnityEngine.Graphics.SetRenderTarget( rt );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.RenderTargetSetup>(L, 1)) 
                {
                    UnityEngine.RenderTargetSetup setup;translator.Get(L, 1, out setup);
                    
                    UnityEngine.Graphics.SetRenderTarget( setup );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.RenderTexture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.RenderTexture rt = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    int mipLevel = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Graphics.SetRenderTarget( rt, mipLevel );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.RenderBuffer>(L, 1)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)) 
                {
                    UnityEngine.RenderBuffer colorBuffer;translator.Get(L, 1, out colorBuffer);
                    UnityEngine.RenderBuffer depthBuffer;translator.Get(L, 2, out depthBuffer);
                    
                    UnityEngine.Graphics.SetRenderTarget( colorBuffer, depthBuffer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.RenderBuffer[]>(L, 1)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)) 
                {
                    UnityEngine.RenderBuffer[] colorBuffers = (UnityEngine.RenderBuffer[])translator.GetObject(L, 1, typeof(UnityEngine.RenderBuffer[]));
                    UnityEngine.RenderBuffer depthBuffer;translator.Get(L, 2, out depthBuffer);
                    
                    UnityEngine.Graphics.SetRenderTarget( colorBuffers, depthBuffer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.RenderTexture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.CubemapFace>(L, 3)) 
                {
                    UnityEngine.RenderTexture rt = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    int mipLevel = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.CubemapFace face;translator.Get(L, 3, out face);
                    
                    UnityEngine.Graphics.SetRenderTarget( rt, mipLevel, face );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.RenderBuffer>(L, 1)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.RenderBuffer colorBuffer;translator.Get(L, 1, out colorBuffer);
                    UnityEngine.RenderBuffer depthBuffer;translator.Get(L, 2, out depthBuffer);
                    int mipLevel = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.SetRenderTarget( colorBuffer, depthBuffer, mipLevel );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.RenderTexture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.CubemapFace>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.RenderTexture rt = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    int mipLevel = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.CubemapFace face;translator.Get(L, 3, out face);
                    int depthSlice = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.SetRenderTarget( rt, mipLevel, face, depthSlice );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.RenderBuffer>(L, 1)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.CubemapFace>(L, 4)) 
                {
                    UnityEngine.RenderBuffer colorBuffer;translator.Get(L, 1, out colorBuffer);
                    UnityEngine.RenderBuffer depthBuffer;translator.Get(L, 2, out depthBuffer);
                    int mipLevel = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.CubemapFace face;translator.Get(L, 4, out face);
                    
                    UnityEngine.Graphics.SetRenderTarget( colorBuffer, depthBuffer, mipLevel, face );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.RenderBuffer>(L, 1)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.CubemapFace>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.RenderBuffer colorBuffer;translator.Get(L, 1, out colorBuffer);
                    UnityEngine.RenderBuffer depthBuffer;translator.Get(L, 2, out depthBuffer);
                    int mipLevel = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.CubemapFace face;translator.Get(L, 4, out face);
                    int depthSlice = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.SetRenderTarget( colorBuffer, depthBuffer, mipLevel, face, depthSlice );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.SetRenderTarget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Texture src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.Texture dst = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Graphics.CopyTexture( src, dst );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Texture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Texture src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    int srcElement = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Texture dst = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    int dstElement = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.CopyTexture( src, srcElement, dst, dstElement );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Texture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Texture src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    int srcElement = LuaAPI.xlua_tointeger(L, 2);
                    int srcMip = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Texture dst = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    int dstElement = LuaAPI.xlua_tointeger(L, 5);
                    int dstMip = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.CopyTexture( src, srcElement, srcMip, dst, dstElement, dstMip );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 12&& translator.Assignable<UnityEngine.Texture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Texture>(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 12)) 
                {
                    UnityEngine.Texture src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    int srcElement = LuaAPI.xlua_tointeger(L, 2);
                    int srcMip = LuaAPI.xlua_tointeger(L, 3);
                    int srcX = LuaAPI.xlua_tointeger(L, 4);
                    int srcY = LuaAPI.xlua_tointeger(L, 5);
                    int srcWidth = LuaAPI.xlua_tointeger(L, 6);
                    int srcHeight = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Texture dst = (UnityEngine.Texture)translator.GetObject(L, 8, typeof(UnityEngine.Texture));
                    int dstElement = LuaAPI.xlua_tointeger(L, 9);
                    int dstMip = LuaAPI.xlua_tointeger(L, 10);
                    int dstX = LuaAPI.xlua_tointeger(L, 11);
                    int dstY = LuaAPI.xlua_tointeger(L, 12);
                    
                    UnityEngine.Graphics.CopyTexture( src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.CopyTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConvertTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Texture src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.Texture dst = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                        bool __cl_gen_ret = UnityEngine.Graphics.ConvertTexture( src, dst );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Texture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Texture src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    int srcElement = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Texture dst = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    int dstElement = LuaAPI.xlua_tointeger(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.Graphics.ConvertTexture( src, srcElement, dst, dstElement );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.ConvertTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMeshNow_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    
                    UnityEngine.Graphics.DrawMeshNow( mesh, matrix );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    int materialIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.DrawMeshNow( mesh, matrix, materialIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    
                    UnityEngine.Graphics.DrawMeshNow( mesh, position, rotation );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    int materialIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.DrawMeshNow( mesh, position, rotation, materialIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawMeshNow!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeColorBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Graphics.activeColorBuffer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeDepthBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Graphics.activeDepthBuffer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeTier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Graphics.activeTier);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_activeTier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Rendering.GraphicsTier __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.Graphics.activeTier = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
