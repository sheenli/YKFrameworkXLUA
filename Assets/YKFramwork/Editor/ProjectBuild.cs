using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.IO;
using System;


public class ProjectBuild
{
    /// <summary>
    /// 所有要打包的场景
    /// </summary>
    /// <value>The get build scenes.</value>
    static string[] GetBuildScenes
    {
        get
        {
            List<string> list = new List<string>();
            foreach (EditorBuildSettingsScene es in EditorBuildSettings.scenes)
            {
                if (es != null && es.enabled)
                {
                    string fileName = Path.GetFileNameWithoutExtension(es.path);
                    if (!fileName.Contains("Transfer"))
                    {
                        list.Add(es.path);
                    }
                }
            }
            return list.ToArray();
        }
    }
    static string[] GetTransBuildScenes
    {
        get
        {
            List<string> list = new List<string>();
            foreach (EditorBuildSettingsScene es in EditorBuildSettings.scenes)
            {
                if (es != null && es.enabled)
                {
                    string fileName = Path.GetFileNameWithoutExtension(es.path);
                    if (fileName.Contains("Transfer"))
                    {
                        list.Add(es.path);
                    }
                    
                    //list.Add(es.path);
                }
                    
            }
            return list.ToArray();
        }
    }

    static Dictionary<string,bool> buildGames
    {
        get
        {
            Dictionary<string, bool> dic = new Dictionary<string, bool>();
            string[] strs = System.Environment.GetCommandLineArgs();
            foreach (string str in strs)
            {
                if (str.StartsWith("buildgmaes"))
                {
                    string buildgmaes = str.Replace("buildgmaes=", "");
                    string[] builds = buildgmaes.Split('|');//.Replace("version=", "");
                   foreach (string build in builds)
                   {
                        string[] bs = build.Split('=');
                        dic[bs[0]] = bool.Parse(bs[1]);
                   }
                }
            }
            return dic;
        }
    }

    static BuildTargetGroup CurrenBuildTarget
    {
        get
        {
            string[] strs = System.Environment.GetCommandLineArgs();
            foreach (string str in strs)
            {
                if (str.StartsWith("type"))
                {
                    string stra = str.Replace("type=", "");

                    switch (stra)
                    {
                        case "AND":
                            return BuildTargetGroup.Android;
                        case "IOS":
                            return BuildTargetGroup.iOS;
                        default:
                            return BuildTargetGroup.Android;
                    }
                }
            }
            return BuildTargetGroup.Android;
        }
    }

    private static string mDefVersion = "9.0.0";
	public static string version
    {
        get
        {
            string[] strs = System.Environment.GetCommandLineArgs();
            foreach (string str in strs)
            {
                if (str.StartsWith("version"))
                {
                    return str.Replace("version=", "");
                }

            }
            return mDefVersion;
        }
    }

    private static string mInstallVersion = "1.0.0";
    public static string InstallVersion
    {
        get
        {
            string[] strs = System.Environment.GetCommandLineArgs();
            foreach (string str in strs)
            {
                if (str.StartsWith("InstallVersion"))
                {
                    return str.Replace("InstallVersion=", "");
                }

            }
            return mInstallVersion;
        }
    }

    /// <summary>
    /// 获取资源版本号
    /// </summary>
    /// <returns></returns>
    public static string Getversion(string resName)
    {
        return version;
    }

    private static bool misPublic = false;
    /// <summary>
    /// 是否是发布版本
    /// </summary>
    public static bool isPublic
    {
        get
        {
            string[] strs = System.Environment.GetCommandLineArgs();
            foreach (string str in strs)
            {
                if (str.StartsWith("ispublic"))
                {
					return bool.Parse(str.Replace("ispublic=", ""));
                }

            }
            return misPublic;
        }
    }

    /// <summary>
    /// 生成到到路径
    /// </summary>
    /// <value>The outpath.</value>
    static string outpath
    {
        get
        {
            string[] strs = System.Environment.GetCommandLineArgs();
            foreach (string str in strs)
            {
                if (str.StartsWith("outpath"))
                {
                    return str.Replace("outpath=", "");
                }
            }
            string url = Path.GetFullPath(Application.dataPath + "/../Release");
#if UNITY_IOS
            return url+"/pro";
#elif UNITY_ANDROID
            return url + "/1.apk";
#else
            return url +"/1.exe";
#endif
        }
    }
    

    public enum ChannelType
    {
        Other = 1,
        AppStore,
    }

    public enum CollectionType
    {
        DSMJ = 8002,
        SQMJ = 8003,
        PXMJ = 8004,
        TEST = 1001,
    }

