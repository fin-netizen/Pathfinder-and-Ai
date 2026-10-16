using UnityEngine;

public class IdleState : State
{
    public float restTimer = 3f;
   public IdleState (EnemyScript enemy, StateMachine sm) : base(enemy, sm)
    {
    }

    public override void Enter()
    {
        Debug.Log("Idle state start");
        enemy.anim.SetBool("Idle", true);
    }
    public override void Exit()
    {
        Debug.Log("Idle state ending");
        enemy.anim.SetBool("Idle", false);
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
