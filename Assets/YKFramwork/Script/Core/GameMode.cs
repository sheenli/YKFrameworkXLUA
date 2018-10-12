#if usetolua
using LuaInterface;
#endif

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : EventDispatcherNode
{
    public string IP;
    /// <summary>
    /// 维度
    /// </summary>
    public float latitude = -1;
    /// <summary>
    /// 经度
    /// </summary>
    public float longitude = -1;

    public string pos
    {
        get
        {
            return string.Format("{0}#{1}#{2}", latitude, longitude, IP);
        }
    }

    /// <summary>
    /// 所有数据层
    /// </summary>
    private List<IMode> mModes = new List<IMode>();

    /// <summary>
    /// 当前角色openid
    /// </summary>
    public string OpenId
    {
        get
        {
            var openid = PlayerPrefs.GetString("FSMJLoginOpenId");
            return openid;
        }
        set
        {
            PlayerPrefs.SetString("FSMJLoginOpenId", value);

            PlayerPrefs.Save();
        }
    }

    /// <summary>
    /// 麻将牌背的背景颜色
    /// </summary>
    public int CardBack
    {
        get
        {
            var cardBack = PlayerPrefs.GetInt("FSMJCardBack", 0);
            return cardBack;
        }
        set
        {
            PlayerPrefs.SetInt("FSMJCardBack", value);
            PlayerPrefs.Save();
        }
    }

    

    /// <summary>
    /// 麻将牌桌的背景颜色
    /// </summary>
    public int DeskBack
    {
        get
        {
            var deskBack = PlayerPrefs.GetInt("FSMJDeskBack", 0);
            return deskBack;
        }
        set
        {
            PlayerPrefs.SetInt("FSMJDeskBack", value);
            PlayerPrefs.Save();
        }
    }

    public static GameMode Instance
    {
        get;
        private set;
    }

    /// <summary>
    /// 是否是审核模式
    /// </summary>
    public bool AuditMode = false;

    void Awake()
    {
        Instance = this;
        this.AttachListener(GetGPSFinishEvent.evenId, this.OnHander, 99);
    }

    private void OnHander(EventData data)
    {
        if (data.name == GetGPSFinishEvent.evenId)
        {
            GetGPSFinishEvent.GPSLocationInfo info = (GetGPSFinishEvent.GPSLocationInfo)data.value;
            latitude = info.latitude;
            longitude = info.longitude;
            Debug.Log("获取到经纬度 longitude=" + longitude + "/latitude=" + latitude);
        }
    }

    /// <summary>
    /// 登录的到时候要发送的消息
    /// </summary>
    private List<IMode> loginMsgs = new List<IMode>();

    /// <summary>
    /// 添加一个mode
    /// </summary>
    /// <param name="mode"></param>
    public void AddMode(IMode mode)
    {
        mModes.Add(mode);
    }

    public void InitDtata()
    {
        mIsLoginSendingFlag = false;
        foreach (IMode mode in mModes)
        {
            mode.OnInitData();
        }
    }

    /// <summary>
    /// 正在发送登录消息
    /// </summary>
    private bool mIsLoginSendingFlag = false;
    

    public int SendLoginMsgs()
    {
        mIsLoginSendingFlag = true;
        this.loginMsgs.Clear();
        foreach (IMode mode in mModes)
        {
            this.loginMsgs.Add(mode);
            mode.OnLogin();
        }
        return loginMsgs.Count;
    }

    public void ClearData()
    {
        foreach (IMode mode in this.mModes)
        {
            mode.OnClear();
        }
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        if (this.mIsLoginSendingFlag)
        {
            if (this.loginMsgs.Count > 0)
            {
                for (int i = 0; i < this.loginMsgs.Count; i++)
                {
                    if (this.loginMsgs[i].IsLoginDataOk)
                    {
                        this.loginMsgs.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
            {
                QueueEvent(EventDef.SendLoginCompleted);
                this.mIsLoginSendingFlag = false;
            }
        }
    }

    public override void OnDestroy()
    {
        base.OnDestroy();
        this.DetachListener(GetGPSFinishEvent.evenId, this.OnHander);
        foreach (IMode mode in this.mModes)
        {
            mode.OnDestroy();
        }
        ClearData();
    }
}

public interface IMode
{
    void OnInitData();
    void OnLogin();
    void OnClear();
    void OnDestroy();

    bool IsLoginDataOk { set; get; }
}
