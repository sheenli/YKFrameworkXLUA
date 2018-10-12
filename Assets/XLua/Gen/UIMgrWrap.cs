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
    public class UIMgrWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UIMgr);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetWindow", _m_GetWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllOpenWindows", _m_GetAllOpenWindows);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShowWindow", _m_ShowWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CloseWindow", _m_CloseWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeleteWind", _m_DeleteWind);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsOpenWindow", _m_IsOpenWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeleteAllWindows", _m_DeleteAllWindows);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HideAllWindows", _m_HideAllWindows);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUpdate", _m_OnUpdate);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIMgr __cl_gen_ret = new UIMgr();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIMgr constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UIMgr __cl_gen_to_be_invoked = (UIMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Init(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UIMgr __cl_gen_to_be_invoked = (UIMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    
                        BaseUI __cl_gen_ret = __cl_gen_to_be_invoked.GetWindow( uiName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllOpenWindows(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UIMgr __cl_gen_to_be_invoked = (UIMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.List<string> __cl_gen_ret = __cl_gen_to_be_invoked.GetAllOpenWindows(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UIMgr __cl_gen_to_be_invoked = (UIMgr)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 8&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<System.Func<BaseUI>>(L, 4)&& translator.Assignable<object>(L, 5)&& translator.Assignable<System.Collections.Generic.List<string>>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)&& translator.Assignable<System.Action<BaseUI>>(L, 8)) 
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    System.Func<BaseUI> _createFun = translator.GetDelegate<System.Func<BaseUI>>(L, 4);
                    object param = translator.GetObject(L, 5, typeof(object));
                    System.Collections.Generic.List<string> hideWinds = (System.Collections.Generic.List<string>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<string>));
                    bool hideDotDel = LuaAPI.lua_toboolean(L, 7);
                    System.Action<BaseUI> callback = translator.GetDelegate<System.Action<BaseUI>>(L, 8);
                    
                    __cl_gen_to_be_invoked.ShowWindow( uiName, type, _createFun, param, hideWinds, hideDotDel, callback );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<System.Func<BaseUI>>(L, 4)&& translator.Assignable<object>(L, 5)&& translator.Assignable<System.Collections.Generic.List<string>>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)) 
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    System.Func<BaseUI> _createFun = translator.GetDelegate<System.Func<BaseUI>>(L, 4);
                    object param = translator.GetObject(L, 5, typeof(object));
                    System.Collections.Generic.List<string> hideWinds = (System.Collections.Generic.List<string>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<string>));
                    bool hideDotDel = LuaAPI.lua_toboolean(L, 7);
                    
                    __cl_gen_to_be_invoked.ShowWindow( uiName, type, _createFun, param, hideWinds, hideDotDel );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<System.Func<BaseUI>>(L, 4)&& translator.Assignable<object>(L, 5)&& translator.Assignable<System.Collections.Generic.List<string>>(L, 6)) 
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    System.Func<BaseUI> _createFun = translator.GetDelegate<System.Func<BaseUI>>(L, 4);
                    object param = translator.GetObject(L, 5, typeof(object));
                    System.Collections.Generic.List<string> hideWinds = (System.Collections.Generic.List<string>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<string>));
                    
                    __cl_gen_to_be_invoked.ShowWindow( uiName, type, _createFun, param, hideWinds );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<System.Func<BaseUI>>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    System.Func<BaseUI> _createFun = translator.GetDelegate<System.Func<BaseUI>>(L, 4);
                    object param = translator.GetObject(L, 5, typeof(object));
                    
                    __cl_gen_to_be_invoked.ShowWindow( uiName, type, _createFun, param );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<System.Func<BaseUI>>(L, 4)) 
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    System.Func<BaseUI> _createFun = translator.GetDelegate<System.Func<BaseUI>>(L, 4);
                    
                    __cl_gen_to_be_invoked.ShowWindow( uiName, type, _createFun );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                    __cl_gen_to_be_invoked.ShowWindow( uiName, type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIMgr.ShowWindow!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CloseWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UIMgr __cl_gen_to_be_invoked = (UIMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.CloseWindow( uiName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteWind(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UIMgr __cl_gen_to_be_invoked = (UIMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.DeleteWind( uiName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsOpenWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UIMgr __cl_gen_to_be_invoked = (UIMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string uiName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsOpenWindow( uiName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteAllWindows(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UIMgr __cl_gen_to_be_invoked = (UIMgr)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool isDotDel = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.DeleteAllWindows( isDotDel );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.DeleteAllWindows(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIMgr.DeleteAllWindows!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HideAllWindows(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UIMgr __cl_gen_to_be_invoked = (UIMgr)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool isDotDel = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.HideAllWindows( isDotDel );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.HideAllWindows(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIMgr.HideAllWindows!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnUpdate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UIMgr __cl_gen_to_be_invoked = (UIMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnUpdate(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UIMgr.Instance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
