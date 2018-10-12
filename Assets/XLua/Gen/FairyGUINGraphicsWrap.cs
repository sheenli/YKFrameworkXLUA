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
    public class FairyGUINGraphicsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.NGraphics);
			Utils.BeginObjectRegister(type, L, translator, 0, 17, 23, 14);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetShaderAndTexture", _m_SetShaderAndTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetStencilEraserOrder", _m_SetStencilEraserOrder);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMaterial", _m_UpdateMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Alloc", _m_Alloc);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMesh", _m_UpdateMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawRect", _m_DrawRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawRoundRect", _m_DrawRoundRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawEllipse", _m_DrawEllipse);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawPolygon", _m_DrawPolygon);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawRectWithFillMethod", _m_DrawRectWithFillMethod);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FillVerts", _m_FillVerts);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FillUV", _m_FillUV);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FillColors", _m_FillColors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FillTriangles", _m_FillTriangles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearMesh", _m_ClearMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Tint", _m_Tint);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertices", _g_get_vertices);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uv", _g_get_uv);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colors", _g_get_colors);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "triangles", _g_get_triangles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertCount", _g_get_vertCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "meshFilter", _g_get_meshFilter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "meshRenderer", _g_get_meshRenderer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mesh", _g_get_mesh);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gameObject", _g_get_gameObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "texture", _g_get_texture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shader", _g_get_shader);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", _g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "materialKeywords", _g_get_materialKeywords);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enabled", _g_get_enabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingOrder", _g_get_sortingOrder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alpha", _g_get_alpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "grayed", _g_get_grayed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blendMode", _g_get_blendMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dontClip", _g_get_dontClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maskFrameId", _g_get_maskFrameId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertexMatrix", _g_get_vertexMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cameraPosition", _g_get_cameraPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "meshModifier", _g_get_meshModifier);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "texture", _s_set_texture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "shader", _s_set_shader);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", _s_set_material);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "materialKeywords", _s_set_materialKeywords);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enabled", _s_set_enabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingOrder", _s_set_sortingOrder);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alpha", _s_set_alpha);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "grayed", _s_set_grayed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blendMode", _s_set_blendMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dontClip", _s_set_dontClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maskFrameId", _s_set_maskFrameId);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "vertexMatrix", _s_set_vertexMatrix);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cameraPosition", _s_set_cameraPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "meshModifier", _s_set_meshModifier);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 3, 3);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "FillVertsOfQuad", _m_FillVertsOfQuad_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FillUVOfQuad", _m_FillUVOfQuad_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RotateUV", _m_RotateUV_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "TRIANGLES", _g_get_TRIANGLES);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "TRIANGLES_9_GRID", _g_get_TRIANGLES_9_GRID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "TRIANGLES_4_GRID", _g_get_TRIANGLES_4_GRID);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "TRIANGLES", _s_set_TRIANGLES);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "TRIANGLES_9_GRID", _s_set_TRIANGLES_9_GRID);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "TRIANGLES_4_GRID", _s_set_TRIANGLES_4_GRID);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.GameObject>(L, 2))
				{
					UnityEngine.GameObject gameObject = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
					
					FairyGUI.NGraphics __cl_gen_ret = new FairyGUI.NGraphics(gameObject);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.NGraphics constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetShaderAndTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string shader = LuaAPI.lua_tostring(L, 2);
                    FairyGUI.NTexture texture = (FairyGUI.NTexture)translator.GetObject(L, 3, typeof(FairyGUI.NTexture));
                    
                    __cl_gen_to_be_invoked.SetShaderAndTexture( shader, texture );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStencilEraserOrder(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int value = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.SetStencilEraserOrder( value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMaterial(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.UpdateContext context = (FairyGUI.UpdateContext)translator.GetObject(L, 2, typeof(FairyGUI.UpdateContext));
                    
                    __cl_gen_to_be_invoked.UpdateMaterial( context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Alloc(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int vertCount = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.Alloc( vertCount );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMesh(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.UpdateMesh(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawRect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& translator.Assignable<UnityEngine.Color>(L, 4)) 
                {
                    UnityEngine.Rect vertRect;translator.Get(L, 2, out vertRect);
                    UnityEngine.Rect uvRect;translator.Get(L, 3, out uvRect);
                    UnityEngine.Color color;translator.Get(L, 4, out color);
                    
                    __cl_gen_to_be_invoked.DrawRect( vertRect, uvRect, color );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Color>(L, 5)&& translator.Assignable<UnityEngine.Color>(L, 6)) 
                {
                    UnityEngine.Rect vertRect;translator.Get(L, 2, out vertRect);
                    UnityEngine.Rect uvRect;translator.Get(L, 3, out uvRect);
                    int lineSize = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Color lineColor;translator.Get(L, 5, out lineColor);
                    UnityEngine.Color fillColor;translator.Get(L, 6, out fillColor);
                    
                    __cl_gen_to_be_invoked.DrawRect( vertRect, uvRect, lineSize, lineColor, fillColor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.NGraphics.DrawRect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawRoundRect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Rect vertRect;translator.Get(L, 2, out vertRect);
                    UnityEngine.Rect uvRect;translator.Get(L, 3, out uvRect);
                    UnityEngine.Color fillColor;translator.Get(L, 4, out fillColor);
                    float topLeftRadius = (float)LuaAPI.lua_tonumber(L, 5);
                    float topRightRadius = (float)LuaAPI.lua_tonumber(L, 6);
                    float bottomLeftRadius = (float)LuaAPI.lua_tonumber(L, 7);
                    float bottomRightRadius = (float)LuaAPI.lua_tonumber(L, 8);
                    
                    __cl_gen_to_be_invoked.DrawRoundRect( vertRect, uvRect, fillColor, topLeftRadius, topRightRadius, bottomLeftRadius, bottomRightRadius );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawEllipse(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Rect vertRect;translator.Get(L, 2, out vertRect);
                    UnityEngine.Rect uvRect;translator.Get(L, 3, out uvRect);
                    UnityEngine.Color fillColor;translator.Get(L, 4, out fillColor);
                    
                    __cl_gen_to_be_invoked.DrawEllipse( vertRect, uvRect, fillColor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawPolygon(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Rect vertRect;translator.Get(L, 2, out vertRect);
                    UnityEngine.Rect uvRect;translator.Get(L, 3, out uvRect);
                    UnityEngine.Vector2[] points = (UnityEngine.Vector2[])translator.GetObject(L, 4, typeof(UnityEngine.Vector2[]));
                    UnityEngine.Color fillColor;translator.Get(L, 5, out fillColor);
                    
                    __cl_gen_to_be_invoked.DrawPolygon( vertRect, uvRect, points, fillColor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawRectWithFillMethod(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Rect vertRect;translator.Get(L, 2, out vertRect);
                    UnityEngine.Rect uvRect;translator.Get(L, 3, out uvRect);
                    UnityEngine.Color fillColor;translator.Get(L, 4, out fillColor);
                    FairyGUI.FillMethod method;translator.Get(L, 5, out method);
                    float amount = (float)LuaAPI.lua_tonumber(L, 6);
                    int origin = LuaAPI.xlua_tointeger(L, 7);
                    bool clockwise = LuaAPI.lua_toboolean(L, 8);
                    
                    __cl_gen_to_be_invoked.DrawRectWithFillMethod( vertRect, uvRect, fillColor, method, amount, origin, clockwise );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FillVerts(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rect rect;translator.Get(L, 3, out rect);
                    
                    __cl_gen_to_be_invoked.FillVerts( index, rect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FillUV(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rect rect;translator.Get(L, 3, out rect);
                    
                    __cl_gen_to_be_invoked.FillUV( index, rect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FillColors(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Color>(L, 2)) 
                {
                    UnityEngine.Color value;translator.Get(L, 2, out value);
                    
                    __cl_gen_to_be_invoked.FillColors( value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Color[]>(L, 2)) 
                {
                    UnityEngine.Color[] value = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    
                    __cl_gen_to_be_invoked.FillColors( value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.NGraphics.FillColors!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FillTriangles(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.FillTriangles(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<int[]>(L, 2)) 
                {
                    int[] triangles = (int[])translator.GetObject(L, 2, typeof(int[]));
                    
                    __cl_gen_to_be_invoked.FillTriangles( triangles );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.NGraphics.FillTriangles!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearMesh(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.ClearMesh(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Tint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Color value;translator.Get(L, 2, out value);
                    
                    __cl_gen_to_be_invoked.Tint( value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FillVertsOfQuad_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3[] verts = (UnityEngine.Vector3[])translator.GetObject(L, 1, typeof(UnityEngine.Vector3[]));
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rect rect;translator.Get(L, 3, out rect);
                    
                    FairyGUI.NGraphics.FillVertsOfQuad( verts, index, rect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FillUVOfQuad_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector2[] uv = (UnityEngine.Vector2[])translator.GetObject(L, 1, typeof(UnityEngine.Vector2[]));
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rect rect;translator.Get(L, 3, out rect);
                    
                    FairyGUI.NGraphics.FillUVOfQuad( uv, index, rect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RotateUV_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector2[] uv = (UnityEngine.Vector2[])translator.GetObject(L, 1, typeof(UnityEngine.Vector2[]));
                    UnityEngine.Rect baseUVRect;translator.Get(L, 2, out baseUVRect);
                    
                    FairyGUI.NGraphics.RotateUV( uv, ref baseUVRect );
                    translator.Push(L, baseUVRect);
                        translator.Update(L, 2, baseUVRect);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertices(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.vertices);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uv(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.uv);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colors(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.colors);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_triangles(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.triangles);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.vertCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_meshFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.meshFilter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_meshRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.meshRenderer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mesh(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mesh);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gameObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.gameObject);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_texture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.texture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shader(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.shader);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_material(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.material);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_materialKeywords(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.materialKeywords);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.enabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortingOrder(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.sortingOrder);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alpha(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.alpha);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_grayed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.grayed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blendMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.blendMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dontClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.dontClip);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maskFrameId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, __cl_gen_to_be_invoked.maskFrameId);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertexMatrix(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.vertexMatrix);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cameraPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cameraPosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_meshModifier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.meshModifier);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TRIANGLES(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, FairyGUI.NGraphics.TRIANGLES);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TRIANGLES_9_GRID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, FairyGUI.NGraphics.TRIANGLES_9_GRID);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TRIANGLES_4_GRID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, FairyGUI.NGraphics.TRIANGLES_4_GRID);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_texture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.texture = (FairyGUI.NTexture)translator.GetObject(L, 2, typeof(FairyGUI.NTexture));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_shader(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.shader = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_material(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_materialKeywords(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.materialKeywords = (string[])translator.GetObject(L, 2, typeof(string[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.enabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sortingOrder(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sortingOrder = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alpha(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.alpha = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_grayed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.grayed = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_blendMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                FairyGUI.BlendMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.blendMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dontClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.dontClip = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maskFrameId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maskFrameId = LuaAPI.xlua_touint(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_vertexMatrix(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                System.Nullable<UnityEngine.Matrix4x4> __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.vertexMatrix = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cameraPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                System.Nullable<UnityEngine.Vector3> __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.cameraPosition = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_meshModifier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NGraphics __cl_gen_to_be_invoked = (FairyGUI.NGraphics)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.meshModifier = translator.GetDelegate<FairyGUI.NGraphics.MeshModifier>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TRIANGLES(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    FairyGUI.NGraphics.TRIANGLES = (int[])translator.GetObject(L, 1, typeof(int[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TRIANGLES_9_GRID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    FairyGUI.NGraphics.TRIANGLES_9_GRID = (int[])translator.GetObject(L, 1, typeof(int[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TRIANGLES_4_GRID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    FairyGUI.NGraphics.TRIANGLES_4_GRID = (int[])translator.GetObject(L, 1, typeof(int[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