    static bool Trans
    {
        get
        {
            string[] strs = System.Environment.GetCommandLineArgs();
            foreach (string str in strs)
            {
                if (str.StartsWith("Trans"))
                {
                    string channelStr = str.Replace("Trans=", "");
                    return bool.Parse(channelStr);
                }
            }
            return false;
        }
    }
    static CollectionType currentCollection
    {
        get
        {
            string[] strs = System.Environment.GetCommandLineArgs();
            foreach (string str in strs)
            {
                if (str.StartsWith("Collection"))
                {
                    string channelStr = str.Replace("Collection=", "");
                    CollectionType type =(CollectionType)Enum.Parse(typeof(CollectionType), channelStr);
                    return type;
                }
            }
            return CollectionType.TEST;
        }
    }

    /// <summary>
    /// 渠道类型
    /// </summary>
    static int Channel
    {
        get
        {
           
            string[] strs = System.Environment.GetCommandLineArgs();
            foreach (string str in strs)
            {
                if (str.StartsWith("channel"))
                {
                    string channelStr = str.Replace("channel=", "");
                    if(channelStr == "Other")
                    {
                        return (int)ChannelType.Other;
                    }
                    else if (channelStr == "AppStore")
                    {
                        return (int)ChannelType.AppStore;
                    }
                }
            }
            return (int)ChannelType.Other;
        }
    }

    public static void ClearLuaFiles()
    {
#if USETOLUA
        ToLuaMenu.ClearLuaFiles();
#endif
    }

    public static void GenLuaAll()
    {
#if USETOLUA
        ToLuaMenu.GenLuaAll();
#endif
    }



    //[UnityEditor.MenuItem("Tools/bulid")]
    public static void BuildProjected()
    {
        Debug.LogError("生成AB");
        string assetName = Trans ? (int)currentCollection + "Trans" : (int)currentCollection+"";
        assetName += ".asset";
        BuildCollectionResInfo builfCfg = null;
        string buildCfgpath = "Assets/YKFramwork/Editor/BuildAbInfo/Collections/"
            + assetName;
        builfCfg = AssetDatabase.LoadAssetAtPath<BuildCollectionResInfo>(buildCfgpath);
        if (builfCfg == null)
        {
            Debug.LogError("加载不到builfCfg"+ buildCfgpath+"/ccc="+currentCollection);
            return;
        }

        if (builfCfg)
        {
            SetIconAndBg(builfCfg);
            SetUmengXinXI(builfCfg);
            builfCfg.Build();
        }

        Debug.Log("生成ab完成");
        BuildAB.BuildResIni();
        Debug.Log("准备生成APK");
        //BuildAB.BuildAb();
        if (CurrenBuildTarget == BuildTargetGroup.Android)
        {
            BuildForAndroid(builfCfg);
        }
        else if (CurrenBuildTarget == BuildTargetGroup.iOS)
        {
            BuildForIos(builfCfg);
        }
        else if (CurrenBuildTarget == BuildTargetGroup.Standalone)
        {

        }

        
    }

    public static void BuildPCALL(string ver,bool ispublic,BuildCollectionResInfo build)
    {
        
        mDefVersion = ver;
        misPublic = ispublic;
//         Initialization core = GameObject.Find("GameCore").GetComponent<Initialization>();
//         core.DebugMode = false;
        SetIconAndBg(build);
        build.Build();
#if UNITY_IOS
        BuildForIos(build);
#elif UNITY_ANDROID
        BuildForAndroid(build);
#else
        Debug.LogError(outpath);
        BuildPipeline.BuildPlayer(GetBuildScenes, outpath , BuildTarget.StandaloneWindows64, BuildOptions.None);
#endif
        //core.DebugMode = true;
        System.Diagnostics.Process.Start("explorer", outpath.Substring(0, outpath.LastIndexOf("/")));
    }


    public static void DelectDir(string srcPath)
    {
        try
        {
            DirectoryInfo dir = new DirectoryInfo(srcPath);
            FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
            foreach (FileSystemInfo i in fileinfo)
            {
                if (i is DirectoryInfo)            //判断是否文件夹
                {
                    DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                    subdir.Delete(true);          //删除子目录和文件
                }
                else
                {
                    File.Delete(i.FullName);      //删除指定文件
                }
            }
        }
        catch (Exception e)
        {
            throw;
        }
    }


