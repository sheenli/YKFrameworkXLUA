#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(UnityEngine.Application), UnityEngineApplicationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Screen), UnityEngineScreenWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SleepTimeout), UnityEngineSleepTimeoutWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Input), UnityEngineInputWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Physics), UnityEnginePhysicsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderSettings), UnityEngineRenderSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.QualitySettings), UnityEngineQualitySettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GL), UnityEngineGLWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Graphics), UnityEngineGraphicsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Random), UnityEngineRandomWrap.__Register);
				
				translator.DelayWrapLoader(typeof(EventDef), EventDefWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<string>), SystemCollectionsGenericList_1_SystemString_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<UnityEngine.Transform>), SystemCollectionsGenericList_1_UnityEngineTransform_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<UnityEngine.GameObject>), SystemCollectionsGenericList_1_UnityEngineGameObject_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<TaskBase>), SystemCollectionsGenericList_1_TaskBase_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<FairyGUI.Controller>), SystemCollectionsGenericList_1_FairyGUIController_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.Dictionary<string, string>), SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TrackedReference), UnityEngineTrackedReferenceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Collider), UnityEngineColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Texture), UnityEngineTextureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Texture2D), UnityEngineTexture2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Text), UnityEngineUITextWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Shader), UnityEngineShaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWW), UnityEngineWWWWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CameraClearFlags), UnityEngineCameraClearFlagsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioClip), UnityEngineAudioClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AssetBundle), UnityEngineAssetBundleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AsyncOperation), UnityEngineAsyncOperationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LightType), UnityEngineLightTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Animator), UnityEngineAnimatorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.KeyCode), UnityEngineKeyCodeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Space), UnityEngineSpaceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MeshRenderer), UnityEngineMeshRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MeshFilter), UnityEngineMeshFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Mesh), UnityEngineMeshWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.BoxCollider), UnityEngineBoxColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MeshCollider), UnityEngineMeshColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SphereCollider), UnityEngineSphereColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CharacterController), UnityEngineCharacterControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CapsuleCollider), UnityEngineCapsuleColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Animation), UnityEngineAnimationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationState), UnityEngineAnimationStateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationBlendMode), UnityEngineAnimationBlendModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.QueueMode), UnityEngineQueueModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PlayMode), UnityEnginePlayModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WrapMode), UnityEngineWrapModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.SceneManager), UnityEngineSceneManagementSceneManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.BlendWeights), UnityEngineBlendWeightsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderTexture), UnityEngineRenderTextureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PlayerPrefs), UnityEnginePlayerPrefsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AppConst), AppConstWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.EventContext), FairyGUIEventContextWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.EventDispatcher), FairyGUIEventDispatcherWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.EventListener), FairyGUIEventListenerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.InputEvent), FairyGUIInputEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.DisplayObject), FairyGUIDisplayObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Container), FairyGUIContainerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Stage), FairyGUIStageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Controller), FairyGUIControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GObject), FairyGUIGObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GGraph), FairyGUIGGraphWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GGroup), FairyGUIGGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GImage), FairyGUIGImageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GLoader), FairyGUIGLoaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUIGLoaderExtension), FairyGUIGLoaderExtensionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.PlayState), FairyGUIPlayStateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GMovieClip), FairyGUIGMovieClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.TextFormat), FairyGUITextFormatWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GTextField), FairyGUIGTextFieldWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GRichTextField), FairyGUIGRichTextFieldWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GTextInput), FairyGUIGTextInputWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.InputTextField), FairyGUIInputTextFieldWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GComponent), FairyGUIGComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GList), FairyGUIGListWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GRoot), FairyGUIGRootWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GLabel), FairyGUIGLabelWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GButton), FairyGUIGButtonWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GComboBox), FairyGUIGComboBoxWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GProgressBar), FairyGUIGProgressBarWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GSlider), FairyGUIGSliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.PopupMenu), FairyGUIPopupMenuWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.ScrollPane), FairyGUIScrollPaneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Transition), FairyGUITransitionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.UIPackage), FairyGUIUIPackageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Window), FairyGUIWindowWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GObjectPool), FairyGUIGObjectPoolWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Relations), FairyGUIRelationsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.RelationType), FairyGUIRelationTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Timers), FairyGUITimersWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.FontManager), FairyGUIFontManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GoWrapper), FairyGUIGoWrapperWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.CaptureCamera), FairyGUICaptureCameraWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.NTexture), FairyGUINTextureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.UIConfig), FairyGUIUIConfigWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenUtils), TweenUtilsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(EventDispatcherNode), EventDispatcherNodeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(EventData), EventDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(EventDataLua), EventDataLuaWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIMgr), UIMgrWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SceneBase), SceneBaseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(BaseUI), BaseUIWrap.__Register);
				
				translator.DelayWrapLoader(typeof(ResMgr), ResMgrWrap.__Register);
				
				translator.DelayWrapLoader(typeof(ABMgr), ABMgrWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LoadGroupProgress), LoadGroupProgressWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GroupProgress), GroupProgressWrap.__Register);
				
				translator.DelayWrapLoader(typeof(ResGroupLoadError), ResGroupLoadErrorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(ResLoadGroupEvent), ResLoadGroupEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GamUtil), GamUtilWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameMode), GameModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AsynTask), AsynTaskWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AutoLoadAsset), AutoLoadAssetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LoadGroup), LoadGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SceneLoadTask), SceneLoadTaskWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SceneMgr), SceneMgrWrap.__Register);
				
				translator.DelayWrapLoader(typeof(ComUtil), ComUtilWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GetGPSFinishEvent), GetGPSFinishEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GetGPSFinishEvent.GPSLocationInfo), GetGPSFinishEventGPSLocationInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFlag), GameFlagWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SoundMgr), SoundMgrWrap.__Register);
				
				translator.DelayWrapLoader(typeof(BGMMgr), BGMMgrWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Initialization), InitializationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RuntimePlatform), UnityEngineRuntimePlatformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LocationAddressResultData), LocationAddressResultDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LocationAddress), LocationAddressWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LocationAddressComponent), LocationAddressComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LuaMgr), LuaMgrWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.DynamicFont), FairyGUIDynamicFontWrap.__Register);
				
				translator.DelayWrapLoader(typeof(ABInfo), ABInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(VerInfo), VerInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(ComparisonInfo), ComparisonInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TaskBase), TaskBaseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(ParallelTask), ParallelTaskWrap.__Register);
				
				translator.DelayWrapLoader(typeof(StateMachine), StateMachineWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LocalGameCfgData), LocalGameCfgDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SystemInfo), UnityEngineSystemInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(RemotelyVersionInfo), RemotelyVersionInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(RemotelyVersionInfo.RemotelyInfo), RemotelyVersionInfoRemotelyInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DownAPKTask), DownAPKTaskWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameCfgMgr), GameCfgMgrWrap.__Register);
				
				translator.DelayWrapLoader(typeof(WXConstant), WXConstantWrap.__Register);
				
				translator.DelayWrapLoader(typeof(HotUpdateRessMgr), HotUpdateRessMgrWrap.__Register);
				
				translator.DelayWrapLoader(typeof(HotUpdateRessMgr.DecompressionOrDownInfo), HotUpdateRessMgrDecompressionOrDownInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.NGraphics), FairyGUINGraphicsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(YKSupportLua), YKSupportLuaWrap.__Register);
				
				translator.DelayWrapLoader(typeof(YKSupportLua.LuaSceneBase), YKSupportLuaLuaSceneBaseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(YKSupportLua.LuaStateBase), YKSupportLuaLuaStateBaseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(YKSupportLua.LuaTaskBase), YKSupportLuaLuaTaskBaseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(YKSupportLua.LuaUBBParser), YKSupportLuaLuaUBBParserWrap.__Register);
				
				translator.DelayWrapLoader(typeof(YKSupportLua.LuaWindow), YKSupportLuaLuaWindowWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GLuaComponent), FairyGUIGLuaComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GLuaButton), FairyGUIGLuaButtonWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GLuaComboBox), FairyGUIGLuaComboBoxWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GLuaLabel), FairyGUIGLuaLabelWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GLuaProgressBar), FairyGUIGLuaProgressBarWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GLuaSlider), FairyGUIGLuaSliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
				
				
				
				translator.AddInterfaceBridgeCreator(typeof(YKSupportLua.ILuaSceneBase), YKSupportLuaILuaSceneBaseBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(ITask), ITaskBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(IState), IStateBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(YKSupportLua.ILuaTaskBase), YKSupportLuaILuaTaskBaseBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(FairyGUI.LuaUIHelper.ILuaComponent), FairyGUILuaUIHelperILuaComponentBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(FairyGUI.ILuaWindow), FairyGUIILuaWindowBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(YKSupportLua.ILuaWindow), YKSupportLuaILuaWindowBridge.__Create);
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
