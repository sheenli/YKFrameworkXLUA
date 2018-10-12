
using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEditor;

using System.Reflection;
using FairyGUI;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using XLua;

public static class CustomSettings
{

    //导出时强制做为静态类的类型(注意customTypeList 还要添加这个类型才能导出)
    //unity 有些类作为sealed class, 其实完全等价于静态类

    [LuaCallCSharp]
    public static List<Type> staticClassTypes = new List<Type>
    {
        typeof(UnityEngine.Application),
        typeof(UnityEngine.Time),
        typeof(UnityEngine.Screen),
        typeof(UnityEngine.SleepTimeout),
        typeof(UnityEngine.Input),
        typeof(UnityEngine.Resources),
        typeof(UnityEngine.Physics),
        typeof(UnityEngine.RenderSettings),
        typeof(UnityEngine.QualitySettings),
        typeof(UnityEngine.GL),
        typeof(UnityEngine.Graphics),
        typeof(UnityEngine.Random),
        //typeof(UnityEngine.PlayerPrefs),
        typeof(EventDef),
        //typeof(YKSupportLua),

    };
    //附加导出委托类型(在导出委托时, customTypeList 中牵扯的委托类型都会导出， 无需写在这里)
    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>()
    {        
        typeof(Action),                
        typeof(UnityEngine.Events.UnityAction),
        typeof(System.Predicate<int>),
        typeof(System.Action<int>),
        typeof(System.Action<string>),
        typeof(System.Comparison<int>),
        typeof(System.Func<int, int>),
        
        typeof(EventCallback1),
        typeof(EventCallback0),
        typeof(EventDispatcherNode.EventListenerDele),
        typeof(System.Action<GetGPSFinishEvent.GPSLocationInfo>),

        typeof(Action<UnityEngine.Object>),
        typeof(Action<LocationAddressResultData>),
        typeof(Action<UnityEngine.AssetBundle>),
        typeof(Action<AsynTask>),
        typeof(Action<List<TaskBase>>),
        typeof(ListItemRenderer), 
        typeof(ListItemProvider),
        typeof(YKSupportLua.ILuaSceneBase),
        typeof(ITask),
        typeof(IState),
        typeof(YKSupportLua.ILuaTaskBase),
    };

