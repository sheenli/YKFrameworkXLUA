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
    public class FairyGUIDynamicFontWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.DynamicFont);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFormat", _m_SetFormat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PrepareCharacters", _m_PrepareCharacters);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGlyphSize", _m_GetGlyphSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGlyph", _m_GetGlyph);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string name = LuaAPI.lua_tostring(L, 2);
					
					FairyGUI.DynamicFont __cl_gen_ret = new FairyGUI.DynamicFont(name);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.DynamicFont constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFormat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DynamicFont __cl_gen_to_be_invoked = (FairyGUI.DynamicFont)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.TextFormat format = (FairyGUI.TextFormat)translator.GetObject(L, 2, typeof(FairyGUI.TextFormat));
                    float fontSizeScale = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetFormat( format, fontSizeScale );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PrepareCharacters(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DynamicFont __cl_gen_to_be_invoked = (FairyGUI.DynamicFont)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.PrepareCharacters( text );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlyphSize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DynamicFont __cl_gen_to_be_invoked = (FairyGUI.DynamicFont)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    char ch = (char)LuaAPI.xlua_tointeger(L, 2);
                    float width;
                    float height;
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.GetGlyphSize( ch, out width, out height );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.lua_pushnumber(L, width);
                        
                    LuaAPI.lua_pushnumber(L, height);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlyph(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DynamicFont __cl_gen_to_be_invoked = (FairyGUI.DynamicFont)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    char ch = (char)LuaAPI.xlua_tointeger(L, 2);
                    FairyGUI.GlyphInfo glyph = (FairyGUI.GlyphInfo)translator.GetObject(L, 3, typeof(FairyGUI.GlyphInfo));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.GetGlyph( ch, glyph );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
