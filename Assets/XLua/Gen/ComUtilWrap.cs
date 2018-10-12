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
    public class ComUtilWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ComUtil);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "isNull", _m_isNull);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 50, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AddGameObjectToZeroPos", _m_AddGameObjectToZeroPos_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddGameObjectTo", _m_AddGameObjectTo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUTF8StringTrimZero", _m_GetUTF8StringTrimZero_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetVerticalString", _m_GetVerticalString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsSubClassOfRawGeneric", _m_IsSubClassOfRawGeneric_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsSubClassOf", _m_IsSubClassOf_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SortRoutePointExcludeTag", _m_SortRoutePointExcludeTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SortRoutePointWithTag", _m_SortRoutePointWithTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindGameObjectByLocalPath", _m_FindGameObjectByLocalPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRandIn0_1", _m_GetRandIn0_1_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindTransformInChild", _m_FindTransformInChild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetOneListStr", _m_GetOneListStr_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetOneListTran", _m_GetOneListTran_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindTransformInChildSort", _m_FindTransformInChildSort_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindTransformNameAll", _m_FindTransformNameAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindTransformAllActiveChild", _m_FindTransformAllActiveChild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TimestampToTime", _m_TimestampToTime_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetNumberLen", _m_GetNumberLen_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTransformInChilds", _m_GetTransformInChilds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HTTPGetData", _m_HTTPGetData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPosX", _m_GetPosX_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFixedSizeIndexPos", _m_GetFixedSizeIndexPos_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetActive", _m_GetActive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAddressByIp", _m_GetAddressByIp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetWWWGetData", _m_GetWWWGetData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UniconToString", _m_UniconToString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCardX", _m_GetCardX_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCardCenter", _m_GetCardCenter_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ServerToLocal_5", _m_ServerToLocal_5_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ServerToLocal", _m_ServerToLocal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LocalToServerPos_5", _m_LocalToServerPos_5_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LocalToServerPos", _m_LocalToServerPos_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLayer", _m_GetLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetObjLayer", _m_SetObjLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WWWLoad", _m_WWWLoad_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WWWGet", _m_WWWGet_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WWWGetAndSign", _m_WWWGetAndSign_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAddressIP", _m_GetAddressIP_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDistance", _m_GetDistance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAddressByLocation", _m_GetAddressByLocation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Base64Encode", _m_Base64Encode_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Base64Decode", _m_Base64Decode_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UncompressByType", _m_UncompressByType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Compress", _m_Compress_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Deompress", _m_Deompress_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetTimeScale", _m_SetTimeScale_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MD5Encrypt", _m_MD5Encrypt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetHTTPsign", _m_GetHTTPsign_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "QuitGame", _m_QuitGame_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					ComUtil __cl_gen_ret = new ComUtil();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ComUtil constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddGameObjectToZeroPos_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform transChild = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform transParent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    ComUtil.AddGameObjectToZeroPos( transChild, transParent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddGameObjectTo_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform transChild = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform transParent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    ComUtil.AddGameObjectTo( transChild, transParent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUTF8StringTrimZero_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] buffer = LuaAPI.lua_tobytes(L, 1);
                    
                        string __cl_gen_ret = ComUtil.GetUTF8StringTrimZero( buffer );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVerticalString_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string val = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = ComUtil.GetVerticalString( val );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSubClassOfRawGeneric_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type generic = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    System.Type toCheck = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool __cl_gen_ret = ComUtil.IsSubClassOfRawGeneric( generic, toCheck );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSubClassOf_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type baseType = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    System.Type toCheck = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool __cl_gen_ret = ComUtil.IsSubClassOf( baseType, toCheck );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SortRoutePointExcludeTag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.GameObject root = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    string tag = LuaAPI.lua_tostring(L, 2);
                    
                        System.Collections.Generic.List<UnityEngine.Transform> __cl_gen_ret = ComUtil.SortRoutePointExcludeTag( root, tag );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SortRoutePointWithTag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.GameObject root = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    string tag = LuaAPI.lua_tostring(L, 2);
                    
                        System.Collections.Generic.List<UnityEngine.Transform> __cl_gen_ret = ComUtil.SortRoutePointWithTag( root, tag );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindGameObjectByLocalPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    string localPath = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.GameObject __cl_gen_ret = ComUtil.FindGameObjectByLocalPath( go, localPath );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRandIn0_1_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int seed = LuaAPI.xlua_tointeger(L, 1);
                    
                        float __cl_gen_ret = ComUtil.GetRandIn0_1( seed );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 0) 
                {
                    
                        float __cl_gen_ret = ComUtil.GetRandIn0_1(  );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ComUtil.GetRandIn0_1!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindTransformInChild_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform tan = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    string name = LuaAPI.lua_tostring(L, 2);
                    bool oneLevel = LuaAPI.lua_toboolean(L, 3);
                    
                        UnityEngine.Transform __cl_gen_ret = ComUtil.FindTransformInChild( tan, name, oneLevel );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Transform tan = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Transform __cl_gen_ret = ComUtil.FindTransformInChild( tan, name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<System.Collections.Generic.List<string>>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform tan = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    System.Collections.Generic.List<string> names = (System.Collections.Generic.List<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<string>));
                    bool oneLevel = LuaAPI.lua_toboolean(L, 3);
                    
                        System.Collections.Generic.List<UnityEngine.Transform> __cl_gen_ret = ComUtil.FindTransformInChild( tan, names, oneLevel );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<System.Collections.Generic.List<string>>(L, 2)) 
                {
                    UnityEngine.Transform tan = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    System.Collections.Generic.List<string> names = (System.Collections.Generic.List<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<string>));
                    
                        System.Collections.Generic.List<UnityEngine.Transform> __cl_gen_ret = ComUtil.FindTransformInChild( tan, names );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ComUtil.FindTransformInChild!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOneListStr_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        System.Collections.Generic.List<string> __cl_gen_ret = ComUtil.GetOneListStr(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOneListTran_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        System.Collections.Generic.List<UnityEngine.Transform> __cl_gen_ret = ComUtil.GetOneListTran(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindTransformInChildSort_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<System.Collections.Generic.List<string>>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform tan = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    System.Collections.Generic.List<string> names = (System.Collections.Generic.List<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<string>));
                    bool oneLevel = LuaAPI.lua_toboolean(L, 3);
                    
                        System.Collections.Generic.List<UnityEngine.Transform> __cl_gen_ret = ComUtil.FindTransformInChildSort( tan, names, oneLevel );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<System.Collections.Generic.List<string>>(L, 2)) 
                {
                    UnityEngine.Transform tan = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    System.Collections.Generic.List<string> names = (System.Collections.Generic.List<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<string>));
                    
                        System.Collections.Generic.List<UnityEngine.Transform> __cl_gen_ret = ComUtil.FindTransformInChildSort( tan, names );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ComUtil.FindTransformInChildSort!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindTransformNameAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform tan = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        System.Collections.Generic.List<UnityEngine.Transform> __cl_gen_ret = ComUtil.FindTransformNameAll( tan, name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindTransformAllActiveChild_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform tran = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                        System.Collections.Generic.List<UnityEngine.Transform> __cl_gen_ret = ComUtil.FindTransformAllActiveChild( tran );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TimestampToTime_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long unixTimeStamp = LuaAPI.lua_toint64(L, 1);
                    
                        string __cl_gen_ret = ComUtil.TimestampToTime( unixTimeStamp );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNumberLen_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int number = LuaAPI.xlua_tointeger(L, 1);
                    
                        int __cl_gen_ret = ComUtil.GetNumberLen( number );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTransformInChilds_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Collections.Generic.List<string> listName = (System.Collections.Generic.List<string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<string>));
                    UnityEngine.Transform tran = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    System.Collections.Generic.List<UnityEngine.Transform> trans = (System.Collections.Generic.List<UnityEngine.Transform>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Transform>));
                    
                    ComUtil.GetTransformInChilds( listName, tran, ref trans );
                    translator.Push(L, trans);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HTTPGetData_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    System.Text.Encoding encode = (System.Text.Encoding)translator.GetObject(L, 2, typeof(System.Text.Encoding));
                    
                        string __cl_gen_ret = ComUtil.HTTPGetData( url, encode );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPosX_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    float tw = (float)LuaAPI.lua_tonumber(L, 1);
                    int allNum = LuaAPI.xlua_tointeger(L, 2);
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    float thresholdMin = (float)LuaAPI.lua_tonumber(L, 4);
                    float thresholdMax = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        float __cl_gen_ret = ComUtil.GetPosX( tw, allNum, index, thresholdMin, thresholdMax );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float tw = (float)LuaAPI.lua_tonumber(L, 1);
                    int allNum = LuaAPI.xlua_tointeger(L, 2);
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    float thresholdMin = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        float __cl_gen_ret = ComUtil.GetPosX( tw, allNum, index, thresholdMin );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    float tw = (float)LuaAPI.lua_tonumber(L, 1);
                    int allNum = LuaAPI.xlua_tointeger(L, 2);
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    
                        float __cl_gen_ret = ComUtil.GetPosX( tw, allNum, index );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ComUtil.GetPosX!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFixedSizeIndexPos_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    float size = (float)LuaAPI.lua_tonumber(L, 1);
                    float unitSize = (float)LuaAPI.lua_tonumber(L, 2);
                    int allNum = LuaAPI.xlua_tointeger(L, 3);
                    int index = LuaAPI.xlua_tointeger(L, 4);
                    float thresholdMin = (float)LuaAPI.lua_tonumber(L, 5);
                    float thresholdMax = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        float __cl_gen_ret = ComUtil.GetFixedSizeIndexPos( size, unitSize, allNum, index, thresholdMin, thresholdMax );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    float size = (float)LuaAPI.lua_tonumber(L, 1);
                    float unitSize = (float)LuaAPI.lua_tonumber(L, 2);
                    int allNum = LuaAPI.xlua_tointeger(L, 3);
                    int index = LuaAPI.xlua_tointeger(L, 4);
                    float thresholdMin = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        float __cl_gen_ret = ComUtil.GetFixedSizeIndexPos( size, unitSize, allNum, index, thresholdMin );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float size = (float)LuaAPI.lua_tonumber(L, 1);
                    float unitSize = (float)LuaAPI.lua_tonumber(L, 2);
                    int allNum = LuaAPI.xlua_tointeger(L, 3);
                    int index = LuaAPI.xlua_tointeger(L, 4);
                    
                        float __cl_gen_ret = ComUtil.GetFixedSizeIndexPos( size, unitSize, allNum, index );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ComUtil.GetFixedSizeIndexPos!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetActive_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.MonoBehaviour mb = (UnityEngine.MonoBehaviour)translator.GetObject(L, 1, typeof(UnityEngine.MonoBehaviour));
                    
                        bool __cl_gen_ret = ComUtil.GetActive( mb );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAddressByIp_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string ip = LuaAPI.lua_tostring(L, 1);
                    System.Action<string> callBack = translator.GetDelegate<System.Action<string>>(L, 2);
                    
                    ComUtil.GetAddressByIp( ip, callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWWWGetData_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    System.Action<string> callBack = translator.GetDelegate<System.Action<string>>(L, 2);
                    
                        System.Collections.IEnumerator __cl_gen_ret = ComUtil.GetWWWGetData( url, callBack );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UniconToString_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string SourceString = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = ComUtil.UniconToString( SourceString );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCardX_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float startX = (float)LuaAPI.lua_tonumber(L, 1);
                    float offset = (float)LuaAPI.lua_tonumber(L, 2);
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    
                        float __cl_gen_ret = ComUtil.GetCardX( startX, offset, index );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCardCenter_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float startpos = (float)LuaAPI.lua_tonumber(L, 1);
                    float offset = (float)LuaAPI.lua_tonumber(L, 2);
                    int allNum = LuaAPI.xlua_tointeger(L, 3);
                    
                        float __cl_gen_ret = ComUtil.GetCardCenter( startpos, offset, allNum );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ServerToLocal_5_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int server = LuaAPI.xlua_tointeger(L, 1);
                    int selfServer = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = ComUtil.ServerToLocal_5( server, selfServer );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ServerToLocal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int server = LuaAPI.xlua_tointeger(L, 1);
                    int selfServer = LuaAPI.xlua_tointeger(L, 2);
                    int allNum = LuaAPI.xlua_tointeger(L, 3);
                    
                        int __cl_gen_ret = ComUtil.ServerToLocal( server, selfServer, allNum );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int server = LuaAPI.xlua_tointeger(L, 1);
                    int selfServer = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = ComUtil.ServerToLocal( server, selfServer );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ComUtil.ServerToLocal!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LocalToServerPos_5_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int local = LuaAPI.xlua_tointeger(L, 1);
                    int selfServer = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = ComUtil.LocalToServerPos_5( local, selfServer );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LocalToServerPos_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int local = LuaAPI.xlua_tointeger(L, 1);
                    int selfServer = LuaAPI.xlua_tointeger(L, 2);
                    int allNum = LuaAPI.xlua_tointeger(L, 3);
                    
                        int __cl_gen_ret = ComUtil.LocalToServerPos( local, selfServer, allNum );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int local = LuaAPI.xlua_tointeger(L, 1);
                    int selfServer = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = ComUtil.LocalToServerPos( local, selfServer );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ComUtil.LocalToServerPos!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLayer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = ComUtil.GetLayer( name );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetObjLayer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GameObject obj = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    
                    ComUtil.SetObjLayer( name, obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WWWLoad_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    System.Action<UnityEngine.WWW> callBack = translator.GetDelegate<System.Action<UnityEngine.WWW>>(L, 2);
                    
                    ComUtil.WWWLoad( url, callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WWWGet_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    System.Action<string> callBack = translator.GetDelegate<System.Action<string>>(L, 2);
                    
                    ComUtil.WWWGet( url, callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WWWGetAndSign_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    System.Action<string> callBack = translator.GetDelegate<System.Action<string>>(L, 2);
                    
                    ComUtil.WWWGetAndSign( url, callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAddressIP_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        string __cl_gen_ret = ComUtil.GetAddressIP(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDistance_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    double lat1 = LuaAPI.lua_tonumber(L, 1);
                    double lng1 = LuaAPI.lua_tonumber(L, 2);
                    double lat2 = LuaAPI.lua_tonumber(L, 3);
                    double lng2 = LuaAPI.lua_tonumber(L, 4);
                    
                        double __cl_gen_ret = ComUtil.GetDistance( lat1, lng1, lat2, lng2 );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAddressByLocation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string lng = LuaAPI.lua_tostring(L, 1);
                    string lat = LuaAPI.lua_tostring(L, 2);
                    System.Action<LocationAddressResultData> callBack = translator.GetDelegate<System.Action<LocationAddressResultData>>(L, 3);
                    
                    ComUtil.GetAddressByLocation( lng, lat, callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_isNull(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ComUtil __cl_gen_to_be_invoked = (ComUtil)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.isNull( obj );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Base64Encode_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string message = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = ComUtil.Base64Encode( message );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Base64Decode_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string message = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = ComUtil.Base64Decode( message );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UncompressByType_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string decodeStr = LuaAPI.lua_tostring(L, 1);
                    
                        byte[] __cl_gen_ret = ComUtil.UncompressByType( decodeStr );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Compress_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string param = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = ComUtil.Compress( param );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Deompress_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string param = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = ComUtil.Deompress( param );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTimeScale_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 1);
                    
                    ComUtil.SetTimeScale( value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MD5Encrypt_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string str = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = ComUtil.MD5Encrypt( str );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHTTPsign_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string url = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = ComUtil.GetHTTPsign( url );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_QuitGame_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    ComUtil.QuitGame(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
