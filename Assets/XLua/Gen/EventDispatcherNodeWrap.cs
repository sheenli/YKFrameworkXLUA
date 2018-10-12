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
    public class EventDispatcherNodeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(EventDispatcherNode);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasListener", _m_HasListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AttachListener", _m_AttachListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DetachListener", _m_DetachListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUpdate", _m_OnUpdate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "QueueEvent", _m_QueueEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "QueueEventLua", _m_QueueEventLua);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "QueueEventNow", _m_QueueEventNow);
			
			
			
			
			
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
					
					EventDispatcherNode __cl_gen_ret = new EventDispatcherNode();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to EventDispatcherNode constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasListener(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                EventDispatcherNode __cl_gen_to_be_invoked = (EventDispatcherNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string type = LuaAPI.lua_tostring(L, 2);
                    EventDispatcherNode.EventListenerDele _listener = translator.GetDelegate<EventDispatcherNode.EventListenerDele>(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasListener( type, _listener );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AttachListener(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                EventDispatcherNode __cl_gen_to_be_invoked = (EventDispatcherNode)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<EventDispatcherNode.EventListenerDele>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    int type = LuaAPI.xlua_tointeger(L, 2);
                    EventDispatcherNode.EventListenerDele _listener = translator.GetDelegate<EventDispatcherNode.EventListenerDele>(L, 3);
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    bool _dispatchOnce = LuaAPI.lua_toboolean(L, 5);
                    
                    __cl_gen_to_be_invoked.AttachListener( type, _listener, _priority, _dispatchOnce );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<EventDispatcherNode.EventListenerDele>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int type = LuaAPI.xlua_tointeger(L, 2);
                    EventDispatcherNode.EventListenerDele _listener = translator.GetDelegate<EventDispatcherNode.EventListenerDele>(L, 3);
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.AttachListener( type, _listener, _priority );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<EventDispatcherNode.EventListenerDele>(L, 3)) 
                {
                    int type = LuaAPI.xlua_tointeger(L, 2);
                    EventDispatcherNode.EventListenerDele _listener = translator.GetDelegate<EventDispatcherNode.EventListenerDele>(L, 3);
                    
                    __cl_gen_to_be_invoked.AttachListener( type, _listener );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<EventDispatcherNode.EventListenerDele>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    string type = LuaAPI.lua_tostring(L, 2);
                    EventDispatcherNode.EventListenerDele _listener = translator.GetDelegate<EventDispatcherNode.EventListenerDele>(L, 3);
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    bool _dispatchOnce = LuaAPI.lua_toboolean(L, 5);
                    
                    __cl_gen_to_be_invoked.AttachListener( type, _listener, _priority, _dispatchOnce );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<EventDispatcherNode.EventListenerDele>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string type = LuaAPI.lua_tostring(L, 2);
                    EventDispatcherNode.EventListenerDele _listener = translator.GetDelegate<EventDispatcherNode.EventListenerDele>(L, 3);
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.AttachListener( type, _listener, _priority );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<EventDispatcherNode.EventListenerDele>(L, 3)) 
                {
                    string type = LuaAPI.lua_tostring(L, 2);
                    EventDispatcherNode.EventListenerDele _listener = translator.GetDelegate<EventDispatcherNode.EventListenerDele>(L, 3);
                    
                    __cl_gen_to_be_invoked.AttachListener( type, _listener );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to EventDispatcherNode.AttachListener!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DetachListener(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                EventDispatcherNode __cl_gen_to_be_invoked = (EventDispatcherNode)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<EventDispatcherNode.EventListenerDele>(L, 3)) 
                {
                    int type = LuaAPI.xlua_tointeger(L, 2);
                    EventDispatcherNode.EventListenerDele _listener = translator.GetDelegate<EventDispatcherNode.EventListenerDele>(L, 3);
                    
                    __cl_gen_to_be_invoked.DetachListener( type, _listener );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<EventDispatcherNode.EventListenerDele>(L, 3)) 
                {
                    string type = LuaAPI.lua_tostring(L, 2);
                    EventDispatcherNode.EventListenerDele _listener = translator.GetDelegate<EventDispatcherNode.EventListenerDele>(L, 3);
                    
                    __cl_gen_to_be_invoked.DetachListener( type, _listener );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to EventDispatcherNode.DetachListener!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnUpdate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                EventDispatcherNode __cl_gen_to_be_invoked = (EventDispatcherNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.OnUpdate(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_QueueEvent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                EventDispatcherNode __cl_gen_to_be_invoked = (EventDispatcherNode)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int key = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.QueueEvent( key );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int key = LuaAPI.xlua_tointeger(L, 2);
                    int value = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.QueueEvent( key, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string key = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.QueueEvent( key );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<EventData>(L, 2)) 
                {
                    EventData data = (EventData)translator.GetObject(L, 2, typeof(EventData));
                    
                    __cl_gen_to_be_invoked.QueueEvent( data );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    int key = LuaAPI.xlua_tointeger(L, 2);
                    string value = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.QueueEvent( key, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to EventDispatcherNode.QueueEvent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_QueueEventLua(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                EventDispatcherNode __cl_gen_to_be_invoked = (EventDispatcherNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string key = LuaAPI.lua_tostring(L, 2);
                    object data = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.QueueEventLua( key, data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_QueueEventNow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                EventDispatcherNode __cl_gen_to_be_invoked = (EventDispatcherNode)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string key = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.QueueEventNow( key );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<EventData>(L, 2)) 
                {
                    EventData data = (EventData)translator.GetObject(L, 2, typeof(EventData));
                    
                    __cl_gen_to_be_invoked.QueueEventNow( data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to EventDispatcherNode.QueueEventNow!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
