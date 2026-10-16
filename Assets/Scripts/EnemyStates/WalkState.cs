using UnityEngine;

public class WalkState : State
{

    public WalkState(EnemyScript enemy, StateMachine sm) : base(enemy, sm)
    {
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Enter()
    {
        base.Enter();
        enemy.anim.SetBool("Walking", true);
    }
    public override void Exit()
    {
        base.Exit();
        enemy.anim.SetBool("Walking", false);
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }
}
