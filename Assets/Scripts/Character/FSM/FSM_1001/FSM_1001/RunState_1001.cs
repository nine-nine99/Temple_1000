using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState_1001 : IState
{
    private FSM_1001 fsm;
    private Rigidbody rb;
    public RunState_1001(FSM_1001 fsm)
    {
        this.fsm = fsm;
        this.rb = fsm.GetComponent<Rigidbody>();
    }
    public void OnEnter()
    {

    }

    public void OnUpdate()
    {
        // 保持一个向着z轴的速度
        Vector3 velocity = rb.velocity;
        velocity.x = 0;
        velocity.z = 3f;
        rb.velocity = velocity;

        if (Input.GetMouseButton(0))
        {
            
        }
    }

    public void OnExit()
    {
        
    }
}
