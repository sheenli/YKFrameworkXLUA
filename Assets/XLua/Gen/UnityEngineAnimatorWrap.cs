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
    public class UnityEngineAnimatorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Animator);
			Utils.BeginObjectRegister(type, L, translator, 0, 53, 43, 19);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFloat", _m_GetFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFloat", _m_SetFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBool", _m_GetBool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBool", _m_SetBool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInteger", _m_GetInteger);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInteger", _m_SetInteger);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTrigger", _m_SetTrigger);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetTrigger", _m_ResetTrigger);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsParameterControlledByCurve", _m_IsParameterControlledByCurve);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIKPosition", _m_GetIKPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIKPosition", _m_SetIKPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIKRotation", _m_GetIKRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIKRotation", _m_SetIKRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIKPositionWeight", _m_GetIKPositionWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIKPositionWeight", _m_SetIKPositionWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIKRotationWeight", _m_GetIKRotationWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIKRotationWeight", _m_SetIKRotationWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIKHintPosition", _m_GetIKHintPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIKHintPosition", _m_SetIKHintPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIKHintPositionWeight", _m_GetIKHintPositionWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIKHintPositionWeight", _m_SetIKHintPositionWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLookAtPosition", _m_SetLookAtPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLookAtWeight", _m_SetLookAtWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBoneLocalRotation", _m_SetBoneLocalRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLayerName", _m_GetLayerName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLayerIndex", _m_GetLayerIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLayerWeight", _m_GetLayerWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLayerWeight", _m_SetLayerWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCurrentAnimatorStateInfo", _m_GetCurrentAnimatorStateInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNextAnimatorStateInfo", _m_GetNextAnimatorStateInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAnimatorTransitionInfo", _m_GetAnimatorTransitionInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCurrentAnimatorClipInfoCount", _m_GetCurrentAnimatorClipInfoCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCurrentAnimatorClipInfo", _m_GetCurrentAnimatorClipInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNextAnimatorClipInfoCount", _m_GetNextAnimatorClipInfoCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNextAnimatorClipInfo", _m_GetNextAnimatorClipInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsInTransition", _m_IsInTransition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetParameter", _m_GetParameter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MatchTarget", _m_MatchTarget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InterruptMatchTarget", _m_InterruptMatchTarget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CrossFadeInFixedTime", _m_CrossFadeInFixedTime);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CrossFade", _m_CrossFade);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PlayInFixedTime", _m_PlayInFixedTime);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", _m_Play);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTarget", _m_SetTarget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBoneTransform", _m_GetBoneTransform);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartPlayback", _m_StartPlayback);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StopPlayback", _m_StopPlayback);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartRecording", _m_StartRecording);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StopRecording", _m_StopRecording);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasState", _m_HasState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rebind", _m_Rebind);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyBuiltinRootMotion", _m_ApplyBuiltinRootMotion);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isOptimizable", _g_get_isOptimizable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isHuman", _g_get_isHuman);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasRootMotion", _g_get_hasRootMotion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "humanScale", _g_get_humanScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isInitialized", _g_get_isInitialized);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deltaPosition", _g_get_deltaPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deltaRotation", _g_get_deltaRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocity", _g_get_velocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularVelocity", _g_get_angularVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rootPosition", _g_get_rootPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rootRotation", _g_get_rootRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "applyRootMotion", _g_get_applyRootMotion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "linearVelocityBlending", _g_get_linearVelocityBlending);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "updateMode", _g_get_updateMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasTransformHierarchy", _g_get_hasTransformHierarchy);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gravityWeight", _g_get_gravityWeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bodyPosition", _g_get_bodyPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bodyRotation", _g_get_bodyRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stabilizeFeet", _g_get_stabilizeFeet);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layerCount", _g_get_layerCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parameters", _g_get_parameters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parameterCount", _g_get_parameterCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "feetPivotActive", _g_get_feetPivotActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivotWeight", _g_get_pivotWeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivotPosition", _g_get_pivotPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isMatchingTarget", _g_get_isMatchingTarget);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "speed", _g_get_speed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetPosition", _g_get_targetPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetRotation", _g_get_targetRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cullingMode", _g_get_cullingMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playbackTime", _g_get_playbackTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "recorderStartTime", _g_get_recorderStartTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "recorderStopTime", _g_get_recorderStopTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "recorderMode", _g_get_recorderMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "runtimeAnimatorController", _g_get_runtimeAnimatorController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasBoundPlayables", _g_get_hasBoundPlayables);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "avatar", _g_get_avatar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playableGraph", _g_get_playableGraph);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layersAffectMassCenter", _g_get_layersAffectMassCenter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftFeetBottomHeight", _g_get_leftFeetBottomHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightFeetBottomHeight", _g_get_rightFeetBottomHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "logWarnings", _g_get_logWarnings);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fireEvents", _g_get_fireEvents);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "rootPosition", _s_set_rootPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rootRotation", _s_set_rootRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "applyRootMotion", _s_set_applyRootMotion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "linearVelocityBlending", _s_set_linearVelocityBlending);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "updateMode", _s_set_updateMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bodyPosition", _s_set_bodyPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bodyRotation", _s_set_bodyRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stabilizeFeet", _s_set_stabilizeFeet);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "feetPivotActive", _s_set_feetPivotActive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "speed", _s_set_speed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cullingMode", _s_set_cullingMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playbackTime", _s_set_playbackTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "recorderStartTime", _s_set_recorderStartTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "recorderStopTime", _s_set_recorderStopTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "runtimeAnimatorController", _s_set_runtimeAnimatorController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "avatar", _s_set_avatar);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "layersAffectMassCenter", _s_set_layersAffectMassCenter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "logWarnings", _s_set_logWarnings);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fireEvents", _s_set_fireEvents);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "StringToHash", _m_StringToHash_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Animator __cl_gen_ret = new UnityEngine.Animator();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetFloat( id );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetFloat( name );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.GetFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetFloat( id, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    float dampTime = (float)LuaAPI.lua_tonumber(L, 4);
                    float deltaTime = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.SetFloat( id, value, dampTime, deltaTime );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetFloat( name, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    float dampTime = (float)LuaAPI.lua_tonumber(L, 4);
                    float deltaTime = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.SetFloat( name, value, dampTime, deltaTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.SetFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.GetBool( id );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.GetBool( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.GetBool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    bool value = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetBool( id, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    bool value = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetBool( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.SetBool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInteger(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetInteger( id );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetInteger( name );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.GetInteger!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInteger(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    int value = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetInteger( id, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    int value = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetInteger( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.SetInteger!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTrigger(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.SetTrigger( id );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.SetTrigger( name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.SetTrigger!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetTrigger(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.ResetTrigger( id );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.ResetTrigger( name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.ResetTrigger!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsParameterControlledByCurve(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsParameterControlledByCurve( id );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsParameterControlledByCurve( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.IsParameterControlledByCurve!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIKPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKGoal goal;translator.Get(L, 2, out goal);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.GetIKPosition( goal );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIKPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKGoal goal;translator.Get(L, 2, out goal);
                    UnityEngine.Vector3 goalPosition;translator.Get(L, 3, out goalPosition);
                    
                    __cl_gen_to_be_invoked.SetIKPosition( goal, goalPosition );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIKRotation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKGoal goal;translator.Get(L, 2, out goal);
                    
                        UnityEngine.Quaternion __cl_gen_ret = __cl_gen_to_be_invoked.GetIKRotation( goal );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIKRotation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKGoal goal;translator.Get(L, 2, out goal);
                    UnityEngine.Quaternion goalRotation;translator.Get(L, 3, out goalRotation);
                    
                    __cl_gen_to_be_invoked.SetIKRotation( goal, goalRotation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIKPositionWeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKGoal goal;translator.Get(L, 2, out goal);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetIKPositionWeight( goal );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIKPositionWeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKGoal goal;translator.Get(L, 2, out goal);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetIKPositionWeight( goal, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIKRotationWeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKGoal goal;translator.Get(L, 2, out goal);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetIKRotationWeight( goal );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIKRotationWeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKGoal goal;translator.Get(L, 2, out goal);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetIKRotationWeight( goal, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIKHintPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKHint hint;translator.Get(L, 2, out hint);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.GetIKHintPosition( hint );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIKHintPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKHint hint;translator.Get(L, 2, out hint);
                    UnityEngine.Vector3 hintPosition;translator.Get(L, 3, out hintPosition);
                    
                    __cl_gen_to_be_invoked.SetIKHintPosition( hint, hintPosition );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIKHintPositionWeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKHint hint;translator.Get(L, 2, out hint);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetIKHintPositionWeight( hint );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIKHintPositionWeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarIKHint hint;translator.Get(L, 2, out hint);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetIKHintPositionWeight( hint, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLookAtPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 lookAtPosition;translator.Get(L, 2, out lookAtPosition);
                    
                    __cl_gen_to_be_invoked.SetLookAtPosition( lookAtPosition );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLookAtWeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float weight = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    __cl_gen_to_be_invoked.SetLookAtWeight( weight );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    float weight = (float)LuaAPI.lua_tonumber(L, 2);
                    float bodyWeight = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetLookAtWeight( weight, bodyWeight );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float weight = (float)LuaAPI.lua_tonumber(L, 2);
                    float bodyWeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float headWeight = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.SetLookAtWeight( weight, bodyWeight, headWeight );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    float weight = (float)LuaAPI.lua_tonumber(L, 2);
                    float bodyWeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float headWeight = (float)LuaAPI.lua_tonumber(L, 4);
                    float eyesWeight = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.SetLookAtWeight( weight, bodyWeight, headWeight, eyesWeight );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    float weight = (float)LuaAPI.lua_tonumber(L, 2);
                    float bodyWeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float headWeight = (float)LuaAPI.lua_tonumber(L, 4);
                    float eyesWeight = (float)LuaAPI.lua_tonumber(L, 5);
                    float clampWeight = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    __cl_gen_to_be_invoked.SetLookAtWeight( weight, bodyWeight, headWeight, eyesWeight, clampWeight );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.SetLookAtWeight!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBoneLocalRotation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.HumanBodyBones humanBoneId;translator.Get(L, 2, out humanBoneId);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    
                    __cl_gen_to_be_invoked.SetBoneLocalRotation( humanBoneId, rotation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLayerName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetLayerName( layerIndex );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLayerIndex(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string layerName = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetLayerIndex( layerName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLayerWeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetLayerWeight( layerIndex );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLayerWeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    float weight = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetLayerWeight( layerIndex, weight );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCurrentAnimatorStateInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.AnimatorStateInfo __cl_gen_ret = __cl_gen_to_be_invoked.GetCurrentAnimatorStateInfo( layerIndex );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNextAnimatorStateInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.AnimatorStateInfo __cl_gen_ret = __cl_gen_to_be_invoked.GetNextAnimatorStateInfo( layerIndex );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAnimatorTransitionInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.AnimatorTransitionInfo __cl_gen_ret = __cl_gen_to_be_invoked.GetAnimatorTransitionInfo( layerIndex );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCurrentAnimatorClipInfoCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetCurrentAnimatorClipInfoCount( layerIndex );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCurrentAnimatorClipInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.AnimatorClipInfo[] __cl_gen_ret = __cl_gen_to_be_invoked.GetCurrentAnimatorClipInfo( layerIndex );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>>(L, 3)) 
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips = (System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>));
                    
                    __cl_gen_to_be_invoked.GetCurrentAnimatorClipInfo( layerIndex, clips );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.GetCurrentAnimatorClipInfo!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNextAnimatorClipInfoCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetNextAnimatorClipInfoCount( layerIndex );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNextAnimatorClipInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.AnimatorClipInfo[] __cl_gen_ret = __cl_gen_to_be_invoked.GetNextAnimatorClipInfo( layerIndex );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>>(L, 3)) 
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips = (System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>));
                    
                    __cl_gen_to_be_invoked.GetNextAnimatorClipInfo( layerIndex, clips );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.GetNextAnimatorClipInfo!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsInTransition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsInTransition( layerIndex );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetParameter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.AnimatorControllerParameter __cl_gen_ret = __cl_gen_to_be_invoked.GetParameter( index );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MatchTarget(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.AvatarTarget>(L, 4)&& translator.Assignable<UnityEngine.MatchTargetWeightMask>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 matchPosition;translator.Get(L, 2, out matchPosition);
                    UnityEngine.Quaternion matchRotation;translator.Get(L, 3, out matchRotation);
                    UnityEngine.AvatarTarget targetBodyPart;translator.Get(L, 4, out targetBodyPart);
                    UnityEngine.MatchTargetWeightMask weightMask;translator.Get(L, 5, out weightMask);
                    float startNormalizedTime = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    __cl_gen_to_be_invoked.MatchTarget( matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.AvatarTarget>(L, 4)&& translator.Assignable<UnityEngine.MatchTargetWeightMask>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector3 matchPosition;translator.Get(L, 2, out matchPosition);
                    UnityEngine.Quaternion matchRotation;translator.Get(L, 3, out matchRotation);
                    UnityEngine.AvatarTarget targetBodyPart;translator.Get(L, 4, out targetBodyPart);
                    UnityEngine.MatchTargetWeightMask weightMask;translator.Get(L, 5, out weightMask);
                    float startNormalizedTime = (float)LuaAPI.lua_tonumber(L, 6);
                    float targetNormalizedTime = (float)LuaAPI.lua_tonumber(L, 7);
                    
                    __cl_gen_to_be_invoked.MatchTarget( matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime, targetNormalizedTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.MatchTarget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InterruptMatchTarget(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.InterruptMatchTarget(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool completeMatch = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.InterruptMatchTarget( completeMatch );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.InterruptMatchTarget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CrossFadeInFixedTime(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.CrossFadeInFixedTime( stateNameHash, transitionDuration );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.CrossFadeInFixedTime( stateNameHash, transitionDuration, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    float fixedTime = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.CrossFadeInFixedTime( stateNameHash, transitionDuration, layer, fixedTime );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.CrossFadeInFixedTime( stateName, transitionDuration );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.CrossFadeInFixedTime( stateName, transitionDuration, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    float fixedTime = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.CrossFadeInFixedTime( stateName, transitionDuration, layer, fixedTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.CrossFadeInFixedTime!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CrossFade(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.CrossFade( stateNameHash, transitionDuration );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.CrossFade( stateNameHash, transitionDuration, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    float normalizedTime = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.CrossFade( stateNameHash, transitionDuration, layer, normalizedTime );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.CrossFade( stateName, transitionDuration );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.CrossFade( stateName, transitionDuration, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    float transitionDuration = (float)LuaAPI.lua_tonumber(L, 3);
                    int layer = LuaAPI.xlua_tointeger(L, 4);
                    float normalizedTime = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.CrossFade( stateName, transitionDuration, layer, normalizedTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.CrossFade!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayInFixedTime(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.PlayInFixedTime( stateNameHash );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    int layer = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.PlayInFixedTime( stateNameHash, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    int layer = LuaAPI.xlua_tointeger(L, 3);
                    float fixedTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.PlayInFixedTime( stateNameHash, layer, fixedTime );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.PlayInFixedTime( stateName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    int layer = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.PlayInFixedTime( stateName, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    int layer = LuaAPI.xlua_tointeger(L, 3);
                    float fixedTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.PlayInFixedTime( stateName, layer, fixedTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.PlayInFixedTime!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.Play( stateNameHash );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    int layer = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.Play( stateNameHash, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int stateNameHash = LuaAPI.xlua_tointeger(L, 2);
                    int layer = LuaAPI.xlua_tointeger(L, 3);
                    float normalizedTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.Play( stateNameHash, layer, normalizedTime );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.Play( stateName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    int layer = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.Play( stateName, layer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string stateName = LuaAPI.lua_tostring(L, 2);
                    int layer = LuaAPI.xlua_tointeger(L, 3);
                    float normalizedTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.Play( stateName, layer, normalizedTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animator.Play!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTarget(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AvatarTarget targetIndex;translator.Get(L, 2, out targetIndex);
                    float targetNormalizedTime = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetTarget( targetIndex, targetNormalizedTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBoneTransform(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.HumanBodyBones humanBoneId;translator.Get(L, 2, out humanBoneId);
                    
                        UnityEngine.Transform __cl_gen_ret = __cl_gen_to_be_invoked.GetBoneTransform( humanBoneId );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartPlayback(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.StartPlayback(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StopPlayback(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.StopPlayback(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartRecording(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int frameCount = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.StartRecording( frameCount );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StopRecording(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.StopRecording(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layerIndex = LuaAPI.xlua_tointeger(L, 2);
                    int stateID = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasState( layerIndex, stateID );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StringToHash_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.Animator.StringToHash( name );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float deltaTime = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    __cl_gen_to_be_invoked.Update( deltaTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Rebind(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Rebind(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyBuiltinRootMotion(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.ApplyBuiltinRootMotion(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isOptimizable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isOptimizable);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isHuman(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isHuman);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasRootMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasRootMotion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_humanScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.humanScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isInitialized(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isInitialized);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deltaPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.deltaPosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deltaRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, __cl_gen_to_be_invoked.deltaRotation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.velocity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.angularVelocity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rootPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.rootPosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rootRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, __cl_gen_to_be_invoked.rootRotation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_applyRootMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.applyRootMotion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_linearVelocityBlending(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.linearVelocityBlending);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_updateMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.updateMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasTransformHierarchy(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasTransformHierarchy);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gravityWeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.gravityWeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bodyPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.bodyPosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bodyRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, __cl_gen_to_be_invoked.bodyRotation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stabilizeFeet(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.stabilizeFeet);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_layerCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.layerCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parameters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.parameters);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parameterCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.parameterCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_feetPivotActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.feetPivotActive);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pivotWeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.pivotWeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pivotPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.pivotPosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isMatchingTarget(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isMatchingTarget);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_speed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.speed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.targetPosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, __cl_gen_to_be_invoked.targetRotation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cullingMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cullingMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playbackTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.playbackTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_recorderStartTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.recorderStartTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_recorderStopTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.recorderStopTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_recorderMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.recorderMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_runtimeAnimatorController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.runtimeAnimatorController);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasBoundPlayables(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasBoundPlayables);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_avatar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.avatar);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playableGraph(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.playableGraph);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_layersAffectMassCenter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.layersAffectMassCenter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_leftFeetBottomHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.leftFeetBottomHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rightFeetBottomHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.rightFeetBottomHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_logWarnings(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.logWarnings);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fireEvents(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.fireEvents);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rootPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.rootPosition = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rootRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                UnityEngine.Quaternion __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.rootRotation = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_applyRootMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.applyRootMotion = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_linearVelocityBlending(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.linearVelocityBlending = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_updateMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                UnityEngine.AnimatorUpdateMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.updateMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bodyPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.bodyPosition = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bodyRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                UnityEngine.Quaternion __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.bodyRotation = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stabilizeFeet(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.stabilizeFeet = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_feetPivotActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.feetPivotActive = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_speed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.speed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cullingMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                UnityEngine.AnimatorCullingMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.cullingMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playbackTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.playbackTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_recorderStartTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.recorderStartTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_recorderStopTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.recorderStopTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_runtimeAnimatorController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.runtimeAnimatorController = (UnityEngine.RuntimeAnimatorController)translator.GetObject(L, 2, typeof(UnityEngine.RuntimeAnimatorController));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_avatar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.avatar = (UnityEngine.Avatar)translator.GetObject(L, 2, typeof(UnityEngine.Avatar));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_layersAffectMassCenter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.layersAffectMassCenter = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_logWarnings(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.logWarnings = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fireEvents(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animator __cl_gen_to_be_invoked = (UnityEngine.Animator)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fireEvents = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
