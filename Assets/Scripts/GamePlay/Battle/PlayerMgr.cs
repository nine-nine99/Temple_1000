using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 玩家控制器 
/// </summary>
public class PlayerMgr : Singleton<PlayerMgr>
{
    //初始化
    public void Init()
    {
        InitMsg();
    }

    //清除数据
    public void Clear()
    {
        ClearMsg();
    }

    //注册消息
    public void InitMsg()
    {

    }

    //反注册消息
    public void ClearMsg()
    {

    }

    //开始游戏时调用，根据需求实现，需要在Battle.StartBattle()中调用
    public void StartBattle()
    {
        Send.SendMsg(SendType.BattleStart);
    }

    //Update函数，根据需求实现，需要在Launch.Update()中调用
    public void OnUpdate()
    {
        // Debug.Log("PlayerMgr Update");
        if ((Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) && GameStateMgr.Instance.curState != GameState.Battle)
        {
            GameStateMgr.Instance.SwitchState(GameState.Battle);
        }
    }

}
