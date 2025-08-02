using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState_1001 : IState
{
    private FSM_1001 fsm;
    public IdleState_1001(FSM_1001 fsm)
    {
        this.fsm = fsm;
    }
    public void OnEnter()
    {
        // 注册监听游戏开始
        Send.RegisterMsg(SendType.BattleStart, OnBattleStartMessage);

    }
    public void OnUpdate()
    {

    }
    public void OnExit()
    {
        Send.UnregisterMsg(SendType.BattleStart, OnBattleStartMessage);
    }

    public void OnBattleStartMessage(params object[] objs)
    {
        fsm.ChangeState(State.Run);
        Debug.Log("开始战斗，奔跑");
    }
}