    public static void BuildGameAB(List<string> list)
    {
        foreach (string str in list)
        {
            BuildResInfo build = AssetDatabase.LoadAssetAtPath<BuildResInfo>("Assets/YKFramwork/Editor/BuildAbInfo/" + str + ".asset");
            if (build == null)
            {
                Debug.LogError("生成资源失败：" + str);
            }
            build.Build(2);
        }
    }
    [MenuItem("Tools/Test")]
    public static void BuildDSMJ()
    {
        System.Type type = typeof(System.Collections.Generic.Dictionary<string,string>);
        Debug.LogError(type.FullName);
        //mBuildHall = true;
        //mIsBuilddsmj = true;
        //         string path = "Assets/YKFramwork/Editor/BuildAbInfo/Collections/" + 8002 + ".asset";
        //         BuildCollectionResInfo builfCfg = AssetDatabase.LoadAssetAtPath<BuildCollectionResInfo>(path);
        //         SetUmengXinXI(builfCfg);
    }

    public static void GetLuas(List<string> list,ref List<string> luas,ref List<string> abs)
    {
        foreach (string str in list)
        {
            BuildResInfo build = AssetDatabase.LoadAssetAtPath<BuildResInfo>("Assets/YKFramwork/Editor/BuildAbInfo/" 
                + str + ".asset");
            if (!luas.Contains(build.LuaABName))
            {
                luas.Add(build.LuaABName);
            }
            if (!abs.Contains(build.ResName))
            {
                abs.Add(build.ResName);
            }
        }
    }

    public static void BuildForAndroid(BuildCollectionResInfo buildInfo)
    {
        Debug.LogError("BuildForAndroid>>start");
        SetBaseMainnifestXml(buildInfo);
        SetUPushMainnifestxml(buildInfo);
        PlayerSettings.Android.useAPKExpansionFiles = false;
        PlayerSettings.Android.keystoreName = Application.dataPath + "/../xlkj.keystore";
        PlayerSettings.Android.keyaliasPass = "xlkj13nk";
        PlayerSettings.Android.keystorePass = "xlkj13nk";
        PlayerSettings.Android.keyaliasName = "yanshi";
        
        PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, buildInfo.AndroidPackageName);
        string[] scenes = null;
        if (buildInfo.isTrans)
        {
            scenes = GetTransBuildScenes;
            PlayerSettings.Android.targetSdkVersion = AndroidSdkVersions.AndroidApiLevelAuto;
        }
        else
        {
            scenes = GetBuildScenes;
            PlayerSettings.Android.targetSdkVersion = AndroidSdkVersions.AndroidApiLevel22;
        }
        string res = BuildPipeline.BuildPlayer(scenes, outpath, BuildTarget.Android, BuildOptions.None);
        Debug.Log("生成完成"+ res);
        Debug.LogError("BuildForAndroid>>end");

    }

#region 设置xml信息
  public static void SetUPushMainnifestxml(BuildCollectionResInfo buildInfo)
    {
        string mainnifestRoot = Application.dataPath + "/Plugins/Android/push.plugin/AndroidManifest.xml";
        string mainnifestMode = Application.dataPath + "/../AndroidXMLMode/UpushManifest.xml";
        
        string mainnifestxml = File.ReadAllText(mainnifestMode);
        Debug.LogError("SetUPushMainnifestxml-> mainnifestxml="+ mainnifestxml);
        mainnifestxml = mainnifestxml
            .Replace("${applicationId}", buildInfo.AndroidPackageName);
            
        Debug.LogError("SetUPushMainnifestxml-> Replace =" + mainnifestxml);

        File.WriteAllText(mainnifestRoot, mainnifestxml);
    }

    public static void SetBaseMainnifestXml(BuildCollectionResInfo buildInfo)
    {
        string appid = WXConstant.UMengAppID[buildInfo.CollectionID];
        string Secret = WXConstant.UMengPushSecret[buildInfo.CollectionID];
        string xlAppId = WXConstant.XLAppID[buildInfo.CollectionID];
        string channelstr = ((ChannelType)Channel).ToString();
        string mainnifestRoot = Application.dataPath + "/Plugins/Android/AndroidManifest.xml";
        string mainnifestMode = Application.dataPath + "/../AndroidXMLMode/AndroidManifest.xml";
        string mainnifestxml = File.ReadAllText(mainnifestMode);
        mainnifestxml = mainnifestxml.Replace("#packageName#", buildInfo.AndroidPackageName)
                                     .Replace("#UMENG_APPKEY", appid)
                                     .Replace("#UMENG_MESSAGE_SECRET", Secret)
                                     .Replace("#UMENG_CHANNEL", channelstr)
                                     .Replace("#JUMPALIPAYSCHEME", buildInfo.jumpScheme)
                                     .Replace("#XLAPPID", xlAppId);
                                
        File.WriteAllText(mainnifestRoot, mainnifestxml);
    }
