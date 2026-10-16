using UnityEngine;

public class IdleState : State
{
    public float restTimer = 1f;
   public IdleState (EnemyScript enemy, StateMachine sm) : base(enemy, sm)
    {
    }

    public override void Enter()
    {
        Debug.Log("Idle state start");
        
    }
    public override void Exit()
    {
        Debug.Log("Idle state ending");
        
        enemy.StopAllCoroutines();
    }


    public override  void Update()
    {
        restTimer -= Time.deltaTime;
        if(restTimer <= 0)
        {
            sm.ChangeState(sm.walkState);
        }

    }

    public override void FixedUpdate()
    {
    }
}
