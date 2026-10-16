using UnityEngine;

public class State 
{
    protected EnemyScript enemy;
    protected StateMachine sm;

    
    public State(EnemyScript enemy, StateMachine sm)
    {
        this.enemy = enemy;
        this.sm = sm;
    }

    public virtual void Enter()
    {


    }
    public virtual void Update()
    {

    }
    public virtual void FixedUpdate() { }
    public virtual void Exit() { }  


    public void TestMethod(string text)
    {
        Debug.Log(text);
    }

}
