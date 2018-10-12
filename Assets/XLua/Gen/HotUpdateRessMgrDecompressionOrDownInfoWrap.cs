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
    public class HotUpdateRessMgrDecompressionOrDownInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(HotUpdateRessMgr.DecompressionOrDownInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 3, 3);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "comparisonInfo", _g_get_comparisonInfo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "remoteVer", _g_get_remoteVer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localVer", _g_get_localVer);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "comparisonInfo", _s_set_comparisonInfo);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "remoteVer", _s_set_remoteVer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localVer", _s_set_localVer);
            
			
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
					
					HotUpdateRessMgr.DecompressionOrDownInfo __cl_gen_ret = new HotUpdateRessMgr.DecompressionOrDownInfo();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to HotUpdateRessMgr.DecompressionOrDownInfo constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_comparisonInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HotUpdateRessMgr.DecompressionOrDownInfo __cl_gen_to_be_invoked = (HotUpdateRessMgr.DecompressionOrDownInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.comparisonInfo);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_remoteVer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HotUpdateRessMgr.DecompressionOrDownInfo __cl_gen_to_be_invoked = (HotUpdateRessMgr.DecompressionOrDownInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.remoteVer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_localVer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HotUpdateRessMgr.DecompressionOrDownInfo __cl_gen_to_be_invoked = (HotUpdateRessMgr.DecompressionOrDownInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.localVer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_comparisonInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HotUpdateRessMgr.DecompressionOrDownInfo __cl_gen_to_be_invoked = (HotUpdateRessMgr.DecompressionOrDownInfo)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.comparisonInfo = (ComparisonInfo)translator.GetObject(L, 2, typeof(ComparisonInfo));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_remoteVer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HotUpdateRessMgr.DecompressionOrDownInfo __cl_gen_to_be_invoked = (HotUpdateRessMgr.DecompressionOrDownInfo)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.remoteVer = (VerInfo)translator.GetObject(L, 2, typeof(VerInfo));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_localVer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HotUpdateRessMgr.DecompressionOrDownInfo __cl_gen_to_be_invoked = (HotUpdateRessMgr.DecompressionOrDownInfo)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.localVer = (VerInfo)translator.GetObject(L, 2, typeof(VerInfo));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
