using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_1001 : FSM_1000
{
    public override void Start()
    {
        states.Add(State.Idle, new IdleState_1001(this));
        states.Add(State.Run, new RunState_1001(this));

        currentState = states[State.Idle];
        currentState.OnEnter();
    }
}

