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
    public class WXConstantWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(WXConstant);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 5, 5);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WXAPPIDS", _g_get_WXAPPIDS);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "TransferWXAPPIDS", _g_get_TransferWXAPPIDS);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "XLAppID", _g_get_XLAppID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "UMengAppID", _g_get_UMengAppID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "UMengPushSecret", _g_get_UMengPushSecret);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "WXAPPIDS", _s_set_WXAPPIDS);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "TransferWXAPPIDS", _s_set_TransferWXAPPIDS);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "XLAppID", _s_set_XLAppID);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "UMengAppID", _s_set_UMengAppID);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "UMengPushSecret", _s_set_UMengPushSecret);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "WXConstant does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WXAPPIDS(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, WXConstant.WXAPPIDS);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TransferWXAPPIDS(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, WXConstant.TransferWXAPPIDS);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_XLAppID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, WXConstant.XLAppID);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UMengAppID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, WXConstant.UMengAppID);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UMengPushSecret(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, WXConstant.UMengPushSecret);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_WXAPPIDS(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    WXConstant.WXAPPIDS = (System.Collections.Generic.Dictionary<int, string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<int, string>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TransferWXAPPIDS(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    WXConstant.TransferWXAPPIDS = (System.Collections.Generic.Dictionary<int, string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<int, string>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_XLAppID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    WXConstant.XLAppID = (System.Collections.Generic.Dictionary<int, string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<int, string>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UMengAppID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    WXConstant.UMengAppID = (System.Collections.Generic.Dictionary<int, string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<int, string>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UMengPushSecret(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    WXConstant.UMengPushSecret = (System.Collections.Generic.Dictionary<int, string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<int, string>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