    //在这里添加你要导出注册到lua的类型列表
    [LuaCallCSharp]
    public static List<Type> customTypeList = new List<Type>()
    {
        typeof(List<string>),
        typeof(List<int>),
        typeof(List<Transform>),
        typeof(List<GameObject>),
        typeof(List <TaskBase>),
        typeof(System.Collections.Generic.List<FairyGUI.Controller>),
        typeof(Dictionary<string, string>),
        //------------------------为例子导出--------------------------------
        //_GT(typeof(TestEventListener)),
        //_GT(typeof(TestProtol)),
        //_GT(typeof(TestAccount)),
        //_GT(typeof(Dictionary<int, TestAccount>)).SetLibName("AccountMap"),
        //_GT(typeof(KeyValuePair<int, TestAccount>)),
        //_GT(typeof(Dictionary<int, TestAccount>.KeyCollection)),
        //_GT(typeof(Dictionary<int, TestAccount>.ValueCollection)),
        //_GT(typeof(TestExport)),
        //_GT(typeof(TestExport.Space)),
        //-------------------------------------------------------------------           

//#if USING_DOTWEENING
//         _GT(typeof(DG.Tweening.DOTween)),
//         _GT(typeof(DG.Tweening.Tween)).SetBaseType(typeof(System.Object)).AddExtendType(typeof(DG.Tweening.TweenExtensions)),
//         _GT(typeof(DG.Tweening.Sequence)).AddExtendType(typeof(DG.Tweening.TweenSettingsExtensions)),
//         _GT(typeof(DG.Tweening.Tweener)).AddExtendType(typeof(DG.Tweening.TweenSettingsExtensions)),
//         _GT(typeof(DG.Tweening.LoopType)),
//         _GT(typeof(DG.Tweening.PathMode)),
//         _GT(typeof(DG.Tweening.PathType)),
//         _GT(typeof(DG.Tweening.RotateMode)),
//         _GT(typeof(Component)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
//         _GT(typeof(Transform)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
//         _GT(typeof(Light)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
//         _GT(typeof(Material)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
//         _GT(typeof(Rigidbody)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
//         _GT(typeof(Camera)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
//         _GT(typeof(AudioSource)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
//         //_GT(typeof(LineRenderer)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
//         //_GT(typeof(TrailRenderer)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),    
// 
//         
//         _GT(typeof(RawImage)),
//         _GT(typeof(EventTrigger)),//拖拽监听事件
//         _GT(typeof(PointerEventData)),
//         _GT(typeof(AxisEventData)),
//         _GT (typeof(DG.Tweening.Ease)),
//         _GT (typeof(DG.Tweening.AxisConstraint)),
//         _GT(typeof(AnimatorStateInfo)),
//        // _GT(typeof(DelegateFactory)),
//         _GT(typeof(Ray)),
//         _GT(typeof(RaycastHit)),

//#else
                                         
        //_GT(typeof(Component)),
        //_GT(typeof(Transform)),
        //_GT(typeof(Material)),
        //_GT(typeof(Light)),
        //_GT(typeof(Rigidbody)),
        //_GT(typeof(Camera)),
        //_GT(typeof(AudioSource)),
        //_GT(typeof(LineRenderer)),
        //_GT(typeof(TrailRenderer)),
//#endif
      
        typeof(Behaviour),
        typeof(MonoBehaviour),
        typeof(GameObject),
        typeof(TrackedReference),
        typeof(Application),
        typeof(Physics),
        typeof(Collider),
        typeof(Time),
        typeof(Texture),
        typeof(Texture2D),
        typeof(Text),
        typeof(Shader),
        typeof(Renderer),
        typeof(WWW),
        typeof(Screen),
        typeof(CameraClearFlags),
        typeof(AudioClip),
        typeof(AssetBundle),
        typeof(ParticleSystem),
        typeof(AsyncOperation),
        typeof(LightType),
        typeof(SleepTimeout),
#if UNITY_5_3_OR_NEWER && !UNITY_5_6_OR_NEWER
        _GT(typeof(UnityEngine.Experimental.Director.DirectorPlayer)),
#endif
        typeof(Animator),
        typeof(Input),
        typeof(KeyCode),
        typeof(SkinnedMeshRenderer),
        typeof(Space),

        typeof(MeshRenderer),
        typeof(MeshFilter),
        typeof(Mesh),
#if !UNITY_5_4_OR_NEWER
        typeof(ParticleEmitter),
        typeof(ParticleRenderer),
        typeof(ParticleAnimator), 
#endif

        typeof(BoxCollider),
        typeof(MeshCollider),
        typeof(SphereCollider),
        typeof(CharacterController),
        typeof(CapsuleCollider),

        typeof(Animation),
        typeof(UnityEngine.Object),
        typeof(AnimationClip),
        typeof(AnimationState),
        typeof(AnimationBlendMode),
        typeof(QueueMode),
        typeof(PlayMode),
        typeof(WrapMode),
        //_GT(typeof(Handheld)),
        typeof(UnityEngine.SceneManagement.SceneManager),


        typeof(QualitySettings),
        typeof(RenderSettings),
        typeof(BlendWeights),
        typeof(RenderTexture),
        typeof(Resources),

        typeof(PlayerPrefs),
        typeof(AppConst),
        typeof(EventContext),
        typeof(EventDispatcher),
        typeof(EventListener),
        typeof(InputEvent),
        typeof(DisplayObject),
        typeof(Container),
        typeof(Stage),
        typeof(Controller),
        typeof(GObject),
        typeof(GGraph),
        typeof(GGroup),
        typeof(GImage),
        typeof(GLoader),
        typeof(FairyGUIGLoaderExtension),
        typeof(PlayState),
        typeof(GMovieClip),
        typeof(TextFormat),
        typeof(GTextField),
        typeof(GRichTextField),
        typeof(GTextInput),
        typeof(InputTextField),
        typeof(GComponent),
        typeof(GList),
        typeof(GRoot),
        typeof(GLabel),
        typeof(GButton),
        typeof(GComboBox),
        typeof(GProgressBar),
        typeof(GSlider),
        typeof(PopupMenu),
        typeof(ScrollPane),
        typeof(Transition),
        typeof(UIPackage),
        typeof(Window),
        typeof(GObjectPool),
        typeof(Relations),
        typeof(RelationType),
        typeof(Timers),
        typeof(FontManager),
        typeof(GoWrapper),
        typeof(FairyGUI.CaptureCamera),

        typeof(NTexture),
        typeof(UIConfig),
        typeof(TweenUtils),
        typeof(EventDef),
        typeof(EventDispatcherNode),
        typeof(EventData),
        typeof(EventDataLua),
        typeof(UIMgr),
        typeof(SceneBase),
        typeof(BaseUI),
        typeof(ResMgr),
        typeof(ABMgr),
        typeof(LoadGroupProgress),
        typeof(GroupProgress),
        typeof(ResGroupLoadError),
        typeof(ResLoadGroupEvent),
        typeof(GamUtil),
        typeof(GameMode),
        typeof(AsynTask),
        typeof(AutoLoadAsset),
        typeof(LoadGroup),
        typeof(SceneLoadTask),
        typeof(SceneMgr),
        typeof(ComUtil),
        typeof(GetGPSFinishEvent),
        typeof(GetGPSFinishEvent.GPSLocationInfo),
        typeof(GameFlag),
        typeof(SoundMgr),
        typeof(BGMMgr),
        typeof(Initialization),
        typeof(RuntimePlatform),
        typeof(LocationAddressResultData),
        typeof(LocationAddress),
        typeof(LocationAddressComponent),
        typeof(LuaMgr),
        typeof(FairyGUI.DynamicFont),
        typeof(ABInfo),
        typeof(VerInfo),
        typeof(ComparisonInfo),
        typeof(TaskBase),
        typeof(ParallelTask),
        typeof(StateMachine),
        typeof(LocalGameCfgData),
        typeof(SystemInfo),
        typeof(RemotelyVersionInfo),
        typeof(RemotelyVersionInfo.RemotelyInfo),
        typeof(DownAPKTask),
        typeof(GameCfgMgr),
        typeof(WXConstant),
        typeof(HotUpdateRessMgr),
        typeof(HotUpdateRessMgr.DecompressionOrDownInfo),
        typeof(NGraphics),
        typeof(YKSupportLua),
        typeof(YKSupportLua.LuaSceneBase),
        typeof(YKSupportLua.LuaStateBase),
        typeof(YKSupportLua.LuaTaskBase),
        typeof(YKSupportLua.LuaUBBParser),
        typeof(YKSupportLua.LuaWindow),
        typeof(GLuaComponent),
        typeof(GLuaButton),
        typeof(GLuaComboBox),
        typeof(GLuaLabel),
        typeof(GLuaProgressBar),
        typeof(GLuaSlider),
        typeof(TextAsset)
    };

