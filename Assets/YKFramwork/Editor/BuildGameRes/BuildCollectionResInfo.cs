using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class BuildCollectionResInfo : ScriptableObject
{
    /// <summary>
    /// 是否是转移包
    /// </summary>
    public bool isTrans = false;
    public string jumpScheme = "";
    public string CollectionName = "3D砀山麻将";
    public string AndroidPackageName = "com.xymj.dsmj";
    public string IOSPackName = "com.xymj.dsmjpro";
    public string IOSAppStorePackName = "com.xymj.dsmj";
    public int CollectionID = 8002;
    public List<BuildResInfo> builds = new List<BuildResInfo>();
    
    [MenuItem("Assets/创建一个合集资源打包配置")]
    public static BuildCollectionResInfo CreateAsste()
    {
        var select = Selection.activeObject;
        var path = AssetDatabase.GetAssetPath(select);
        path = AssetDatabase.GenerateUniqueAssetPath(path + "/BuildeResInfo.asset");
        BuildCollectionResInfo data = ScriptableObject.CreateInstance<BuildCollectionResInfo>();
        AssetDatabase.CreateAsset(data, path);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        return data;
    }

    public void Build()
    {
        BuildAB.BuildCollectionsResByInfo(this);
    }
}

[CustomEditor(typeof(BuildCollectionResInfo))]
public class BuildCollectionResEditor : Editor
{
    public BuildCollectionResInfo Instance
    {
        get
        {
            return target as BuildCollectionResInfo;
        }
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        serializedObject.Update();
        serializedObject.ApplyModifiedPropertiesWithoutUndo();
        EditorUtility.SetDirty(target);
        if (GUILayout.Button("生成全部"))
        {
            Instance.Build();
        }
    }
}