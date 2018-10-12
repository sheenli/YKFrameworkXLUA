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
    public class GameCfgMgrWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GameCfgMgr);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetResInfo", _m_GetResInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGroupInfo", _m_GetGroupInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGroupABs", _m_GetGroupABs);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadResCfg", _m_LoadResCfg);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "localGameCfg", _g_get_localGameCfg);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resCfg", _g_get_resCfg);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "localGameCfg", _s_set_localGameCfg);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resCfg", _s_set_resCfg);
            
			
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
					
					GameCfgMgr __cl_gen_ret = new GameCfgMgr();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to GameCfgMgr constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetResInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameCfgMgr __cl_gen_to_be_invoked = (GameCfgMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    
                        ResInfoData __cl_gen_ret = __cl_gen_to_be_invoked.GetResInfo( assetName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGroupInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameCfgMgr __cl_gen_to_be_invoked = (GameCfgMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string groupName = LuaAPI.lua_tostring(L, 2);
                    
                        ResGroupCfg __cl_gen_ret = __cl_gen_to_be_invoked.GetGroupInfo( groupName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGroupABs(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameCfgMgr __cl_gen_to_be_invoked = (GameCfgMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ResGroupCfg groupData = (ResGroupCfg)translator.GetObject(L, 2, typeof(ResGroupCfg));
                    
                        System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<ResInfoData>> __cl_gen_ret = __cl_gen_to_be_invoked.GetGroupABs( groupData );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameCfgMgr __cl_gen_to_be_invoked = (GameCfgMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Init(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadResCfg(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameCfgMgr __cl_gen_to_be_invoked = (GameCfgMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.LoadResCfg(  );
                    
                    
                    
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
			    translator.Push(L, GameCfgMgr.Instance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_localGameCfg(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameCfgMgr __cl_gen_to_be_invoked = (GameCfgMgr)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.localGameCfg);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_resCfg(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameCfgMgr __cl_gen_to_be_invoked = (GameCfgMgr)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.resCfg);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_localGameCfg(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameCfgMgr __cl_gen_to_be_invoked = (GameCfgMgr)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.localGameCfg = (LocalGameCfgData)translator.GetObject(L, 2, typeof(LocalGameCfgData));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_resCfg(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameCfgMgr __cl_gen_to_be_invoked = (GameCfgMgr)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.resCfg = (ResCfg)translator.GetObject(L, 2, typeof(ResCfg));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