    public static List<Type> dynamicList = new List<Type>()
    {
        typeof(MeshRenderer),
#if !UNITY_5_4_OR_NEWER
        typeof(ParticleEmitter),
        typeof(ParticleRenderer),
        typeof(ParticleAnimator),
#endif

        typeof(BoxCollider),
        typeof(MeshCollider),
        typeof(SphereCollider),
        typeof(CharacterController),
        typeof(CapsuleCollider),

        typeof(Animation),
        typeof(AnimationClip),
        typeof(AnimationState),

        typeof(BlendWeights),
        typeof(RenderTexture),
        typeof(Rigidbody),
    };

    //重载函数，相同参数个数，相同位置out参数匹配出问题时, 需要强制匹配解决
    //使用方法参见例子14
    public static List<Type> outList = new List<Type>()
    {
        
    };
        
    //ngui优化，下面的类没有派生类，可以作为sealed class
    public static List<Type> sealedList = new List<Type>()
    {
        typeof(Transform),
        typeof(UIMgr),
        typeof(ResMgr),
        typeof(ABMgr),
        typeof(GRoot),
        /*typeof(Transform),
        typeof(UIRoot),
        typeof(UICamera),
        typeof(UIViewport),
        typeof(UIPanel),
        typeof(UILabel),
        typeof(UIAnchor),
        typeof(UIAtlas),
        typeof(UIFont),
        typeof(UITexture),
        typeof(UISprite),
        typeof(UIGrid),
        typeof(UITable),
        typeof(UIWrapGrid),
        typeof(UIInput),
        typeof(UIScrollView),
        typeof(UIEventListener),
        typeof(UIScrollBar),
        typeof(UICenterOnChild),
        typeof(UIScrollView),        
        typeof(UIButton),
        typeof(UITextList),
        typeof(UIPlayTween),
        typeof(UIDragScrollView),
        typeof(UISpriteAnimation),
        typeof(UIWrapContent),
        typeof(TweenWidth),
        typeof(TweenAlpha),
        typeof(TweenColor),
        typeof(TweenRotation),
        typeof(TweenPosition),
        typeof(TweenScale),
        typeof(TweenHeight),
        typeof(TypewriterEffect),
        typeof(UIToggle),
        typeof(Localization),*/
    };


//     [MenuItem("Lua/Attach Profiler", false, 151)]
//     static void AttachProfiler()
//     {
//         if (!Application.isPlaying)
//         {
//             EditorUtility.DisplayDialog("警告", "请在运行时执行此功能", "确定");
//             return;
//         }
// 
//         LuaClient.Instance.AttachProfiler();
//     }
// 
//     [MenuItem("Lua/Detach Profiler", false, 152)]
//     static void DetachProfiler()
//     {
//         if (!Application.isPlaying)
//         {            
//             return;
//         }
// 
//         LuaClient.Instance.DetachProfiler();
//     }
}