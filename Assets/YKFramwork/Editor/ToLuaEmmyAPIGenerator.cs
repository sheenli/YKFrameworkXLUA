using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

using XLua;
using CSObjectWrapEditor;
using ICSharpCode.SharpZipLib.Zip;

public class XluaNameSpaceMapGenerator : Editor
{

    private const string FILE_NAME = "LuaApi";

    [MenuItem("XLua/Generate NameSpaceMap", false, -100)]
    public static void GenAll()
    {
        HashSet<string> nameSpaceSet = new HashSet<string>();
        List<string> nameSpaceList = new List<string>(nameSpaceSet);
        HashSet<string> noNameSpaceTypeSet = new HashSet<string>();
        List<string> noNameSpaceTypeList = new List<string>();

        Generator.GetGenConfig(Utils.GetAllTypes());
        foreach (Type type in Generator.LuaCallCSharp)
        {
            if (string.IsNullOrEmpty(type.Namespace))
            {
                string typeName = type.FullName.Split('+')[0];
                if (!noNameSpaceTypeSet.Contains(typeName))
                {
                    noNameSpaceTypeSet.Add(typeName);
                    noNameSpaceTypeList.Add(typeName);
                }
            }
            else
            {
                string namespaceName = type.Namespace.Split('.')[0];
                if (!nameSpaceSet.Contains(namespaceName))
                {
                    nameSpaceSet.Add(namespaceName);
                    nameSpaceList.Add(namespaceName);
                }
            }
        }
        nameSpaceList.Sort();
        noNameSpaceTypeList.Sort();

        StringBuilder luaScriptSb = new StringBuilder();
        luaScriptSb.AppendLine("CS = {");
        foreach (string nameSpace in nameSpaceList)
        {
            luaScriptSb.Append("\t");
            luaScriptSb.Append(nameSpace);
            luaScriptSb.Append(" = ");
            luaScriptSb.Append(nameSpace);
            luaScriptSb.AppendLine(";");
        }
        luaScriptSb.AppendLine();
        foreach (string typeName in noNameSpaceTypeList)
        {
            luaScriptSb.Append("\t");
            luaScriptSb.Append(typeName);
            luaScriptSb.Append(" = ");
            luaScriptSb.Append(typeName);
            luaScriptSb.AppendLine(";");
        }
        luaScriptSb.Append("}");

        string luaScriptFileName = FILE_NAME + ".lua";
        byte[] luaScriptBytes = Encoding.UTF8.GetBytes(luaScriptSb.ToString());
        Dictionary<string, byte[]> fileDict = new Dictionary<string, byte[]>() { { luaScriptFileName, luaScriptBytes } };
        string zipFileName = Application.dataPath + "/../" + FILE_NAME + ".zip";
        ZipDerctory(zipFileName, fileDict);

        Debug.Log("NameSpaceMap generating is completed!");
    }

    private static void ZipDerctory(string zipedDirectory, Dictionary<string, byte[]> fileDict, int compressionLevel = 9)
    {
        FileStream fileStream = File.Create(zipedDirectory);
        ZipOutputStream zipStream = new ZipOutputStream(fileStream);
        zipStream.SetLevel(compressionLevel);
        foreach (string fileName in fileDict.Keys)
        {
            zipStream.PutNextEntry(new ZipEntry(fileName));
            byte[] buffer = fileDict[fileName];
            zipStream.Write(buffer, 0, buffer.Length);
        }
        zipStream.Flush();
        zipStream.Close();
        fileStream.Close();
    }
}
