using FairyGUI;
using FairyGUI.Utils;
using XLua;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class YKSupportLua
{
    public interface ILuaNeedExtendCS
    {
        void SetLuaTalbe(LuaTable t);
    }


    public static void ShowWindow(string uiName, object param, LuaTable lunFun
           , bool hideAll = false, bool hideDotDel = false)
    {
        List<string> list = null;
        if (hideAll)
        {
            list = UIMgr.Instance.GetAllOpenWindows();
        }

        UIMgr.Instance.ShowWindow(uiName, null, ()=> 
        {
            object[] objs = lunFun.Get<LuaFunction>("new").Call();
            LuaWindow wind = objs[0] as LuaWindow;
            return wind;
        }, param, list, hideDotDel);
    }

    public static void GotoScene(string sceneName,object param , LuaTable lunFun)
    {
        SceneMgr.Instance.GotoScene(sceneName, null, () =>
          {
              object[] objs = lunFun.Get<LuaFunction>("new").Call();
              LuaSceneBase wind = objs[0] as LuaSceneBase;
              return wind;
          }, param: param);
    }


    #region BaseWindow
    [CSharpCallLua]
    public interface ILuaWindow
    {
        void OnInit();
        void DoHideAnimation();
        void DoShowAnimation();
        void OnShown();
        void OnHide();
        void OnDestroy();
        void OnColseBtn();
        void OnHandler(EventData ev);
        void OnBtnClick(GButton btn);
        string resName { set; get; }
        string packName { set; get; }
        bool isNeedHideAnimation { set; get; }
        bool isNeedShowAnimation { set; get; }
    }
    public class LuaWindow : BaseUI , ILuaNeedExtendCS
    {
        ILuaWindow callBack;
        LuaTable mLuatable;
        public override string ResName
        {
            get
            {
                return callBack.resName;
            }
        }

        public override string PackName
        {
            get
            {
                return callBack.packName;
            }
        }

        protected override bool IsNeedHideAnimation
        {
            get
            {
                return callBack.isNeedHideAnimation;
            }
        }

        protected override bool IsNeedShowAnimation
        {
            get
            {
                return callBack.isNeedShowAnimation;
            }
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        protected override void OnInit()
        {
            base.OnInit();
            if (mLuatable != null)
            {
                LuaTable objs = LuaMgr.Instance.mLua.NewTable();
                LuaTable ctrls = LuaMgr.Instance.mLua.NewTable();
                mLuatable.Set("Objs", objs);
                mLuatable.Set("ctrls", ctrls);

                foreach (KeyValuePair<string, FairyGUI.GObject> kv in this.UIObjs)
                {
                    objs.Set(kv.Key, kv.Value);
                }

                foreach (KeyValuePair<string, FairyGUI.Controller> kv in this.UICtrls)
                {
                    ctrls.Set(kv.Key, kv.Value);
                }
            }
            if (callBack != null)
            {
                callBack.OnInit();
            }
            

        }

        protected override void DoHideAnimation()
        {
            //base.DoHideAnimation();
            if (callBack.isNeedHideAnimation)
            {
                callBack.DoHideAnimation();
            }
            else
            {
                this.HideImmediately();
            }
        }

        protected override void DoShowAnimation()
        {
            //base.DoShowAnimation();
            if (callBack.isNeedHideAnimation)
            {
                callBack.DoShowAnimation();
            }
            else
            {
                this.OnShown();
            }


        }

        protected override void OnShown(object param)
        {
            base.OnShown(param);
            if (callBack != null)
            {
                callBack.OnShown();
            }

        }

        protected override void OnHide()
        {
            if (callBack != null)
            {
                callBack.OnHide();
            }
            base.OnHide();


        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            if (callBack != null)
            {
                callBack.OnDestroy();
            }
        }
        protected override void OnBtnClose()
        {
            callBack.OnColseBtn();
        }

        protected override void OnHandler(EventData ev)
        {
            base.OnHandler(ev);
            callBack.OnHandler(ev);
        }

        protected override void OnBtnClick(GButton btn)
        {
            base.OnBtnClick(btn);
            callBack.OnBtnClick(btn);
        }
        public void SetLuaTalbe(LuaTable t)
        {
            mLuatable = t;
            callBack = mLuatable.Cast<ILuaWindow>();
        }
    }
    #endregion


    #region SceneBase
    [CSharpCallLua]
    public interface ILuaSceneBase
    {
        void OnInit(object param);
        void OnEnter();
        void OnLeave();

        void OnResLoaded();

        void OnTaskFailure(string taskName, string error);

        void OnHandler(EventData ev);

        void OnDestroy();
    }
    public class LuaSceneBase : SceneBase,ILuaNeedExtendCS
    {
        private LuaTable mLuaTable;
        private ILuaSceneBase callback;
        public void SetLuaTalbe(LuaTable peerTable)
        {
            mLuaTable = peerTable;
            callback = mLuaTable.Cast<ILuaSceneBase>();
        }
        protected override void OnInit(object param)
        {
            base.OnInit(param);

            if (callback != null)
            {
                callback.OnInit(param);
            }
        }

        protected override void OnEnter()
        {
            base.OnEnter();
            if (callback != null)
            {
                callback.OnEnter();
            }
        }

        protected override void OnHandler(EventData ev)
        {
            base.OnHandler(ev);
            if (callback != null)
            {
                callback.OnHandler(ev);
            }
        }

        protected override void OnLeave()
        {
            base.OnLeave();
            if (callback != null)
            {
                callback.OnLeave();
            }
        }

        protected override void OnResLoaded()
        {
            base.OnResLoaded();
            if (callback != null)
            {
                callback.OnResLoaded();
            }
        }

        protected override void OnTaskFailure(string taskName, string error)
        {
            base.OnTaskFailure(taskName, error);
            if (callback != null)
            {
                callback.OnTaskFailure(taskName, error);
            }
        }

        public override void OnDestroy()
        {
            if (mLuaTable != null) mLuaTable.Dispose();
        }
    }
    #endregion

    #region LuaTaskBase
    [CSharpCallLua]
    public interface ILuaTaskBase
    {
        void OnExecute();
    }

    public class LuaTaskBase : ITask,ILuaNeedExtendCS
    {

        private LuaTable mPeerTable = null;
        public string failureInfo = "";
        public string taskName = "";
        public bool isFailure = false;
        public bool isFinished = false;
        private ILuaTaskBase callback;

        public bool IsFailure
        {
            get
            {
                return isFailure;
            }
        }

        public bool IsFinished
        {
            get
            {
                return isFinished;
            }
        }
        public void SetLuaTalbe(LuaTable peerTable)
        {
            mPeerTable = peerTable;
            callback = peerTable.Cast<ILuaTaskBase>();
        }

        ~LuaTaskBase()
        {
            if (mPeerTable != null)
            {
                mPeerTable.Dispose();
            }
        }

        public string TaskName()
        {
            return taskName;
        }

        public void OnExecute()
        {
            if (callback != null)
            {
                callback.OnExecute();//.Call(this);
            }
        }

        public string FailureInfo()
        {
            return failureInfo;
        }

        public void Rest()
        {
            isFailure = false;
            isFinished = false;
        }
    }
    #endregion


    #region LuaStateBase
    public class LuaStateBase : IState , ILuaNeedExtendCS
    {
        private LuaTable mPeerTable = null;
        private IState callback = null;
        public void SetLuaTalbe(LuaTable peerTable)
        {
            mPeerTable = peerTable;
            mPeerTable = peerTable;
            callback = mPeerTable.Cast<IState>();
        }

        public uint StateId
        {
            get;
            set;
        }

        public void OnEnter(IState prevState, object param1 = null, object param2 = null)
        {
            if (callback != null)
            {
                callback.OnEnter(prevState, param1, param2);
            }
        }

        public void OnFixedUpdate()
        {
            if (callback != null)
            {
                callback.OnFixedUpdate();
            }
        }

        public void OnLateUpdate()
        {
            if (callback != null)
            {
                callback.OnLateUpdate();
            }
        }

        public void OnLeave(IState nextState, object param1 = null, object param2 = null)
        {
            if (callback != null)
            {
                callback.OnLeave( nextState, param1, param2);
            }
        }

        public void OnUpdate()
        {
            if (callback != null)
            {
                callback.OnUpdate();
            }
        }

        public void OnRelease()
        {
            if (callback != null)
            {
                callback.OnRelease();
            }
            if (mPeerTable != null)
            {
                mPeerTable.Dispose();
            }
        }
    }
    #endregion

    #region LuaUBBParser
    public class LuaUBBParser : UBBParser , ILuaNeedExtendCS
    {
        private LuaTable mPeerTable = null;
        private LuaFunction mOnTagHandlers = null;
        public void SetLuaTalbe(LuaTable peerTable)
        {
            mPeerTable = peerTable;
            mOnTagHandlers = mPeerTable.Get<LuaFunction>("OnTagHandlers");
        }

        public void AddTag(string key)
        {
            this.handlers[key] = OnTagHandlers;
        }

        string OnTagHandlers(string tagName, bool end, string attr)
        {
            string str = "";
            if (mOnTagHandlers != null)
            {
                object[] ret= mOnTagHandlers.Call(tagName, end, attr);
                str = (string)ret[0];
            }
            return str;
        }
    }
    #endregion
}