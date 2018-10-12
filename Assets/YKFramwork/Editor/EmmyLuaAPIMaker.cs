/*
               #########                       
              ############                     
              #############                    
             ##  ###########                   
            ###  ###### #####                  
            ### #######   ####                 
           ###  ########## ####                
          ####  ########### ####               
         ####   ###########  #####             
        #####   ### ########   #####           
       #####   ###   ########   ######         
      ######   ###  ###########   ######       
     ######   #### ##############  ######      
    #######  #####################  ######     
    #######  ######################  ######    
   #######  ###### #################  ######   
   #######  ###### ###### #########   ######   
   #######    ##  ######   ######     ######   
   #######        ######    #####     #####    
    ######        #####     #####     ####     
     #####        ####      #####     ###      
      #####       ###        ###      #        
        ###       ###        ###               
         ##       ###        ###               
__________#_______####_______####______________

                我们的未来没有BUG              
* ==============================================================================
* Filename: EmmyLuaAPIMaker
* Created:  2016/4/5 12:38:24
* Author:   HaYaShi ToShiTaKa
* Purpose:  
* ==============================================================================
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;

//配合ICSharpCode.SharpZipLib.dll 使用，自动达成zip包
public class ZipTool {
    private static long m_allZipFileLength = 0;
    private static long m_zipedLength = 0;
    private static float m_process = 0;
    public static float process {
        get {
            return m_process;
        }
    }
    static public void ZipDirectory(string source, string target, int compressionLevel) {
        source.Replace("\\", "/");

        if (source.Length != 0) {
            // 打包所有的assetbundle到zip,先获取文件目录层级路径，以及assetbundle路径
            string[] pathDerctorys = Directory.GetDirectories(source, "*", SearchOption.AllDirectories);
            List<string> pathList = new List<string>(pathDerctorys);

            for (int i = 0; i < pathList.Count; ) {
                pathList[i] = pathList[i].Replace("\\", "/");
                if (Directory.GetFiles(pathList[i], "*", SearchOption.AllDirectories).Length != 0) {
                    pathList[i] = pathList[i] + "/";
                    i++;
                }
                else {
                    pathList.RemoveAt(i);
                }

            }
            pathDerctorys = pathList.ToArray();

            string[] pathFiles = Directory.GetFiles(source, "*", SearchOption.AllDirectories);

            string[] allPaths = ZipTool.MergerArray(pathDerctorys, pathFiles);
            int directoryNameLength = source.Length;

            for (int i = 0; i < allPaths.Length; i++) {
                allPaths[i] = allPaths[i].Replace("\\", "/");
            }
            m_process = 0;
            ZipTool.ZipDerctory(allPaths, target, directoryNameLength + 1, compressionLevel);
        }
    }
    static private string[] MergerArray(string[] First, string[] Second) {
        string[] result = new string[First.Length + Second.Length];
        First.CopyTo(result, 0);
        Second.CopyTo(result, First.Length);
        return result;
    }

    static private void ZipDerctory(string[] directoryToZip, string zipedDirectory, int fileLength, int compressionLevel) {
#if UNITY_EDITOR
        UnityEditor.EditorUtility.ClearProgressBar();
#endif
        using (ZipOutputStream zipStream = new ZipOutputStream(File.Create(zipedDirectory))) {
            zipStream.SetLevel(compressionLevel);
            ZipEntry zipEntry = null;
            FileStream fileStream = null;
            for (int i = 0, imax = directoryToZip.Length; i < imax; i++) {
                string fileName = directoryToZip[i];
                zipEntry = new ZipEntry(fileName.Remove(0, fileLength));
                zipStream.PutNextEntry(zipEntry);
                if (!fileName.EndsWith(@"/")) {
                    fileStream = File.OpenRead(fileName);
                    byte[] buffer = new byte[fileStream.Length];
                    fileStream.Read(buffer, 0, buffer.Length);
                    zipStream.Write(buffer, 0, buffer.Length);
                    fileStream.Dispose();
                }
                m_process = i / (float)imax;
#if UNITY_EDITOR
                UnityEditor.EditorUtility.DisplayProgressBar("ziping", string.Format("zip {0}", fileName), m_process);
                UnityEngine.Debug.Log(string.Format("{0:P1}", m_process));
#endif
            }
        }
#if UNITY_EDITOR
        UnityEditor.EditorUtility.ClearProgressBar();
#endif
    }
    public static void UnZip(string zipedFile, string strDirectory, string password, bool overWrite, Action<string> endAction) {

        if (!strDirectory.EndsWith("/")) {
            strDirectory = strDirectory + "/";
        }

        using (ZipInputStream s = new ZipInputStream(File.OpenRead(zipedFile))) {
            s.Password = password;
            ZipEntry theEntry;
            m_allZipFileLength = s.Length;
            m_zipedLength = 0;
            m_process = 0;
            while ((theEntry = s.GetNextEntry()) != null) {
                UnzipOneFile(theEntry, s, strDirectory, overWrite);
            }
            s.Close();
        }
        if (endAction != null) {
            endAction(zipedFile);
        }
    }
    private static void UnzipOneFile(ZipEntry theEntry, ZipInputStream s, string strDirectory, bool overWrite) {
        string directoryName = "";
        string pathToZip = "";
        pathToZip = theEntry.Name;
        if (pathToZip != "")
            directoryName = Path.GetDirectoryName(pathToZip) + "/";

        string fileName = Path.GetFileName(pathToZip);

        Directory.CreateDirectory(strDirectory + directoryName);
        float rate = (float)theEntry.CompressedSize / (float)theEntry.Size;
        if (fileName != "") {
            if ((File.Exists(strDirectory + directoryName + fileName) && overWrite)
                || (!File.Exists(strDirectory + directoryName + fileName))) {
                using (FileStream streamWriter = File.Create(strDirectory + directoryName + fileName)) {
                    int size = 2048;
                    byte[] data = new byte[size];
                    while (true) {
                        size = s.Read(data, 0, data.Length);

                        if (size > 0) {
                            m_zipedLength += (long)(size * rate);
                            m_process = m_zipedLength / (float)m_allZipFileLength;
                            streamWriter.Write(data, 0, size);
                        }
                        else {
                            break;
                        }
                    }
                    streamWriter.Close();
                }
            }
        }

    }
}

static public class EmmyLuaAPIMaker {

    #region member
    private static string m_apiDir = Application.dataPath + "/../../UnityAPI";
    //static BindingFlags binding = BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase;
    private static List<Type> m_typeList = new List<Type> {
        typeof(object),
        typeof(System.String),
        typeof(System.Enum),
        typeof(UnityEngine.Object),
    };

    private static List<string> m_usingList = new List<string> {
        "System.Collections.Generic",
        "System.Collections",
        "System",
    };
    private static List<string> m_trimNameSpaceList = new List<string> {
        "System.Collections.Generic",
        "System.Collections",
        "System",
        "LuaInterface",
    };
    private static List<string> m_memberFilter = new List<string> {
        "String.Chars",
        "AnimationClip.averageDuration",
        "AnimationClip.averageAngularSpeed",
        "AnimationClip.averageSpeed",
        "AnimationClip.apparentSpeed",
        "AnimationClip.isLooping",
        "AnimationClip.isAnimatorMotion",
        "AnimationClip.isHumanMotion",
        "AnimatorOverrideController.PerformOverrideClipListCleanup",
        "Caching.SetNoBackupFlag",
        "Caching.ResetNoBackupFlag",
        "Light.areaSize",
        "Security.GetChainOfTrustValue",
        "Texture2D.alphaIsTransparency",
        "WWW.movie",
        "WebCamTexture.MarkNonReadable",
        "WebCamTexture.isReadable",
        "Graphic.OnRebuildRequested",
        "Text.OnRebuildRequested",
        "Resources.LoadAssetAtPath",
        "Application.ExternalEval",         
        //NGUI
        "UIInput.ProcessEvent",
        "UIWidget.showHandlesWithMoveTool",
        "UIWidget.showHandles",
        "Input.IsJoystickPreconfigured",
        "UIDrawCall.isActive",
    };
    private static Dictionary<string, int> m_nameCounter = new Dictionary<string, int>();

    private static List<ConstructorInfo> m_constructs = new List<ConstructorInfo>();
    private static List<MethodInfo> m_methods = new List<MethodInfo>();
    private static List<PropertyInfo> m_propertys = new List<PropertyInfo>();
    private static List<FieldInfo> m_fields = new List<FieldInfo>();
    private static string m_argsText;

    public static bool IsMemberFilter(MemberInfo mi) {
        return m_memberFilter.Contains(mi.ReflectedType.Name + "." + mi.Name);
    }
    #endregion

    #region export api
    [MenuItem("Lua/Gen Emmy Lua API Files", false, 14)]
    public static void ExportLuaApi() {
        List<Type> classList = XLua.Utils.GetAllTypes();

        // add class here
        BindingFlags bindType = BindingFlags.DeclaredOnly |
                BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public;
        MethodInfo[] methods;
        MemberInfo[] fields;
        PropertyInfo[] properties;
        List<ConstructorInfo> constructors;
        ParameterInfo[] paramInfos;
        int delta;
        string path = m_apiDir;
        if (path == "") {
            return;
        }
        
        if (!Directory.Exists(path)) {
            Directory.CreateDirectory(path);
        }

        foreach (Type t in classList) {
            string fileName = path + "/" + t.Name + ".lua";
            if (File.Exists(fileName)) File.Delete(fileName);
            Debug.LogError("fileName=" + fileName);
            FileStream fs = new FileStream(fileName, FileMode.Create);
            var utf8WithoutBom = new System.Text.UTF8Encoding(false);
            StreamWriter sw = new StreamWriter(fs, utf8WithoutBom);

            if (t.BaseType != null) {
                sw.WriteLine(string.Format("---@class {0} : {1}", t.FullName, t.BaseType.FullName));
            }
            else {
                sw.WriteLine(string.Format("---@class {0}", t.FullName));
            }

            string className = t.Name;

            #region field
            fields = t.GetFields(bindType);
            foreach (var field in fields) {
                if (IsObsolete(field)) {
                    continue;
                }
                WriteField(sw, field.DeclaringType, field.Name);
            }

            properties = t.GetProperties(bindType);
            foreach (var property in properties) {
                if (IsObsolete(property)) {
                    continue;
                }
                WriteField(sw, property.DeclaringType, property.Name);
            }

            sw.Write("\n");
            #endregion

            #region constructor
            constructors = new List<ConstructorInfo>(t.GetConstructors(bindType));
            constructors.Sort((left, right) => { return left.GetParameters().Length - right.GetParameters().Length; });
            bool isDefineTable = false;

            if (constructors.Count > 0) {
                sw.WriteLine(className + " = { }");
                WriteCtorComment(sw, constructors);
                paramInfos = constructors[constructors.Count - 1].GetParameters();
                delta = paramInfos.Length - constructors[0].GetParameters().Length;
                WriteFun(sw, paramInfos, delta, t, "New", className);
                isDefineTable = true;
            }

            #endregion

            #region method
            methods = t.GetMethods(bindType);
            MethodInfo method;

            Dictionary<string, List<MethodInfo>> methodDict = new Dictionary<string, List<MethodInfo>>();
            if (methods.Length != 0 && !isDefineTable) {
                sw.WriteLine(className + " = { }");
            }

            for (int i = 0; i < methods.Length; i++) {
                method = methods[i];
                string methodName = method.Name;
                if (IsObsolete(method)) {
                    continue;
                }
                if (method.IsGenericMethod) { continue; }
                if (!method.IsPublic) continue;
                if (methodName.StartsWith("get_") || methodName.StartsWith("set_")) continue;

                List<MethodInfo> list;
                if (!methodDict.TryGetValue(methodName, out list)) {
                    list = new List<MethodInfo>();
                    methodDict.Add(methodName, list);
                }
                list.Add(method);
            }

            var itr = methodDict.GetEnumerator();
            while (itr.MoveNext()) {
                List<MethodInfo> list = itr.Current.Value;
                RemoveRewriteFunHasTypeAndString(list);
                list.Sort((left, right) => { return left.GetParameters().Length - right.GetParameters().Length; });
                WriteFunComment(sw, list);
                paramInfos = list[list.Count - 1].GetParameters();
                delta = paramInfos.Length - list[0].GetParameters().Length;
                WriteFun(sw, paramInfos, delta, list[0].ReturnType, list[0].Name, className);
            }
            itr.Dispose();

            if (methods.Length != 0 || isDefineTable) {
                sw.WriteLine("return " + className);
            }
            #endregion

            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }
        string zipName = path + ".zip";
        if (File.Exists(zipName)) {
            File.Delete(zipName);
        }
        ZipTool.ZipDirectory(path, zipName, 7);
        Directory.Delete(path, true);

        Debug.Log("转换完成");
    }

    //扔掉 重载函数中参数数量相同，且其中只有一个参数是type类型另一个是string类型
    static void RemoveRewriteFunHasTypeAndString(List<MethodInfo> methodList) {
        MethodInfo method1;
        MethodInfo method2;
        for (int i = methodList.Count - 1; i >= 0; i--) {
            method1 = methodList[i];
            for (int j = i - 1; j >= 0; j--) {
                method2 = methodList[j];
                bool isMt1Type;
                if (MethodParamHasTypeOrString(method1, method2, out isMt1Type)) {
                    if (isMt1Type) {
                        methodList.RemoveAt(j);
                    }
                    else {
                        methodList.RemoveAt(i);
                    }
                    break;
                }
            }
        }
    }
    static bool CheckType(ParameterInfo info) {
        return info.ParameterType == typeof(Type) || info.ParameterType == typeof(string);
    }

    static bool MethodParamHasTypeOrString(MethodInfo method1, MethodInfo method2, out bool isMt1Type) {
        bool result = false;
        isMt1Type = false;

        ParameterInfo[] paramInfos1 = method1.GetParameters();
        ParameterInfo[] paramInfos2 = method2.GetParameters();

        bool isFirstCheck = false;
        if (paramInfos1.Length != paramInfos2.Length) goto Exit0;
        for (int i = 0, imax = paramInfos1.Length; i < imax; i++) {
            if (paramInfos1[i].ParameterType != paramInfos2[i].ParameterType) {
                if (isFirstCheck) goto Exit0;
                if (!CheckType(paramInfos1[i])) goto Exit0;
                if (!CheckType(paramInfos2[i])) goto Exit0;
                isMt1Type = paramInfos1[i].ParameterType == typeof(Type);
                isFirstCheck = true;
            }
        }

        result = true;
    Exit0:
        return result;
    }

    public static bool IsObsolete(MemberInfo mb) {
        object[] attrs = mb.GetCustomAttributes(true);

        for (int j = 0; j < attrs.Length; j++) {
            Type t = attrs[j].GetType();

            if (t == typeof(System.ObsoleteAttribute)) {
                return true;
            }
        }

        if (IsMemberFilter(mb)) {
            return true;
        }

        return false;
    }
    static void WriteField(StreamWriter sw, Type returnType, string fieldName) {
        sw.WriteLine(string.Format("---@field public {0} {1}", fieldName, returnType.Name));
    }
    static void WriteFunComment(StreamWriter sw, List<MethodInfo> list) {
        for (int i = 0, imax = list.Count; i < imax; i++) {
            WriteOneComment(sw, list[i]);
        }
    }
    static void WriteCtorComment(StreamWriter sw, List<ConstructorInfo> list) {
        for (int i = 0, imax = list.Count; i < imax; i++) {
            WriteOneComment(sw, list[i]);
        }
    }
    static void WriteOneComment(StreamWriter sw, MethodBase method) {
        ParameterInfo[] paramInfos;
        string argsStr = "";
        paramInfos = method.GetParameters();
        for (int i = 0, imax = paramInfos.Length; i < imax; i++) {
            if (i != 0) {
                argsStr += ", ";
            }
            argsStr += paramInfos[i].ParameterType.Name + " " + RepalceLuaKeyWord(paramInfos[i].Name);
        }
        if (method is MethodInfo) {
            sw.WriteLine("---public {0} {1}({2})", ((MethodInfo)method).ReturnType.Name, method.Name, argsStr);
        }
        else if (method is ConstructorInfo) {
            sw.WriteLine("---public {0} {1}({2})", method.ReflectedType.Name, method.Name, argsStr);
        }
    }
    static void WriteFun(StreamWriter sw, ParameterInfo[] paramInfos, int delta, Type methodReturnType, string methodName, string className) {
        string typeStr = ConvertToLuaType(methodReturnType);
        if (methodReturnType != typeof(void)) {
            sw.WriteLine(string.Format("---@return {0}", typeStr));
        }
        for (int i = 1, imax = delta; i <= imax; i++) {
            int index = paramInfos.Length - 1 - delta + i;
            sw.WriteLine(string.Format("---@param optional {0} {1}", RepalceLuaKeyWord(paramInfos[index].Name), ConvertToLuaType(paramInfos[index].ParameterType)));
        }
        string argsStr = "";
        for (int i = 0, imax = paramInfos.Length; i < imax; i++) {
            if (i != 0) {
                argsStr += ", ";
            }
            argsStr += RepalceLuaKeyWord(paramInfos[i].Name);
        }
        sw.WriteLine(string.Format("function {0}:{1}({2}) end", className, methodName, argsStr));
    }
    static string ConvertToLuaType(Type methodReturnType) {
        string result = "";

        if (methodReturnType != typeof(void)) {

            if (methodReturnType == typeof(bool)) {
                result = "bool";
            }
            else if (methodReturnType == typeof(long) || methodReturnType == typeof(ulong)) {
                result = "long";
            }
            else if (methodReturnType.IsPrimitive || methodReturnType.IsEnum) {
                result = "number";
            }
//             else if (methodReturnType == typeof(LuaFunction)) {
//                 result = "function";
//             }
            else if (methodReturnType == typeof(Type)) {
                result = "string";
            }
            else if (methodReturnType.IsArray) {
                result = "table";
            }
//             else if (methodReturnType == typeof(LuaTable)) {
//                 result = "table";
//             }
            else {
                result = methodReturnType.Name;
            }
        }
        return result;
    }
    static string RepalceLuaKeyWord(string name) {
        if (name == "table") {
            name = "tb";
        }
        else if (name == "function") {
            name = "func";
        }
        else if (name == "type") {
            name = "t";
        }
        else if (name == "end") {
            name = "ed";
        }
        else if (name == "local") {
            name = "loc";
        }
        else if (name == "and") {
            name = "ad";
        }
        else if (name == "or") {
            name = "orz";
        }
        else if (name == "not") {
            name = "no";
        }
        return name;
    }
    #endregion
}
