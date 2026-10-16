using UnityEngine;

public class AttackState : State
{
    float attackTime;
    public AttackState(EnemyScript enemy, StateMachine sm) : base(enemy, sm)
    {
    }

    public override void Enter()
    {
        base.Enter();
        enemy.anim.SetBool("Attack", true);
    }

    
    public override void Update()
    {
        
    }
}