#endregion

#region 设置umeng信息
    private class UMConstantInfo
    {
        public string appid;
        public string secret;
        public string channelid;// = channelstr
    }
    public static void SetUmengXinXI(BuildCollectionResInfo buildInfo)
    {
        string appid = WXConstant.UMengAppID[buildInfo.CollectionID];
        string Secret = WXConstant.UMengPushSecret[buildInfo.CollectionID];
        string channelstr = ((ChannelType)Channel).ToString();
        UMConstantInfo uMConstantInfo = new UMConstantInfo();
        uMConstantInfo.appid = appid;
        uMConstantInfo.secret = Secret;
        uMConstantInfo.channelid = channelstr;
        string json= JsonUtility.ToJson(uMConstantInfo);
        File.WriteAllText(Application.streamingAssetsPath + "/UMConstant.json", json);
    }
#endregion
    public static void BuildForIos(BuildCollectionResInfo buildCfg)
    {
        string assetName = (int)currentCollection + "";
        if (buildCfg.isTrans)
        {
            assetName += "Trans";
        }
        else
        {
            if(Channel == (int)ChannelType.AppStore)
            {
                assetName += "Appstore";
            }
        }
        assetName += ".asset";
        LocalGameCfgData localdata = Resources.Load<LocalGameCfgData>("gamecfg");
        string installUrl = localdata.OSSROOT + "/{0}/{1}/{2}/{3}/ios/1.ipa";
        string verTypeStr = "";
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.iOS, ScriptingImplementation.IL2CPP);
        PlayerSettings.SetArchitecture(BuildTargetGroup.iOS, 2);
        if (Channel == (int)ChannelType.AppStore)
        {
            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.iOS, buildCfg.IOSAppStorePackName);
        }
        else
        {
            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.iOS, buildCfg.IOSPackName);
        }
        PlayerSettings.iOS.appInBackgroundBehavior = iOSAppInBackgroundBehavior.Custom;
        PlayerSettings.iOS.backgroundModes = iOSBackgroundMode.Audio|iOSBackgroundMode.RemoteNotification;


        if (isPublic)
        {
            verTypeStr = "public";
        }
        else
        {
            verTypeStr = "test";
        }

        installUrl = string.Format(installUrl, buildCfg.CollectionID, Channel, verTypeStr, version);

        string txt = File.ReadAllText(Application.dataPath + "/YKFramwork/Editor/AutoBuild/Install.plist");
        txt = txt.Replace("#{url}#", installUrl)
            .Replace("#version#", InstallVersion)
            .Replace("#iconurl#", localdata.OSSROOT+"/"+ buildCfg.CollectionID+ "/icon.png")
            .Replace("#PackName#", buildCfg.IOSPackName)
            .Replace("#GameName#",buildCfg.CollectionName);

        File.WriteAllText(Application.streamingAssetsPath + "/Install.plist",
            txt);
        string[] scenes = null;
        if(buildCfg.isTrans)
        {
            scenes = GetTransBuildScenes;
        }
        else
        {
            scenes = GetBuildScenes;
        }

#if UNITY_IOS
        PlayerPrefs.SetString(XcodeProjectUpdater.SETTING_DATA_PATHKEY, "Assets/YKFramwork/Editor/AutoBuild/" + assetName);
        PlayerSettings.iOS.allowHTTPDownload = true;
        PlayerSettings.iOS.appleEnableAutomaticSigning = false;
        string res = BuildPipeline.BuildPlayer(scenes, outpath, BuildTarget.iOS, BuildOptions.None);
