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
    public class HotUpdateRessMgrWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(HotUpdateRessMgr);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RefreshLocalVerInfo", _m_RefreshLocalVerInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDownList", _m_GetDownList);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDecompressionTaskList", _m_GetDecompressionTaskList);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Save", _m_Save);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "verInfo", _g_get_verInfo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "downLoadInfo", _g_get_downLoadInfo);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "verInfo", _s_set_verInfo);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "downLoadInfo", _s_set_downLoadInfo);
            
			
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
					
					HotUpdateRessMgr __cl_gen_ret = new HotUpdateRessMgr();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to HotUpdateRessMgr constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                HotUpdateRessMgr __cl_gen_to_be_invoked = (HotUpdateRessMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Action callBack = translator.GetDelegate<System.Action>(L, 2);
                    
                    __cl_gen_to_be_invoked.Init( callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RefreshLocalVerInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                HotUpdateRessMgr __cl_gen_to_be_invoked = (HotUpdateRessMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Action callBack = translator.GetDelegate<System.Action>(L, 2);
                    
                    __cl_gen_to_be_invoked.RefreshLocalVerInfo( callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDownList(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                HotUpdateRessMgr __cl_gen_to_be_invoked = (HotUpdateRessMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    VerInfo localVer = (VerInfo)translator.GetObject(L, 2, typeof(VerInfo));
                    System.Action<HotUpdateRessMgr.DecompressionOrDownInfo> callBack = translator.GetDelegate<System.Action<HotUpdateRessMgr.DecompressionOrDownInfo>>(L, 3);
                    
                    __cl_gen_to_be_invoked.GetDownList( localVer, callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDecompressionTaskList(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                HotUpdateRessMgr __cl_gen_to_be_invoked = (HotUpdateRessMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    VerInfo localVer = (VerInfo)translator.GetObject(L, 2, typeof(VerInfo));
                    System.Action<HotUpdateRessMgr.DecompressionOrDownInfo> callBack = translator.GetDelegate<System.Action<HotUpdateRessMgr.DecompressionOrDownInfo>>(L, 3);
                    
                    __cl_gen_to_be_invoked.GetDecompressionTaskList( localVer, callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Save(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                HotUpdateRessMgr __cl_gen_to_be_invoked = (HotUpdateRessMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    HotUpdateRessMgr.DecompressionOrDownInfo info = (HotUpdateRessMgr.DecompressionOrDownInfo)translator.GetObject(L, 2, typeof(HotUpdateRessMgr.DecompressionOrDownInfo));
                    bool saveVer = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.Save( info, saveVer );
                    
                    
                    
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
			    translator.Push(L, HotUpdateRessMgr.Instance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HotUpdateRessMgr __cl_gen_to_be_invoked = (HotUpdateRessMgr)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.verInfo);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_downLoadInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HotUpdateRessMgr __cl_gen_to_be_invoked = (HotUpdateRessMgr)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.downLoadInfo);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HotUpdateRessMgr __cl_gen_to_be_invoked = (HotUpdateRessMgr)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verInfo = (VerInfo)translator.GetObject(L, 2, typeof(VerInfo));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_downLoadInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HotUpdateRessMgr __cl_gen_to_be_invoked = (HotUpdateRessMgr)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.downLoadInfo = (RemotelyVersionInfo.RemotelyInfo)translator.GetObject(L, 2, typeof(RemotelyVersionInfo.RemotelyInfo));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
