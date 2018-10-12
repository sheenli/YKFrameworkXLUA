using XLua;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;

public class LuaMgr //: EventDispatcherNode
{
    /// <summary>
    /// 目录对应的lua文件
    /// </summary>
    private Dictionary<string, Dictionary<string, byte[]>> mLuaFiles = new Dictionary<string, Dictionary<string, byte[]>>();

    //private Dictionary<string, byte[]> allLua = new Dictionary<string, byte[]>();

    private static LuaMgr mInstance;
    public static LuaMgr Instance
    {
        get
        {
            return mInstance = mInstance ?? new LuaMgr();
        }
    }

    public void Init()
    {

    }

    public void OnDestroy()
    {
        if (mMainLua != null)
        {
            mMainLua.Get<LuaFunction>("OnDestroy").Call();
        }


        if (mMainLua != null) mMainLua.Dispose();
        if (this.mLua != null)
        {
            this.mLua.Dispose();
        }
    }

    internal void ShowExit()
    {
        if (mLua != null)
        {
            mMainLua.Get<LuaFunction>("OnShowExit").Call();
        }
    }

    public void AddFile(string path,AssetBundle ab)
    {
        path = path.ToLower();
#if UNITY_EDITOR
        if (AppConst.DebugMode)
        {
            string root = AppConst.LuaPath + "/" + path;
            Dictionary<string, byte[]> dic = new Dictionary<string, byte[]>();
            EeditorLoadLuaFile(root, root,ref dic);
            mLuaFiles[path] = dic;
            return;
        }
#endif
        path = Path.GetFileName(path);
        if (ab != null)
        {
            TextAsset[] text = ab.LoadAllAssets<TextAsset>();
            Dictionary<string, byte[]> dic = new Dictionary<string, byte[]>();
            foreach (TextAsset t in text)
            {
                dic.Add(t.name.ToLower(), t.bytes);
                Resources.UnloadAsset(t);
            }
            mLuaFiles[path] = dic;
            ABMgr.Instance.UnLoadAB(path);
        }
    }

  

    

    public byte[] GetLuaFileByte(string fileName)
    {
        foreach (Dictionary<string,byte[]> dic in this.mLuaFiles.Values)
        {
            if (dic.ContainsKey(fileName))
            {
                return dic[fileName];
            }
        }

        Debug.LogWarning("lua文件查找失败 fileName="+fileName);
        return null;
    }

    public LuaEnv mLua = null;
    private LuaTable mMainLua = null;
    public void StartGame()
    {
        Debug.Log("开始游戏");
        mLua = new LuaEnv();
        mLua.AddLoader((ref string filename) =>
        {
             string fileName = filename.ToLower();
            if (fileName.EndsWith(".lua"))
            {
                fileName = fileName.Substring(0, fileName.Length - 4);
            }
            fileName = fileName.Replace("/", "_").Replace(".", "_");

            //fileName = Path.GetFileNameWithoutExtension(fileName);

            byte[] buffer = LuaMgr.Instance.GetLuaFileByte(fileName);
            return buffer;
        });
        mLua.AddBuildin("rapidjson", XLua.LuaDLL.Lua.LoadRapidJson);
        mLua.AddBuildin("lpeg", XLua.LuaDLL.Lua.LoadLpeg);
        mLua.AddBuildin("pb", XLua.LuaDLL.Lua.LoadLuaProfobuf);

        object[] obj = mLua.DoString("return require(\"Main\")");
        mMainLua = obj[0] as LuaTable;
         mMainLua.Get<LuaFunction>("Main").Call();
        //lua.Dispose();
    }

    [XLua.BlackList]
    public void EeditorLoadLuaFile(string root,string luaPath,ref Dictionary<string,byte[]> dic)
    {
        string[] files = Directory.GetFiles(luaPath);
        foreach (string file in files)
        {
            
            if (!AppConst.LuaExtNames.Contains(Path.GetExtension(file)))
            {
                continue;
            }

            string fileName = AppConst.ToValidFileName(root, file);
            if (dic.ContainsKey(fileName))
            {
                Debug.LogError("发现重复的lua文件 名称为"+fileName);
            }
            dic[fileName] = File.ReadAllBytes(file);
        }

        string[] dirs = Directory.GetDirectories(luaPath);
        if (dirs == null || dirs.Length <= 0)
        {
            return;
        }
        foreach (string dir in dirs)
        {
            EeditorLoadLuaFile(root, dir,ref dic);
        }
    }

    public void GC()
    {
        if (mLua != null)
        {
            mLua.FullGc();
        }
    }

}
