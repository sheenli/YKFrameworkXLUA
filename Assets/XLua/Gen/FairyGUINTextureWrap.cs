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
    public class FairyGUINTextureWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.NTexture);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 12, 10);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestroyMaterials", _m_DestroyMaterials);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "width", _g_get_width);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "height", _g_get_height);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "nativeTexture", _g_get_nativeTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alphaTexture", _g_get_alphaTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "root", _g_get_root);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uvRect", _g_get_uvRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotated", _g_get_rotated);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "materialManagers", _g_get_materialManagers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "refCount", _g_get_refCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "disposed", _g_get_disposed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastActive", _g_get_lastActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "storedODisk", _g_get_storedODisk);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "nativeTexture", _s_set_nativeTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alphaTexture", _s_set_alphaTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "root", _s_set_root);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uvRect", _s_set_uvRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotated", _s_set_rotated);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "materialManagers", _s_set_materialManagers);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "refCount", _s_set_refCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "disposed", _s_set_disposed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lastActive", _s_set_lastActive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "storedODisk", _s_set_storedODisk);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "DisposeEmpty", _m_DisposeEmpty_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Empty", _g_get_Empty);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.Texture>(L, 2))
				{
					UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
					
					FairyGUI.NTexture __cl_gen_ret = new FairyGUI.NTexture(texture);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Texture>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
					float xScale = (float)LuaAPI.lua_tonumber(L, 3);
					float yScale = (float)LuaAPI.lua_tonumber(L, 4);
					
					FairyGUI.NTexture __cl_gen_ret = new FairyGUI.NTexture(texture, xScale, yScale);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Texture>(L, 2) && translator.Assignable<UnityEngine.Rect>(L, 3))
				{
					UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
					UnityEngine.Rect region;translator.Get(L, 3, out region);
					
					FairyGUI.NTexture __cl_gen_ret = new FairyGUI.NTexture(texture, region);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<FairyGUI.NTexture>(L, 2) && translator.Assignable<UnityEngine.Rect>(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4))
				{
					FairyGUI.NTexture root = (FairyGUI.NTexture)translator.GetObject(L, 2, typeof(FairyGUI.NTexture));
					UnityEngine.Rect region;translator.Get(L, 3, out region);
					bool rotated = LuaAPI.lua_toboolean(L, 4);
					
					FairyGUI.NTexture __cl_gen_ret = new FairyGUI.NTexture(root, region, rotated);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.NTexture constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisposeEmpty_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    FairyGUI.NTexture.DisposeEmpty(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyMaterials(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.DestroyMaterials(  );
                    
                    
                    
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
            
            
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool allowDestroyingAssets = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Dispose( allowDestroyingAssets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.NTexture.Dispose!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Empty(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, FairyGUI.NTexture.Empty);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_width(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
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
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.height);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_nativeTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.nativeTexture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alphaTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.alphaTexture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_root(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.root);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uvRect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.uvRect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.rotated);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_materialManagers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.materialManagers);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_refCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.refCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_disposed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.disposed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.lastActive);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_storedODisk(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.storedODisk);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_nativeTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.nativeTexture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alphaTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.alphaTexture = (FairyGUI.NTexture)translator.GetObject(L, 2, typeof(FairyGUI.NTexture));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_root(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.root = (FairyGUI.NTexture)translator.GetObject(L, 2, typeof(FairyGUI.NTexture));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uvRect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                UnityEngine.Rect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.uvRect = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.rotated = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_materialManagers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.materialManagers = (System.Collections.Generic.Dictionary<string, FairyGUI.MaterialManager>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, FairyGUI.MaterialManager>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_refCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.refCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_disposed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.disposed = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lastActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.lastActive = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_storedODisk(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.NTexture __cl_gen_to_be_invoked = (FairyGUI.NTexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.storedODisk = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
