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
    public class UnityEnginePhysicsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Physics);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 31, 8, 8);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Raycast", _m_Raycast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RaycastAll", _m_RaycastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RaycastNonAlloc", _m_RaycastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Linecast", _m_Linecast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapSphere", _m_OverlapSphere_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapSphereNonAlloc", _m_OverlapSphereNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCapsule", _m_OverlapCapsule_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCapsuleNonAlloc", _m_OverlapCapsuleNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CapsuleCast", _m_CapsuleCast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SphereCast", _m_SphereCast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CapsuleCastAll", _m_CapsuleCastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CapsuleCastNonAlloc", _m_CapsuleCastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SphereCastAll", _m_SphereCastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SphereCastNonAlloc", _m_SphereCastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CheckSphere", _m_CheckSphere_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CheckCapsule", _m_CheckCapsule_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CheckBox", _m_CheckBox_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapBox", _m_OverlapBox_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapBoxNonAlloc", _m_OverlapBoxNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoxCastAll", _m_BoxCastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoxCastNonAlloc", _m_BoxCastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoxCast", _m_BoxCast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IgnoreCollision", _m_IgnoreCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IgnoreLayerCollision", _m_IgnoreLayerCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetIgnoreLayerCollision", _m_GetIgnoreLayerCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputePenetration", _m_ComputePenetration_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClosestPoint", _m_ClosestPoint_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreRaycastLayer", UnityEngine.Physics.IgnoreRaycastLayer);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultRaycastLayers", UnityEngine.Physics.DefaultRaycastLayers);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AllLayers", UnityEngine.Physics.AllLayers);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "gravity", _g_get_gravity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultContactOffset", _g_get_defaultContactOffset);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "bounceThreshold", _g_get_bounceThreshold);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultSolverIterations", _g_get_defaultSolverIterations);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultSolverVelocityIterations", _g_get_defaultSolverVelocityIterations);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sleepThreshold", _g_get_sleepThreshold);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "queriesHitTriggers", _g_get_queriesHitTriggers);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "queriesHitBackfaces", _g_get_queriesHitBackfaces);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "gravity", _s_set_gravity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultContactOffset", _s_set_defaultContactOffset);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "bounceThreshold", _s_set_bounceThreshold);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultSolverIterations", _s_set_defaultSolverIterations);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultSolverVelocityIterations", _s_set_defaultSolverVelocityIterations);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "sleepThreshold", _s_set_sleepThreshold);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "queriesHitTriggers", _s_set_queriesHitTriggers);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "queriesHitBackfaces", _s_set_queriesHitBackfaces);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Physics __cl_gen_ret = new UnityEngine.Physics();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Ray>(L, 1)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( ray );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( ray, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Ray>(L, 1)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit hitInfo;
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( ray, out hitInfo );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( ray, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( ray, out hitInfo, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( ray, out hitInfo, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( origin, direction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( origin, direction, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( origin, direction, out hitInfo );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( origin, direction, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( origin, direction, out hitInfo, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 4)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 4, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( ray, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( origin, direction, out hitInfo, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 4)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 4, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( ray, out hitInfo, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( origin, direction, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Raycast( origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.Raycast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RaycastAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Ray>(L, 1)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.RaycastAll( ray );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.RaycastAll( ray, maxDistance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.RaycastAll( ray, maxDistance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.RaycastAll( origin, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.RaycastAll( origin, direction, maxDistance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 4)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 4, out queryTriggerInteraction);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.RaycastAll( ray, maxDistance, layerMask, queryTriggerInteraction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layermask = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.RaycastAll( origin, direction, maxDistance, layermask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layermask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.RaycastAll( origin, direction, maxDistance, layermask, queryTriggerInteraction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.RaycastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RaycastNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 2)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 2, typeof(UnityEngine.RaycastHit[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics.RaycastNonAlloc( ray, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 2, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        int __cl_gen_ret = UnityEngine.Physics.RaycastNonAlloc( ray, results, maxDistance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 1)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 2, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.Physics.RaycastNonAlloc( ray, results, maxDistance, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 3)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics.RaycastNonAlloc( origin, direction, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.Physics.RaycastNonAlloc( origin, direction, results, maxDistance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Ray>(L, 1)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 2, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        int __cl_gen_ret = UnityEngine.Physics.RaycastNonAlloc( ray, results, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layermask = LuaAPI.xlua_tointeger(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics.RaycastNonAlloc( origin, direction, results, maxDistance, layermask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 6)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layermask = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 6, out queryTriggerInteraction);
                    
                        int __cl_gen_ret = UnityEngine.Physics.RaycastNonAlloc( origin, direction, results, maxDistance, layermask, queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.RaycastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Linecast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Linecast( start, end );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Linecast( start, end, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    UnityEngine.RaycastHit hitInfo;
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Linecast( start, end, out hitInfo );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    UnityEngine.RaycastHit hitInfo;
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Linecast( start, end, out hitInfo, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 4)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 4, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Linecast( start, end, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 4)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    UnityEngine.RaycastHit hitInfo;
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 4, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.Linecast( start, end, out hitInfo, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.Linecast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapSphere_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.Collider[] __cl_gen_ret = UnityEngine.Physics.OverlapSphere( position, radius );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Collider[] __cl_gen_ret = UnityEngine.Physics.OverlapSphere( position, radius, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 4)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 4, out queryTriggerInteraction);
                    
                        UnityEngine.Collider[] __cl_gen_ret = UnityEngine.Physics.OverlapSphere( position, radius, layerMask, queryTriggerInteraction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.OverlapSphere!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapSphereNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider[]>(L, 3)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider[] results = (UnityEngine.Collider[])translator.GetObject(L, 3, typeof(UnityEngine.Collider[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics.OverlapSphereNonAlloc( position, radius, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider[] results = (UnityEngine.Collider[])translator.GetObject(L, 3, typeof(UnityEngine.Collider[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.Physics.OverlapSphereNonAlloc( position, radius, results, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider[] results = (UnityEngine.Collider[])translator.GetObject(L, 3, typeof(UnityEngine.Collider[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        int __cl_gen_ret = UnityEngine.Physics.OverlapSphereNonAlloc( position, radius, results, layerMask, queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.OverlapSphereNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCapsule_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 point0;translator.Get(L, 1, out point0);
                    UnityEngine.Vector3 point1;translator.Get(L, 2, out point1);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Collider[] __cl_gen_ret = UnityEngine.Physics.OverlapCapsule( point0, point1, radius );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 point0;translator.Get(L, 1, out point0);
                    UnityEngine.Vector3 point1;translator.Get(L, 2, out point1);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.Collider[] __cl_gen_ret = UnityEngine.Physics.OverlapCapsule( point0, point1, radius, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Vector3 point0;translator.Get(L, 1, out point0);
                    UnityEngine.Vector3 point1;translator.Get(L, 2, out point1);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        UnityEngine.Collider[] __cl_gen_ret = UnityEngine.Physics.OverlapCapsule( point0, point1, radius, layerMask, queryTriggerInteraction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.OverlapCapsule!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCapsuleNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider[]>(L, 4)) 
                {
                    UnityEngine.Vector3 point0;translator.Get(L, 1, out point0);
                    UnityEngine.Vector3 point1;translator.Get(L, 2, out point1);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider[] results = (UnityEngine.Collider[])translator.GetObject(L, 4, typeof(UnityEngine.Collider[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics.OverlapCapsuleNonAlloc( point0, point1, radius, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 point0;translator.Get(L, 1, out point0);
                    UnityEngine.Vector3 point1;translator.Get(L, 2, out point1);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider[] results = (UnityEngine.Collider[])translator.GetObject(L, 4, typeof(UnityEngine.Collider[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics.OverlapCapsuleNonAlloc( point0, point1, radius, results, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 6)) 
                {
                    UnityEngine.Vector3 point0;translator.Get(L, 1, out point0);
                    UnityEngine.Vector3 point1;translator.Get(L, 2, out point1);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider[] results = (UnityEngine.Collider[])translator.GetObject(L, 4, typeof(UnityEngine.Collider[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 6, out queryTriggerInteraction);
                    
                        int __cl_gen_ret = UnityEngine.Physics.OverlapCapsuleNonAlloc( point0, point1, radius, results, layerMask, queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.OverlapCapsuleNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CapsuleCast( point1, point2, radius, direction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CapsuleCast( point1, point2, radius, direction, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CapsuleCast( point1, point2, radius, direction, out hitInfo );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CapsuleCast( point1, point2, radius, direction, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CapsuleCast( point1, point2, radius, direction, out hitInfo, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CapsuleCast( point1, point2, radius, direction, out hitInfo, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 7, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CapsuleCast( point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 7, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CapsuleCast( point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.CapsuleCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SphereCast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( ray, radius );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( ray, radius, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.RaycastHit hitInfo;
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( ray, radius, out hitInfo );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( ray, radius, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( ray, radius, out hitInfo, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( ray, radius, out hitInfo, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( origin, radius, direction, out hitInfo );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( origin, radius, direction, out hitInfo, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( ray, radius, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( origin, radius, direction, out hitInfo, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( ray, radius, out hitInfo, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 6)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 6, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.SphereCast( origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.SphereCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCastAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.CapsuleCastAll( point1, point2, radius, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.CapsuleCastAll( point1, point2, radius, direction, maxDistance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layermask = LuaAPI.xlua_tointeger(L, 6);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.CapsuleCastAll( point1, point2, radius, direction, maxDistance, layermask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layermask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 7, out queryTriggerInteraction);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.CapsuleCastAll( point1, point2, radius, direction, maxDistance, layermask, queryTriggerInteraction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.CapsuleCastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCastNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics.CapsuleCastNonAlloc( point1, point2, radius, direction, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics.CapsuleCastNonAlloc( point1, point2, radius, direction, results, maxDistance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layermask = LuaAPI.xlua_tointeger(L, 7);
                    
                        int __cl_gen_ret = UnityEngine.Physics.CapsuleCastNonAlloc( point1, point2, radius, direction, results, maxDistance, layermask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 8)) 
                {
                    UnityEngine.Vector3 point1;translator.Get(L, 1, out point1);
                    UnityEngine.Vector3 point2;translator.Get(L, 2, out point2);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layermask = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 8, out queryTriggerInteraction);
                    
                        int __cl_gen_ret = UnityEngine.Physics.CapsuleCastNonAlloc( point1, point2, radius, direction, results, maxDistance, layermask, queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.CapsuleCastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SphereCastAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.SphereCastAll( ray, radius );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.SphereCastAll( ray, radius, maxDistance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.SphereCastAll( ray, radius, maxDistance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.SphereCastAll( origin, radius, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.SphereCastAll( origin, radius, direction, maxDistance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.SphereCastAll( origin, radius, direction, maxDistance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.SphereCastAll( ray, radius, maxDistance, layerMask, queryTriggerInteraction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 6)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 6, out queryTriggerInteraction);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.SphereCastAll( origin, radius, direction, maxDistance, layerMask, queryTriggerInteraction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.SphereCastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SphereCastNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics.SphereCastNonAlloc( ray, radius, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.Physics.SphereCastNonAlloc( ray, radius, results, maxDistance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics.SphereCastNonAlloc( ray, radius, results, maxDistance, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics.SphereCastNonAlloc( origin, radius, direction, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics.SphereCastNonAlloc( origin, radius, direction, results, maxDistance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics.SphereCastNonAlloc( origin, radius, direction, results, maxDistance, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 6)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 6, out queryTriggerInteraction);
                    
                        int __cl_gen_ret = UnityEngine.Physics.SphereCastNonAlloc( ray, radius, results, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 7, out queryTriggerInteraction);
                    
                        int __cl_gen_ret = UnityEngine.Physics.SphereCastNonAlloc( origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.SphereCastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckSphere_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CheckSphere( position, radius );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CheckSphere( position, radius, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 4)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 4, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CheckSphere( position, radius, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.CheckSphere!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckCapsule_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CheckCapsule( start, end, radius );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    int layermask = LuaAPI.xlua_tointeger(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CheckCapsule( start, end, radius, layermask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    float radius = (float)LuaAPI.lua_tonumber(L, 3);
                    int layermask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CheckCapsule( start, end, radius, layermask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.CheckCapsule!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckBox_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CheckBox( center, halfExtents );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Quaternion orientation;translator.Get(L, 3, out orientation);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CheckBox( center, halfExtents, orientation );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Quaternion orientation;translator.Get(L, 3, out orientation);
                    int layermask = LuaAPI.xlua_tointeger(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CheckBox( center, halfExtents, orientation, layermask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Quaternion orientation;translator.Get(L, 3, out orientation);
                    int layermask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.CheckBox( center, halfExtents, orientation, layermask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.CheckBox!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapBox_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    
                        UnityEngine.Collider[] __cl_gen_ret = UnityEngine.Physics.OverlapBox( center, halfExtents );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Quaternion orientation;translator.Get(L, 3, out orientation);
                    
                        UnityEngine.Collider[] __cl_gen_ret = UnityEngine.Physics.OverlapBox( center, halfExtents, orientation );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Quaternion orientation;translator.Get(L, 3, out orientation);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.Collider[] __cl_gen_ret = UnityEngine.Physics.OverlapBox( center, halfExtents, orientation, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 5)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Quaternion orientation;translator.Get(L, 3, out orientation);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 5, out queryTriggerInteraction);
                    
                        UnityEngine.Collider[] __cl_gen_ret = UnityEngine.Physics.OverlapBox( center, halfExtents, orientation, layerMask, queryTriggerInteraction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.OverlapBox!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapBoxNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Collider[]>(L, 3)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Collider[] results = (UnityEngine.Collider[])translator.GetObject(L, 3, typeof(UnityEngine.Collider[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics.OverlapBoxNonAlloc( center, halfExtents, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Collider[]>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Collider[] results = (UnityEngine.Collider[])translator.GetObject(L, 3, typeof(UnityEngine.Collider[]));
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    
                        int __cl_gen_ret = UnityEngine.Physics.OverlapBoxNonAlloc( center, halfExtents, results, orientation );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Collider[]>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Collider[] results = (UnityEngine.Collider[])translator.GetObject(L, 3, typeof(UnityEngine.Collider[]));
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics.OverlapBoxNonAlloc( center, halfExtents, results, orientation, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Collider[]>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 6)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Collider[] results = (UnityEngine.Collider[])translator.GetObject(L, 3, typeof(UnityEngine.Collider[]));
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 6, out queryTriggerInteraction);
                    
                        int __cl_gen_ret = UnityEngine.Physics.OverlapBoxNonAlloc( center, halfExtents, results, orientation, layerMask, queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.OverlapBoxNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCastAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.BoxCastAll( center, halfExtents, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.BoxCastAll( center, halfExtents, direction, orientation );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.BoxCastAll( center, halfExtents, direction, orientation, maxDistance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layermask = LuaAPI.xlua_tointeger(L, 6);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.BoxCastAll( center, halfExtents, direction, orientation, maxDistance, layermask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layermask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 7, out queryTriggerInteraction);
                    
                        UnityEngine.RaycastHit[] __cl_gen_ret = UnityEngine.Physics.BoxCastAll( center, halfExtents, direction, orientation, maxDistance, layermask, queryTriggerInteraction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.BoxCastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCastNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics.BoxCastNonAlloc( center, halfExtents, direction, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    UnityEngine.Quaternion orientation;translator.Get(L, 5, out orientation);
                    
                        int __cl_gen_ret = UnityEngine.Physics.BoxCastNonAlloc( center, halfExtents, direction, results, orientation );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    UnityEngine.Quaternion orientation;translator.Get(L, 5, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics.BoxCastNonAlloc( center, halfExtents, direction, results, orientation, maxDistance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    UnityEngine.Quaternion orientation;translator.Get(L, 5, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layermask = LuaAPI.xlua_tointeger(L, 7);
                    
                        int __cl_gen_ret = UnityEngine.Physics.BoxCastNonAlloc( center, halfExtents, direction, results, orientation, maxDistance, layermask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 8)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit[] results = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    UnityEngine.Quaternion orientation;translator.Get(L, 5, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layermask = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 8, out queryTriggerInteraction);
                    
                        int __cl_gen_ret = UnityEngine.Physics.BoxCastNonAlloc( center, halfExtents, direction, results, orientation, maxDistance, layermask, queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.BoxCastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.BoxCast( center, halfExtents, direction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    
                        bool __cl_gen_ret = UnityEngine.Physics.BoxCast( center, halfExtents, direction, out hitInfo );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.BoxCast( center, halfExtents, direction, orientation );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.BoxCast( center, halfExtents, direction, orientation, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.BoxCast( center, halfExtents, direction, out hitInfo, orientation );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.BoxCast( center, halfExtents, direction, orientation, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.BoxCast( center, halfExtents, direction, out hitInfo, orientation, maxDistance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.BoxCast( center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 7, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.BoxCast( center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 center;translator.Get(L, 1, out center);
                    UnityEngine.Vector3 halfExtents;translator.Get(L, 2, out halfExtents);
                    UnityEngine.Vector3 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit hitInfo;
                    UnityEngine.Quaternion orientation;translator.Get(L, 4, out orientation);
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction queryTriggerInteraction;translator.Get(L, 7, out queryTriggerInteraction);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.BoxCast( center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.BoxCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IgnoreCollision_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Collider>(L, 1)&& translator.Assignable<UnityEngine.Collider>(L, 2)) 
                {
                    UnityEngine.Collider collider1 = (UnityEngine.Collider)translator.GetObject(L, 1, typeof(UnityEngine.Collider));
                    UnityEngine.Collider collider2 = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
                    
                    UnityEngine.Physics.IgnoreCollision( collider1, collider2 );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Collider>(L, 1)&& translator.Assignable<UnityEngine.Collider>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Collider collider1 = (UnityEngine.Collider)translator.GetObject(L, 1, typeof(UnityEngine.Collider));
                    UnityEngine.Collider collider2 = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
                    bool ignore = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Physics.IgnoreCollision( collider1, collider2, ignore );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.IgnoreCollision!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IgnoreLayerCollision_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int layer1 = LuaAPI.xlua_tointeger(L, 1);
                    int layer2 = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Physics.IgnoreLayerCollision( layer1, layer2 );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int layer1 = LuaAPI.xlua_tointeger(L, 1);
                    int layer2 = LuaAPI.xlua_tointeger(L, 2);
                    bool ignore = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Physics.IgnoreLayerCollision( layer1, layer2, ignore );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics.IgnoreLayerCollision!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIgnoreLayerCollision_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int layer1 = LuaAPI.xlua_tointeger(L, 1);
                    int layer2 = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.Physics.GetIgnoreLayerCollision( layer1, layer2 );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputePenetration_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Collider colliderA = (UnityEngine.Collider)translator.GetObject(L, 1, typeof(UnityEngine.Collider));
                    UnityEngine.Vector3 positionA;translator.Get(L, 2, out positionA);
                    UnityEngine.Quaternion rotationA;translator.Get(L, 3, out rotationA);
                    UnityEngine.Collider colliderB = (UnityEngine.Collider)translator.GetObject(L, 4, typeof(UnityEngine.Collider));
                    UnityEngine.Vector3 positionB;translator.Get(L, 5, out positionB);
                    UnityEngine.Quaternion rotationB;translator.Get(L, 6, out rotationB);
                    UnityEngine.Vector3 direction;
                    float distance;
                    
                        bool __cl_gen_ret = UnityEngine.Physics.ComputePenetration( colliderA, positionA, rotationA, colliderB, positionB, rotationB, out direction, out distance );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.PushUnityEngineVector3(L, direction);
                        
                    LuaAPI.lua_pushnumber(L, distance);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClosestPoint_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 point;translator.Get(L, 1, out point);
                    UnityEngine.Collider collider = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
                    UnityEngine.Vector3 position;translator.Get(L, 3, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 4, out rotation);
                    
                        UnityEngine.Vector3 __cl_gen_ret = UnityEngine.Physics.ClosestPoint( point, collider, position, rotation );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineVector3(L, UnityEngine.Physics.gravity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultContactOffset(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics.defaultContactOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bounceThreshold(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics.bounceThreshold);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultSolverIterations(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Physics.defaultSolverIterations);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultSolverVelocityIterations(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Physics.defaultSolverVelocityIterations);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sleepThreshold(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics.sleepThreshold);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_queriesHitTriggers(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics.queriesHitTriggers);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_queriesHitBackfaces(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics.queriesHitBackfaces);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.Physics.gravity = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultContactOffset(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics.defaultContactOffset = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bounceThreshold(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics.bounceThreshold = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultSolverIterations(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics.defaultSolverIterations = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultSolverVelocityIterations(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics.defaultSolverVelocityIterations = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sleepThreshold(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics.sleepThreshold = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_queriesHitTriggers(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics.queriesHitTriggers = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_queriesHitBackfaces(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics.queriesHitBackfaces = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