#endif
    }

    public static void SetLocalGameCfg (BuildCollectionResInfo buildInfo)
    {
        LocalGameCfgData localdata = Resources.Load<LocalGameCfgData>("gamecfg");
        localdata.chanelType = Channel;
        localdata.isPublic = isPublic;
        localdata.collectionID = buildInfo.CollectionID;
        EditorUtility.SetDirty(localdata);
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// 设置背景图和icon
    /// </summary>
    /// <param name="collectionID">合集id</param>
    //[MenuItem("Tools/setIcon")]
    public static void SetIconAndBg(BuildCollectionResInfo buildInfo)
    {
        PlayerSettings.Android.targetSdkVersion = AndroidSdkVersions.AndroidApiLevelAuto;
        PlayerSettings.bundleVersion = InstallVersion;
        PlayerSettings.SplashScreen.show = false;
        PlayerSettings.stripEngineCode = false;
        PlayerSettings.defaultInterfaceOrientation = UIOrientation.AutoRotation;

        PlayerSettings.allowedAutorotateToLandscapeLeft = true;
        PlayerSettings.allowedAutorotateToLandscapeRight = true;
        PlayerSettings.allowedAutorotateToPortrait = false;
        PlayerSettings.allowedAutorotateToPortraitUpsideDown = false;

        PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.Android, true);
        PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.iOS, true);

        int collectionID = buildInfo.CollectionID;
        string root = Application.dataPath +"/CollectionEeefctRes";
        string iconRoot = root + "/Icon/"+ collectionID + ".png";
        if (buildInfo.isTrans)
        {
            iconRoot = root + "/Icon/dataIcon.jpg";
        }
        string sharethumbPath = root + "/sharethumb/"+ collectionID+".png";
        string HallBgPath = root + "/HallBg/" + collectionID + ".png";
        string LoginBgPath = root + "/LoginBg/" + collectionID + ".png";
        string LogoPath = root + "/Logos/" + collectionID + ".png";

        string umeng_push_notification_default_large_iconpath 
            = root + "/umengpushicon/64/"+ + collectionID + ".png";

        string umeng_push_notification_default_small_iconpath 
            = root + "/umengpushicon/48/" + +collectionID + ".png";

        Texture2D icon = AssetDatabase.LoadAssetAtPath<Texture2D>(FileUtil.GetProjectRelativePath(iconRoot));
        Texture2D[] androidIcons = new Texture2D[6];
        for (int i = 0; i < androidIcons.Length; i++)
        {
            androidIcons[i] = icon;
        }
        Texture2D[] iosIcons = new Texture2D[18];
        for (int i = 0;i< iosIcons.Length;i++)
        {
            iosIcons[i] = icon;
        }
        Texture2D[] pcIcons = new Texture2D[7];
        for (int i = 0;i< pcIcons.Length;i++)
        {
            pcIcons[i] = icon;
        }
        //AssetDatabase.CopyAsset()
        File.Copy(sharethumbPath, Application.streamingAssetsPath + "/sharethumb.png",true);
        //File.Copy(HallBgPath, AppConst.ABPath + "/Hall/HallScene/HallScencePack@atlas_llpny8.png",true);
        //File.Copy(LoginBgPath, AppConst.ABPath + "/Hall/loadingsceneres/LoadingScenePack@atlas_hl1kcw.png",true);
        File.Copy(LogoPath, AppConst.ABPath + "/Hall/loadingsceneres/LoadingScenePack@atlas_jkp87.png", true);
        File.Copy(umeng_push_notification_default_large_iconpath
            , Application.dataPath
            + "/Plugins/Android/res/drawable/umeng_push_notification_default_large_icon.png", 
            true);
        File.Copy(umeng_push_notification_default_small_iconpath
           , Application.dataPath
           + "/Plugins/Android/res/drawable/umeng_push_notification_default_small_icon.png",
           true);
        PlayerSettings.productName = buildInfo.CollectionName;
        PlayerSettings.companyName = "闲游棋牌";
        PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Standalone, pcIcons);
        PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Android, androidIcons);
        PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.iOS, iosIcons);
        AssetDatabase.Refresh();
    }
}

public class BuildPC : EditorWindow
{
    [MenuItem("Tools/打开版本发布")]
    public static void CreateWind()
    {
        BuildPC pc = EditorWindow.CreateInstance<BuildPC>();
        pc.Show(true);
    }
    public String mDefVersion = "1.0.0";
    public bool misPublic = false;
    public BuildCollectionResInfo buildCfg = null;
    public void OnGUI()
    {
        GUILayout.BeginVertical();
        {
            GUILayout.BeginHorizontal();
            {
                GUILayout.Label("要生成的版本号:");
                mDefVersion = GUILayout.TextField(mDefVersion);
            }GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                misPublic = GUILayout.Toggle(misPublic, "是否是发布版本");
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                buildCfg = EditorGUILayout.ObjectField(new GUIContent("要生成的版本信息"), buildCfg, typeof(BuildCollectionResInfo),false) as BuildCollectionResInfo;
            }
            GUILayout.EndHorizontal();

            if (GUILayout.Button("生成"))
            {
                if (buildCfg == null)
                {
                    if(UnityEditor.EditorUtility.DisplayDialog("错误", "请选择要发布的东西", "确认"))
                    {
                        Debug.LogError("------------------");
                    }
                }
                else
                {
                    ProjectBuild.BuildPCALL(mDefVersion, misPublic, buildCfg);
                }
             }

        } GUILayout.EndVertical();
    }
}