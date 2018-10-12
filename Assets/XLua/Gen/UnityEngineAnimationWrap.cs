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
    public class UnityEngineAnimationWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Animation);
			Utils.BeginObjectRegister(type, L, translator, 0, 15, 7, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Stop", _m_Stop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rewind", _m_Rewind);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Sample", _m_Sample);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsPlaying", _m_IsPlaying);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", _m_Play);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CrossFade", _m_CrossFade);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Blend", _m_Blend);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CrossFadeQueued", _m_CrossFadeQueued);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PlayQueued", _m_PlayQueued);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddClip", _m_AddClip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveClip", _m_RemoveClip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetClipCount", _m_GetClipCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SyncLayer", _m_SyncLayer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", _m_GetEnumerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetClip", _m_GetClip);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "clip", _g_get_clip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playAutomatically", _g_get_playAutomatically);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wrapMode", _g_get_wrapMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPlaying", _g_get_isPlaying);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "animatePhysics", _g_get_animatePhysics);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cullingType", _g_get_cullingType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localBounds", _g_get_localBounds);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "clip", _s_set_clip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playAutomatically", _s_set_playAutomatically);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wrapMode", _s_set_wrapMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "animatePhysics", _s_set_animatePhysics);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cullingType", _s_set_cullingType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localBounds", _s_set_localBounds);
            
			
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
					
					UnityEngine.Animation __cl_gen_ret = new UnityEngine.Animation();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animation constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Stop(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Stop(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.Stop( name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animation.Stop!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Rewind(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Rewind(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.Rewind( name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animation.Rewind!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Sample(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Sample(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsPlaying(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsPlaying( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Play(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.PlayMode>(L, 2)) 
                {
                    UnityEngine.PlayMode mode;translator.Get(L, 2, out mode);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Play( mode );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Play( animation );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.PlayMode>(L, 3)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.PlayMode mode;translator.Get(L, 3, out mode);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Play( animation, mode );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animation.Play!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CrossFade(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.CrossFade( animation );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    float fadeLength = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.CrossFade( animation, fadeLength );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.PlayMode>(L, 4)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    float fadeLength = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.PlayMode mode;translator.Get(L, 4, out mode);
                    
                    __cl_gen_to_be_invoked.CrossFade( animation, fadeLength, mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animation.CrossFade!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Blend(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.Blend( animation );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    float targetWeight = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.Blend( animation, targetWeight );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    float targetWeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float fadeLength = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.Blend( animation, targetWeight, fadeLength );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animation.Blend!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CrossFadeQueued(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.AnimationState __cl_gen_ret = __cl_gen_to_be_invoked.CrossFadeQueued( animation );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    float fadeLength = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.AnimationState __cl_gen_ret = __cl_gen_to_be_invoked.CrossFadeQueued( animation, fadeLength );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueueMode>(L, 4)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    float fadeLength = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.QueueMode queue;translator.Get(L, 4, out queue);
                    
                        UnityEngine.AnimationState __cl_gen_ret = __cl_gen_to_be_invoked.CrossFadeQueued( animation, fadeLength, queue );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueueMode>(L, 4)&& translator.Assignable<UnityEngine.PlayMode>(L, 5)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    float fadeLength = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.QueueMode queue;translator.Get(L, 4, out queue);
                    UnityEngine.PlayMode mode;translator.Get(L, 5, out mode);
                    
                        UnityEngine.AnimationState __cl_gen_ret = __cl_gen_to_be_invoked.CrossFadeQueued( animation, fadeLength, queue, mode );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animation.CrossFadeQueued!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayQueued(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.AnimationState __cl_gen_ret = __cl_gen_to_be_invoked.PlayQueued( animation );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.QueueMode>(L, 3)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.QueueMode queue;translator.Get(L, 3, out queue);
                    
                        UnityEngine.AnimationState __cl_gen_ret = __cl_gen_to_be_invoked.PlayQueued( animation, queue );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.QueueMode>(L, 3)&& translator.Assignable<UnityEngine.PlayMode>(L, 4)) 
                {
                    string animation = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.QueueMode queue;translator.Get(L, 3, out queue);
                    UnityEngine.PlayMode mode;translator.Get(L, 4, out mode);
                    
                        UnityEngine.AnimationState __cl_gen_ret = __cl_gen_to_be_invoked.PlayQueued( animation, queue, mode );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animation.PlayQueued!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddClip(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.AnimationClip>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.AnimationClip clip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
                    string newName = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.AddClip( clip, newName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.AnimationClip>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.AnimationClip clip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
                    string newName = LuaAPI.lua_tostring(L, 3);
                    int firstFrame = LuaAPI.xlua_tointeger(L, 4);
                    int lastFrame = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.AddClip( clip, newName, firstFrame, lastFrame );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.AnimationClip>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.AnimationClip clip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
                    string newName = LuaAPI.lua_tostring(L, 3);
                    int firstFrame = LuaAPI.xlua_tointeger(L, 4);
                    int lastFrame = LuaAPI.xlua_tointeger(L, 5);
                    bool addLoopFrame = LuaAPI.lua_toboolean(L, 6);
                    
                    __cl_gen_to_be_invoked.AddClip( clip, newName, firstFrame, lastFrame, addLoopFrame );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animation.AddClip!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveClip(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.AnimationClip>(L, 2)) 
                {
                    UnityEngine.AnimationClip clip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
                    
                    __cl_gen_to_be_invoked.RemoveClip( clip );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string clipName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.RemoveClip( clipName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Animation.RemoveClip!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetClipCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetClipCount(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SyncLayer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int layer = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.SyncLayer( layer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumerator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked.GetEnumerator(  );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetClip(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.AnimationClip __cl_gen_ret = __cl_gen_to_be_invoked.GetClip( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.clip);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playAutomatically(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.playAutomatically);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wrapMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineWrapMode(L, __cl_gen_to_be_invoked.wrapMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isPlaying(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isPlaying);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_animatePhysics(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.animatePhysics);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cullingType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cullingType);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_localBounds(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineBounds(L, __cl_gen_to_be_invoked.localBounds);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.clip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playAutomatically(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.playAutomatically = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wrapMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                UnityEngine.WrapMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.wrapMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_animatePhysics(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.animatePhysics = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cullingType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                UnityEngine.AnimationCullingType __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.cullingType = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_localBounds(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Animation __cl_gen_to_be_invoked = (UnityEngine.Animation)translator.FastGetCSObj(L, 1);
                UnityEngine.Bounds __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.localBounds = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
