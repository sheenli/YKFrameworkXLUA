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
    public class FairyGUIPopupMenuWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.PopupMenu);
			Utils.BeginObjectRegister(type, L, translator, 0, 14, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddItem", _m_AddItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddItemAt", _m_AddItemAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddSeperator", _m_AddSeperator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItemName", _m_GetItemName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetItemText", _m_SetItemText);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetItemVisible", _m_SetItemVisible);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetItemGrayed", _m_SetItemGrayed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetItemCheckable", _m_SetItemCheckable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetItemChecked", _m_SetItemChecked);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "isItemChecked", _m_isItemChecked);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveItem", _m_RemoveItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearItems", _m_ClearItems);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Show", _m_Show);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "itemCount", _g_get_itemCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "contentPane", _g_get_contentPane);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "list", _g_get_list);
            
			
			
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
					
					FairyGUI.PopupMenu __cl_gen_ret = new FairyGUI.PopupMenu();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string resourceURL = LuaAPI.lua_tostring(L, 2);
					
					FairyGUI.PopupMenu __cl_gen_ret = new FairyGUI.PopupMenu(resourceURL);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.PopupMenu constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddItem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<FairyGUI.EventCallback0>(L, 3)) 
                {
                    string caption = LuaAPI.lua_tostring(L, 2);
                    FairyGUI.EventCallback0 callback = translator.GetDelegate<FairyGUI.EventCallback0>(L, 3);
                    
                        FairyGUI.GButton __cl_gen_ret = __cl_gen_to_be_invoked.AddItem( caption, callback );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<FairyGUI.EventCallback1>(L, 3)) 
                {
                    string caption = LuaAPI.lua_tostring(L, 2);
                    FairyGUI.EventCallback1 callback = translator.GetDelegate<FairyGUI.EventCallback1>(L, 3);
                    
                        FairyGUI.GButton __cl_gen_ret = __cl_gen_to_be_invoked.AddItem( caption, callback );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.PopupMenu.AddItem!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddItemAt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<FairyGUI.EventCallback0>(L, 4)) 
                {
                    string caption = LuaAPI.lua_tostring(L, 2);
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.EventCallback0 callback = translator.GetDelegate<FairyGUI.EventCallback0>(L, 4);
                    
                        FairyGUI.GButton __cl_gen_ret = __cl_gen_to_be_invoked.AddItemAt( caption, index, callback );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<FairyGUI.EventCallback1>(L, 4)) 
                {
                    string caption = LuaAPI.lua_tostring(L, 2);
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.EventCallback1 callback = translator.GetDelegate<FairyGUI.EventCallback1>(L, 4);
                    
                        FairyGUI.GButton __cl_gen_ret = __cl_gen_to_be_invoked.AddItemAt( caption, index, callback );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.PopupMenu.AddItemAt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddSeperator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.AddSeperator(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItemName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetItemName( index );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetItemText(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    string caption = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.SetItemText( name, caption );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetItemVisible(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    bool visible = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetItemVisible( name, visible );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetItemGrayed(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    bool grayed = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetItemGrayed( name, grayed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetItemCheckable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    bool checkable = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetItemCheckable( name, checkable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetItemChecked(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    bool check = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetItemChecked( name, check );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_isItemChecked(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.isItemChecked( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveItem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.RemoveItem( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearItems(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.ClearItems(  );
                    
                    
                    
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
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Show(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Show(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<FairyGUI.GObject>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    FairyGUI.GObject target = (FairyGUI.GObject)translator.GetObject(L, 2, typeof(FairyGUI.GObject));
                    object downward = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.Show( target, downward );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.PopupMenu.Show!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_itemCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.itemCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_contentPane(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.contentPane);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_list(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.PopupMenu __cl_gen_to_be_invoked = (FairyGUI.PopupMenu)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.list);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
