using UnityEngine;

public class StateMachine
{
    public State currentState, lastState;

    public IdleState idleState;
    public WalkState walkState;
    public AttackState attackState;

    public StateMachine(EnemyScript enemy)
    {
        idleState = new IdleState(enemy, this);
        walkState = new WalkState(enemy, this);
        attackState = new AttackState(enemy, this);
    }

    public void Init(State startingState)
    {
        currentState = startingState;
        lastState = null;
        startingState.Enter();
    }
    public void ChangeState(State newState)
    {
        currentState.Exit();
        lastState = currentState;
        currentState = newState;
        newState.Enter();
    }
    public void Update()
    {
        currentState.Update();
    }

    public void FixedUpdate()
    {
        currentState.FixedUpdate();
    }







}
