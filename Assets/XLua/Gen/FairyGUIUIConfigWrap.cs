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
    public class FairyGUIUIConfigWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.UIConfig);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Load", _m_Load);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyModifiedProperties", _m_ApplyModifiedProperties);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Items", _g_get_Items);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PreloadPackages", _g_get_PreloadPackages);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Items", _s_set_Items);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "PreloadPackages", _s_set_PreloadPackages);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 29, 29);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearResourceRefs", _m_ClearResourceRefs_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultFont", _g_get_defaultFont);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "renderingTextBrighterOnDesktop", _g_get_renderingTextBrighterOnDesktop);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "windowModalWaiting", _g_get_windowModalWaiting);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "globalModalWaiting", _g_get_globalModalWaiting);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "modalLayerColor", _g_get_modalLayerColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "buttonSound", _g_get_buttonSound);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "buttonSoundVolumeScale", _g_get_buttonSoundVolumeScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "horizontalScrollBar", _g_get_horizontalScrollBar);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "verticalScrollBar", _g_get_verticalScrollBar);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultScrollStep", _g_get_defaultScrollStep);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultScrollDecelerationRate", _g_get_defaultScrollDecelerationRate);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultScrollBarDisplay", _g_get_defaultScrollBarDisplay);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultScrollTouchEffect", _g_get_defaultScrollTouchEffect);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultScrollBounceEffect", _g_get_defaultScrollBounceEffect);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "popupMenu", _g_get_popupMenu);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "popupMenu_seperator", _g_get_popupMenu_seperator);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "loaderErrorSign", _g_get_loaderErrorSign);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "tooltipsWin", _g_get_tooltipsWin);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultComboBoxVisibleItemCount", _g_get_defaultComboBoxVisibleItemCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "touchScrollSensitivity", _g_get_touchScrollSensitivity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "touchDragSensitivity", _g_get_touchDragSensitivity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "clickDragSensitivity", _g_get_clickDragSensitivity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "allowSoftnessOnTopOrLeftSide", _g_get_allowSoftnessOnTopOrLeftSide);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "bringWindowToFrontOnClick", _g_get_bringWindowToFrontOnClick);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "inputCaretSize", _g_get_inputCaretSize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "inputHighlightColor", _g_get_inputHighlightColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "frameTimeForAsyncUIConstruction", _g_get_frameTimeForAsyncUIConstruction);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "depthSupportForPaintingMode", _g_get_depthSupportForPaintingMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "soundLoader", _g_get_soundLoader);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultFont", _s_set_defaultFont);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "renderingTextBrighterOnDesktop", _s_set_renderingTextBrighterOnDesktop);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "windowModalWaiting", _s_set_windowModalWaiting);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "globalModalWaiting", _s_set_globalModalWaiting);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "modalLayerColor", _s_set_modalLayerColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "buttonSound", _s_set_buttonSound);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "buttonSoundVolumeScale", _s_set_buttonSoundVolumeScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "horizontalScrollBar", _s_set_horizontalScrollBar);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "verticalScrollBar", _s_set_verticalScrollBar);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultScrollStep", _s_set_defaultScrollStep);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultScrollDecelerationRate", _s_set_defaultScrollDecelerationRate);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultScrollBarDisplay", _s_set_defaultScrollBarDisplay);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultScrollTouchEffect", _s_set_defaultScrollTouchEffect);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultScrollBounceEffect", _s_set_defaultScrollBounceEffect);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "popupMenu", _s_set_popupMenu);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "popupMenu_seperator", _s_set_popupMenu_seperator);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "loaderErrorSign", _s_set_loaderErrorSign);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "tooltipsWin", _s_set_tooltipsWin);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultComboBoxVisibleItemCount", _s_set_defaultComboBoxVisibleItemCount);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "touchScrollSensitivity", _s_set_touchScrollSensitivity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "touchDragSensitivity", _s_set_touchDragSensitivity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "clickDragSensitivity", _s_set_clickDragSensitivity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "allowSoftnessOnTopOrLeftSide", _s_set_allowSoftnessOnTopOrLeftSide);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "bringWindowToFrontOnClick", _s_set_bringWindowToFrontOnClick);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "inputCaretSize", _s_set_inputCaretSize);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "inputHighlightColor", _s_set_inputHighlightColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "frameTimeForAsyncUIConstruction", _s_set_frameTimeForAsyncUIConstruction);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "depthSupportForPaintingMode", _s_set_depthSupportForPaintingMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "soundLoader", _s_set_soundLoader);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					FairyGUI.UIConfig __cl_gen_ret = new FairyGUI.UIConfig();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.UIConfig constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Load(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.UIConfig __cl_gen_to_be_invoked = (FairyGUI.UIConfig)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Load(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearResourceRefs_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    FairyGUI.UIConfig.ClearResourceRefs(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyModifiedProperties(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.UIConfig __cl_gen_to_be_invoked = (FairyGUI.UIConfig)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.ApplyModifiedProperties(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultFont(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, FairyGUI.UIConfig.defaultFont);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderingTextBrighterOnDesktop(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, FairyGUI.UIConfig.renderingTextBrighterOnDesktop);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_windowModalWaiting(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, FairyGUI.UIConfig.windowModalWaiting);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_globalModalWaiting(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, FairyGUI.UIConfig.globalModalWaiting);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_modalLayerColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, FairyGUI.UIConfig.modalLayerColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_buttonSound(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, FairyGUI.UIConfig.buttonSound);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_buttonSoundVolumeScale(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, FairyGUI.UIConfig.buttonSoundVolumeScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_horizontalScrollBar(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, FairyGUI.UIConfig.horizontalScrollBar);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalScrollBar(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, FairyGUI.UIConfig.verticalScrollBar);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultScrollStep(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, FairyGUI.UIConfig.defaultScrollStep);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultScrollDecelerationRate(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, FairyGUI.UIConfig.defaultScrollDecelerationRate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultScrollBarDisplay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, FairyGUI.UIConfig.defaultScrollBarDisplay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultScrollTouchEffect(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, FairyGUI.UIConfig.defaultScrollTouchEffect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultScrollBounceEffect(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, FairyGUI.UIConfig.defaultScrollBounceEffect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_popupMenu(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, FairyGUI.UIConfig.popupMenu);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_popupMenu_seperator(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, FairyGUI.UIConfig.popupMenu_seperator);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loaderErrorSign(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, FairyGUI.UIConfig.loaderErrorSign);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tooltipsWin(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, FairyGUI.UIConfig.tooltipsWin);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultComboBoxVisibleItemCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, FairyGUI.UIConfig.defaultComboBoxVisibleItemCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_touchScrollSensitivity(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, FairyGUI.UIConfig.touchScrollSensitivity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_touchDragSensitivity(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, FairyGUI.UIConfig.touchDragSensitivity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clickDragSensitivity(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, FairyGUI.UIConfig.clickDragSensitivity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowSoftnessOnTopOrLeftSide(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, FairyGUI.UIConfig.allowSoftnessOnTopOrLeftSide);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bringWindowToFrontOnClick(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, FairyGUI.UIConfig.bringWindowToFrontOnClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputCaretSize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, FairyGUI.UIConfig.inputCaretSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputHighlightColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, FairyGUI.UIConfig.inputHighlightColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_frameTimeForAsyncUIConstruction(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, FairyGUI.UIConfig.frameTimeForAsyncUIConstruction);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depthSupportForPaintingMode(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, FairyGUI.UIConfig.depthSupportForPaintingMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.UIConfig __cl_gen_to_be_invoked = (FairyGUI.UIConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.Items);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PreloadPackages(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.UIConfig __cl_gen_to_be_invoked = (FairyGUI.UIConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.PreloadPackages);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_soundLoader(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, FairyGUI.UIConfig.soundLoader);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultFont(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.defaultFont = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_renderingTextBrighterOnDesktop(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.renderingTextBrighterOnDesktop = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_windowModalWaiting(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.windowModalWaiting = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_globalModalWaiting(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.globalModalWaiting = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_modalLayerColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				FairyGUI.UIConfig.modalLayerColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_buttonSound(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    FairyGUI.UIConfig.buttonSound = (UnityEngine.AudioClip)translator.GetObject(L, 1, typeof(UnityEngine.AudioClip));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_buttonSoundVolumeScale(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.buttonSoundVolumeScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_horizontalScrollBar(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.horizontalScrollBar = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalScrollBar(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.verticalScrollBar = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultScrollStep(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.defaultScrollStep = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultScrollDecelerationRate(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.defaultScrollDecelerationRate = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultScrollBarDisplay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			FairyGUI.ScrollBarDisplayType __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				FairyGUI.UIConfig.defaultScrollBarDisplay = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultScrollTouchEffect(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.defaultScrollTouchEffect = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultScrollBounceEffect(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.defaultScrollBounceEffect = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_popupMenu(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.popupMenu = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_popupMenu_seperator(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.popupMenu_seperator = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_loaderErrorSign(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.loaderErrorSign = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tooltipsWin(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.tooltipsWin = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultComboBoxVisibleItemCount(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.defaultComboBoxVisibleItemCount = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_touchScrollSensitivity(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.touchScrollSensitivity = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_touchDragSensitivity(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.touchDragSensitivity = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clickDragSensitivity(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.clickDragSensitivity = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowSoftnessOnTopOrLeftSide(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.allowSoftnessOnTopOrLeftSide = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bringWindowToFrontOnClick(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.bringWindowToFrontOnClick = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputCaretSize(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.inputCaretSize = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputHighlightColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				FairyGUI.UIConfig.inputHighlightColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_frameTimeForAsyncUIConstruction(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.frameTimeForAsyncUIConstruction = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depthSupportForPaintingMode(RealStatePtr L)
        {
		    try {
                
			    FairyGUI.UIConfig.depthSupportForPaintingMode = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.UIConfig __cl_gen_to_be_invoked = (FairyGUI.UIConfig)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.Items = (System.Collections.Generic.List<FairyGUI.UIConfig.ConfigValue>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<FairyGUI.UIConfig.ConfigValue>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_PreloadPackages(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.UIConfig __cl_gen_to_be_invoked = (FairyGUI.UIConfig)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.PreloadPackages = (System.Collections.Generic.List<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<string>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_soundLoader(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    FairyGUI.UIConfig.soundLoader = translator.GetDelegate<FairyGUI.UIConfig.SoundLoader>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
