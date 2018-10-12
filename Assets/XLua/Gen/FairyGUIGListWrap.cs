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
    public class FairyGUIGListWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.GList);
			Utils.BeginObjectRegister(type, L, translator, 0, 27, 22, 17);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFromPool", _m_GetFromPool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddItemFromPool", _m_AddItemFromPool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddChildAt", _m_AddChildAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveChildAt", _m_RemoveChildAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveChildToPoolAt", _m_RemoveChildToPoolAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveChildToPool", _m_RemoveChildToPool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveChildrenToPool", _m_RemoveChildrenToPool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSelection", _m_GetSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddSelection", _m_AddSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveSelection", _m_RemoveSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearSelection", _m_ClearSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectAll", _m_SelectAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectNone", _m_SelectNone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectReverse", _m_SelectReverse);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HandleArrowKey", _m_HandleArrowKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResizeToFit", _m_ResizeToFit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HandleControllerChanged", _m_HandleControllerChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScrollToView", _m_ScrollToView);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFirstChildInView", _m_GetFirstChildInView);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ChildIndexToItemIndex", _m_ChildIndexToItemIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemIndexToChildIndex", _m_ItemIndexToChildIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVirtual", _m_SetVirtual);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVirtualAndLoop", _m_SetVirtualAndLoop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RefreshVirtualList", _m_RefreshVirtualList);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Setup_BeforeAdd", _m_Setup_BeforeAdd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Setup_AfterAdd", _m_Setup_AfterAdd);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "onClickItem", _g_get_onClickItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onRightClickItem", _g_get_onRightClickItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layout", _g_get_layout);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineCount", _g_get_lineCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "columnCount", _g_get_columnCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineGap", _g_get_lineGap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "columnGap", _g_get_columnGap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "align", _g_get_align);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalAlign", _g_get_verticalAlign);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoResizeItem", _g_get_autoResizeItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "itemPool", _g_get_itemPool);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectedIndex", _g_get_selectedIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectionController", _g_get_selectionController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "touchItem", _g_get_touchItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isVirtual", _g_get_isVirtual);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "numItems", _g_get_numItems);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultItem", _g_get_defaultItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "foldInvisibleItems", _g_get_foldInvisibleItems);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectionMode", _g_get_selectionMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "itemRenderer", _g_get_itemRenderer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "itemProvider", _g_get_itemProvider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollItemToViewOnClick", _g_get_scrollItemToViewOnClick);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "layout", _s_set_layout);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineCount", _s_set_lineCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "columnCount", _s_set_columnCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineGap", _s_set_lineGap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "columnGap", _s_set_columnGap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "align", _s_set_align);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalAlign", _s_set_verticalAlign);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoResizeItem", _s_set_autoResizeItem);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectedIndex", _s_set_selectedIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectionController", _s_set_selectionController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "numItems", _s_set_numItems);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultItem", _s_set_defaultItem);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "foldInvisibleItems", _s_set_foldInvisibleItems);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectionMode", _s_set_selectionMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "itemRenderer", _s_set_itemRenderer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "itemProvider", _s_set_itemProvider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollItemToViewOnClick", _s_set_scrollItemToViewOnClick);
            
			
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
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					FairyGUI.GList __cl_gen_ret = new FairyGUI.GList();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.GList constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFromPool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 2);
                    
                        FairyGUI.GObject __cl_gen_ret = __cl_gen_to_be_invoked.GetFromPool( url );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddItemFromPool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        FairyGUI.GObject __cl_gen_ret = __cl_gen_to_be_invoked.AddItemFromPool(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string url = LuaAPI.lua_tostring(L, 2);
                    
                        FairyGUI.GObject __cl_gen_ret = __cl_gen_to_be_invoked.AddItemFromPool( url );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.GList.AddItemFromPool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddChildAt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.GObject child = (FairyGUI.GObject)translator.GetObject(L, 2, typeof(FairyGUI.GObject));
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    
                        FairyGUI.GObject __cl_gen_ret = __cl_gen_to_be_invoked.AddChildAt( child, index );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveChildAt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    bool dispose = LuaAPI.lua_toboolean(L, 3);
                    
                        FairyGUI.GObject __cl_gen_ret = __cl_gen_to_be_invoked.RemoveChildAt( index, dispose );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveChildToPoolAt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.RemoveChildToPoolAt( index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveChildToPool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.GObject child = (FairyGUI.GObject)translator.GetObject(L, 2, typeof(FairyGUI.GObject));
                    
                    __cl_gen_to_be_invoked.RemoveChildToPool( child );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveChildrenToPool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.RemoveChildrenToPool(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int beginIndex = LuaAPI.xlua_tointeger(L, 2);
                    int endIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.RemoveChildrenToPool( beginIndex, endIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.GList.RemoveChildrenToPool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSelection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.List<int> __cl_gen_ret = __cl_gen_to_be_invoked.GetSelection(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddSelection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    bool scrollItToView = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.AddSelection( index, scrollItToView );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveSelection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.RemoveSelection( index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearSelection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.ClearSelection(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectAll(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.SelectAll(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectNone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.SelectNone(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectReverse(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.SelectReverse(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HandleArrowKey(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int dir = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.HandleArrowKey( dir );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResizeToFit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int itemCount = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.ResizeToFit( itemCount );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int itemCount = LuaAPI.xlua_tointeger(L, 2);
                    int minSize = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.ResizeToFit( itemCount, minSize );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.GList.ResizeToFit!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HandleControllerChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.Controller c = (FairyGUI.Controller)translator.GetObject(L, 2, typeof(FairyGUI.Controller));
                    
                    __cl_gen_to_be_invoked.HandleControllerChanged( c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollToView(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.ScrollToView( index );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.ScrollToView( index, ani );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    bool ani = LuaAPI.lua_toboolean(L, 3);
                    bool setFirst = LuaAPI.lua_toboolean(L, 4);
                    
                    __cl_gen_to_be_invoked.ScrollToView( index, ani, setFirst );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.GList.ScrollToView!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFirstChildInView(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetFirstChildInView(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ChildIndexToItemIndex(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.ChildIndexToItemIndex( index );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ItemIndexToChildIndex(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.ItemIndexToChildIndex( index );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVirtual(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.SetVirtual(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVirtualAndLoop(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.SetVirtualAndLoop(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RefreshVirtualList(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.RefreshVirtualList(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Setup_BeforeAdd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.Utils.XML xml = (FairyGUI.Utils.XML)translator.GetObject(L, 2, typeof(FairyGUI.Utils.XML));
                    
                    __cl_gen_to_be_invoked.Setup_BeforeAdd( xml );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Setup_AfterAdd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.Utils.XML xml = (FairyGUI.Utils.XML)translator.GetObject(L, 2, typeof(FairyGUI.Utils.XML));
                    
                    __cl_gen_to_be_invoked.Setup_AfterAdd( xml );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onClickItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onClickItem);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onRightClickItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onRightClickItem);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_layout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.layout);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.lineCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_columnCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.columnCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineGap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.lineGap);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_columnGap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.columnGap);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_align(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.align);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalAlign(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.verticalAlign);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoResizeItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.autoResizeItem);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_itemPool(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.itemPool);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectedIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.selectedIndex);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectionController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.selectionController);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_touchItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.touchItem);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isVirtual(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isVirtual);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_numItems(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.numItems);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.defaultItem);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_foldInvisibleItems(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.foldInvisibleItems);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.selectionMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_itemRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.itemRenderer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_itemProvider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.itemProvider);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollItemToViewOnClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.scrollItemToViewOnClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_layout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                FairyGUI.ListLayoutType __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.layout = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.lineCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_columnCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.columnCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineGap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.lineGap = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_columnGap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.columnGap = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_align(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                FairyGUI.AlignType __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.align = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalAlign(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                FairyGUI.VertAlignType __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.verticalAlign = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoResizeItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.autoResizeItem = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectedIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.selectedIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectionController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.selectionController = (FairyGUI.Controller)translator.GetObject(L, 2, typeof(FairyGUI.Controller));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_numItems(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.numItems = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.defaultItem = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_foldInvisibleItems(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.foldInvisibleItems = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                FairyGUI.ListSelectionMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.selectionMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_itemRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.itemRenderer = translator.GetDelegate<FairyGUI.ListItemRenderer>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_itemProvider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.itemProvider = translator.GetDelegate<FairyGUI.ListItemProvider>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scrollItemToViewOnClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GList __cl_gen_to_be_invoked = (FairyGUI.GList)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.scrollItemToViewOnClick = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
