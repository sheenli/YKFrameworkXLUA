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
    public class YKSupportLuaLuaStateBaseWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(YKSupportLua.LuaStateBase);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLuaTalbe", _m_SetLuaTalbe);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnEnter", _m_OnEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFixedUpdate", _m_OnFixedUpdate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnLateUpdate", _m_OnLateUpdate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnLeave", _m_OnLeave);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUpdate", _m_OnUpdate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnRelease", _m_OnRelease);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "StateId", _g_get_StateId);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "StateId", _s_set_StateId);
            
			
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
					
					YKSupportLua.LuaStateBase __cl_gen_ret = new YKSupportLua.LuaStateBase();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to YKSupportLua.LuaStateBase constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLuaTalbe(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaStateBase __cl_gen_to_be_invoked = (YKSupportLua.LuaStateBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    XLua.LuaTable peerTable = (XLua.LuaTable)translator.GetObject(L, 2, typeof(XLua.LuaTable));
                    
                    __cl_gen_to_be_invoked.SetLuaTalbe( peerTable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnEnter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaStateBase __cl_gen_to_be_invoked = (YKSupportLua.LuaStateBase)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& translator.Assignable<IState>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    IState prevState = (IState)translator.GetObject(L, 2, typeof(IState));
                    object param1 = translator.GetObject(L, 3, typeof(object));
                    object param2 = translator.GetObject(L, 4, typeof(object));
                    
                    __cl_gen_to_be_invoked.OnEnter( prevState, param1, param2 );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<IState>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    IState prevState = (IState)translator.GetObject(L, 2, typeof(IState));
                    object param1 = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.OnEnter( prevState, param1 );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<IState>(L, 2)) 
                {
                    IState prevState = (IState)translator.GetObject(L, 2, typeof(IState));
                    
                    __cl_gen_to_be_invoked.OnEnter( prevState );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to YKSupportLua.LuaStateBase.OnEnter!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnFixedUpdate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaStateBase __cl_gen_to_be_invoked = (YKSupportLua.LuaStateBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnFixedUpdate(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnLateUpdate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaStateBase __cl_gen_to_be_invoked = (YKSupportLua.LuaStateBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnLateUpdate(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnLeave(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaStateBase __cl_gen_to_be_invoked = (YKSupportLua.LuaStateBase)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& translator.Assignable<IState>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    IState nextState = (IState)translator.GetObject(L, 2, typeof(IState));
                    object param1 = translator.GetObject(L, 3, typeof(object));
                    object param2 = translator.GetObject(L, 4, typeof(object));
                    
                    __cl_gen_to_be_invoked.OnLeave( nextState, param1, param2 );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<IState>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    IState nextState = (IState)translator.GetObject(L, 2, typeof(IState));
                    object param1 = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.OnLeave( nextState, param1 );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<IState>(L, 2)) 
                {
                    IState nextState = (IState)translator.GetObject(L, 2, typeof(IState));
                    
                    __cl_gen_to_be_invoked.OnLeave( nextState );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to YKSupportLua.LuaStateBase.OnLeave!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnUpdate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaStateBase __cl_gen_to_be_invoked = (YKSupportLua.LuaStateBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnUpdate(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnRelease(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                YKSupportLua.LuaStateBase __cl_gen_to_be_invoked = (YKSupportLua.LuaStateBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnRelease(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_StateId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaStateBase __cl_gen_to_be_invoked = (YKSupportLua.LuaStateBase)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, __cl_gen_to_be_invoked.StateId);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_StateId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                YKSupportLua.LuaStateBase __cl_gen_to_be_invoked = (YKSupportLua.LuaStateBase)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.StateId = LuaAPI.xlua_touint(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
