using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_1000 : MonoBehaviour
{
    protected Dictionary<State, IState> states = new Dictionary<State, IState>();
    protected IState currentState;
    protected Transform bodySpriteTransform => transform.GetChild(0);
    protected float walkBobTimer = 0f;
    protected float bodySpriteOriginY = 0f; // 角色原始位置的y坐标

    public virtual void Start()
    {
        states.Add(State.Idle, new IdleState_1000(this));

        currentState = states[State.Idle];
        currentState.OnEnter();
    }

    public virtual void Update()
    {
        currentState.OnUpdate();
    }
    public virtual void ChangeState(State newState)
    {
        if (currentState != null)
        {
            currentState.OnExit();
        }
        currentState = states[newState];
        currentState.OnEnter();
    }
    // 旋转角色朝向目标
    public virtual void RotateTowardsTarget(Vector2 direction)
    {
        if (direction.x > 0)
        {
            bodySpriteTransform.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (direction.x < 0)
        {
            bodySpriteTransform.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}

public enum State
{
    Idle,
    Walk,
    Run,
    Attack,
    Hit,
    Dead
}
