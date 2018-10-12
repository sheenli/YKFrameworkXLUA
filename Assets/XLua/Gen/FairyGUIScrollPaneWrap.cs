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
    public class FairyGUIScrollPaneWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.ScrollPane);
			Utils.BeginObjectRegister(type, L, translator, 0, 18, 33, 18);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPercX", _m_SetPercX);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPercY", _m_SetPercY);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPosX", _m_SetPosX);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPosY", _m_SetPosY);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCurrentPageX", _m_SetCurrentPageX);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCurrentPageY", _m_SetCurrentPageY);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScrollTop", _m_ScrollTop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScrollBottom", _m_ScrollBottom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScrollUp", _m_ScrollUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScrollDown", _m_ScrollDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScrollLeft", _m_ScrollLeft);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScrollRight", _m_ScrollRight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScrollToView", _m_ScrollToView);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsChildInView", _m_IsChildInView);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelDragging", _m_CancelDragging);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LockHeader", _m_LockHeader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LockFooter", _m_LockFooter);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "onScroll", _g_get_onScroll);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onScrollEnd", _g_get_onScrollEnd);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onPullDownRelease", _g_get_onPullDownRelease);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onPullUpRelease", _g_get_onPullUpRelease);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "owner", _g_get_owner);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hzScrollBar", _g_get_hzScrollBar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vtScrollBar", _g_get_vtScrollBar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "header", _g_get_header);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "footer", _g_get_footer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bouncebackEffect", _g_get_bouncebackEffect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "touchEffect", _g_get_touchEffect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inertiaDisabled", _g_get_inertiaDisabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "softnessOnTopOrLeftSide", _g_get_softnessOnTopOrLeftSide);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollStep", _g_get_scrollStep);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "snapToItem", _g_get_snapToItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pageMode", _g_get_pageMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pageController", _g_get_pageController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseWheelEnabled", _g_get_mouseWheelEnabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "decelerationRate", _g_get_decelerationRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "percX", _g_get_percX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "percY", _g_get_percY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "posX", _g_get_posX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "posY", _g_get_posY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isBottomMost", _g_get_isBottomMost);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isRightMost", _g_get_isRightMost);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentPageX", _g_get_currentPageX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentPageY", _g_get_currentPageY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollingPosX", _g_get_scrollingPosX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollingPosY", _g_get_scrollingPosY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "contentWidth", _g_get_contentWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "contentHeight", _g_get_contentHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "viewWidth", _g_get_viewWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "viewHeight", _g_get_viewHeight);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "bouncebackEffect", _s_set_bouncebackEffect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "touchEffect", _s_set_touchEffect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inertiaDisabled", _s_set_inertiaDisabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "softnessOnTopOrLeftSide", _s_set_softnessOnTopOrLeftSide);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollStep", _s_set_scrollStep);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "snapToItem", _s_set_snapToItem);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pageMode", _s_set_pageMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pageController", _s_set_pageController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseWheelEnabled", _s_set_mouseWheelEnabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "decelerationRate", _s_set_decelerationRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "percX", _s_set_percX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "percY", _s_set_percY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "posX", _s_set_posX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "posY", _s_set_posY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentPageX", _s_set_currentPageX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentPageY", _s_set_currentPageY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "viewWidth", _s_set_viewWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "viewHeight", _s_set_viewHeight);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "draggingPane", _g_get_draggingPane);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 10 && translator.Assignable<FairyGUI.GComponent>(L, 2) && translator.Assignable<FairyGUI.ScrollType>(L, 3) && translator.Assignable<FairyGUI.Margin>(L, 4) && translator.Assignable<FairyGUI.ScrollBarDisplayType>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && (LuaAPI.lua_isnil(L, 7) || LuaAPI.lua_type(L, 7) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 9) || LuaAPI.lua_type(L, 9) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 10) || LuaAPI.lua_type(L, 10) == LuaTypes.LUA_TSTRING))
				{
					FairyGUI.GComponent owner = (FairyGUI.GComponent)translator.GetObject(L, 2, typeof(FairyGUI.GComponent));
					FairyGUI.ScrollType scrollType;translator.Get(L, 3, out scrollType);
					FairyGUI.Margin scrollBarMargin;translator.Get(L, 4, out scrollBarMargin);
					FairyGUI.ScrollBarDisplayType scrollBarDisplay;translator.Get(L, 5, out scrollBarDisplay);
					int flags = LuaAPI.xlua_tointeger(L, 6);
					string vtScrollBarRes = LuaAPI.lua_tostring(L, 7);
					string hzScrollBarRes = LuaAPI.lua_tostring(L, 8);
					string headerRes = LuaAPI.lua_tostring(L, 9);
					string footerRes = LuaAPI.lua_tostring(L, 10);
					
					FairyGUI.ScrollPane __cl_gen_ret = new FairyGUI.ScrollPane(owner, scrollType, scrollBarMargin, scrollBarDisplay, flags, vtScrollBarRes, hzScrollBarRes, headerRes, footerRes);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.ScrollPane constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPercX(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetPercX( value, ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPercY(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetPercY( value, ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPosX(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetPosX( value, ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPosY(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetPosY( value, ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCurrentPageX(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int value = LuaAPI.xlua_tointeger(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetCurrentPageX( value, ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCurrentPageY(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int value = LuaAPI.xlua_tointeger(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetCurrentPageY( value, ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollTop(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.ScrollTop(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool ani = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.ScrollTop( ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.ScrollPane.ScrollTop!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollBottom(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.ScrollBottom(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool ani = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.ScrollBottom( ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.ScrollPane.ScrollBottom!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollUp(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.ScrollUp(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    float ratio = (float)LuaAPI.lua_tonumber(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.ScrollUp( ratio, ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.ScrollPane.ScrollUp!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollDown(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.ScrollDown(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    float ratio = (float)LuaAPI.lua_tonumber(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.ScrollDown( ratio, ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.ScrollPane.ScrollDown!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollLeft(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.ScrollLeft(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    float ratio = (float)LuaAPI.lua_tonumber(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.ScrollLeft( ratio, ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.ScrollPane.ScrollLeft!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollRight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.ScrollRight(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    float ratio = (float)LuaAPI.lua_tonumber(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.ScrollRight( ratio, ani );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.ScrollPane.ScrollRight!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollToView(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<FairyGUI.GObject>(L, 2)) 
                {
                    FairyGUI.GObject obj = (FairyGUI.GObject)translator.GetObject(L, 2, typeof(FairyGUI.GObject));
                    
                    __cl_gen_to_be_invoked.ScrollToView( obj );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<FairyGUI.GObject>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    FairyGUI.GObject obj = (FairyGUI.GObject)translator.GetObject(L, 2, typeof(FairyGUI.GObject));
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.ScrollToView( obj, ani );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<FairyGUI.GObject>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    FairyGUI.GObject obj = (FairyGUI.GObject)translator.GetObject(L, 2, typeof(FairyGUI.GObject));
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    bool setFirst = LuaAPI.lua_toboolean(L, 4);
                    
                    __cl_gen_to_be_invoked.ScrollToView( obj, ani, setFirst );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect rect;translator.Get(L, 2, out rect);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    bool setFirst = LuaAPI.lua_toboolean(L, 4);
                    
                    __cl_gen_to_be_invoked.ScrollToView( rect, ani, setFirst );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.ScrollPane.ScrollToView!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsChildInView(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.GObject obj = (FairyGUI.GObject)translator.GetObject(L, 2, typeof(FairyGUI.GObject));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsChildInView( obj );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelDragging(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.CancelDragging(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LockHeader(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int size = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.LockHeader( size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LockFooter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int size = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.LockFooter( size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onScroll(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onScroll);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onScrollEnd(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onScrollEnd);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPullDownRelease(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onPullDownRelease);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPullUpRelease(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onPullUpRelease);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_draggingPane(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, FairyGUI.ScrollPane.draggingPane);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_owner(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.owner);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hzScrollBar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.hzScrollBar);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vtScrollBar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.vtScrollBar);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_header(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.header);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_footer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.footer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bouncebackEffect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.bouncebackEffect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_touchEffect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.touchEffect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inertiaDisabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.inertiaDisabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_softnessOnTopOrLeftSide(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.softnessOnTopOrLeftSide);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollStep(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.scrollStep);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_snapToItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.snapToItem);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pageMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.pageMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pageController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pageController);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseWheelEnabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.mouseWheelEnabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_decelerationRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.decelerationRate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_percX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.percX);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_percY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.percY);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_posX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.posX);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_posY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.posY);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isBottomMost(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isBottomMost);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isRightMost(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isRightMost);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentPageX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.currentPageX);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentPageY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.currentPageY);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollingPosX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.scrollingPosX);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollingPosY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.scrollingPosY);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_contentWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.contentWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_contentHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.contentHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_viewWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.viewWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_viewHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.viewHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bouncebackEffect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.bouncebackEffect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_touchEffect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.touchEffect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inertiaDisabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.inertiaDisabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_softnessOnTopOrLeftSide(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.softnessOnTopOrLeftSide = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scrollStep(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.scrollStep = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_snapToItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.snapToItem = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pageMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.pageMode = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pageController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.pageController = (FairyGUI.Controller)translator.GetObject(L, 2, typeof(FairyGUI.Controller));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseWheelEnabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mouseWheelEnabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_decelerationRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.decelerationRate = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_percX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.percX = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_percY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.percY = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_posX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.posX = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_posY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.posY = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentPageX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.currentPageX = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentPageY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.currentPageY = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_viewWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.viewWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_viewHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.ScrollPane __cl_gen_to_be_invoked = (FairyGUI.ScrollPane)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.viewHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
