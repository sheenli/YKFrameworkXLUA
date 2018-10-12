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
    public class EventDefWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(EventDef);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ServerColsed", EventDef.ServerColsed);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ServerConnectFinish", EventDef.ServerConnectFinish);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ServerConnectFailure", EventDef.ServerConnectFailure);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ServerRequestTimeout", EventDef.ServerRequestTimeout);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ServerError", EventDef.ServerError);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SendLoginCompleted", EventDef.SendLoginCompleted);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ServerResponse", EventDef.ServerResponse);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					EventDef __cl_gen_ret = new EventDef();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to EventDef constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
