using UnityEngine;
using UnityEngine.AI;


public class EnemyScript : MonoBehaviour
{
    public Animator anim;
    public Transform[] points;
    private NavMeshAgent agent;
    private int destPoint;
    StateMachine sm;
    
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destPoint = 0;
        GoToNextPoint();
        sm = new StateMachine(this);
        sm.Init(sm.idleState);
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GoToNextPoint();
        sm.Update();
    }

    private void FixedUpdate()
    {
        //do not put any of your own methods here - they go in the state files
        sm.FixedUpdate();
    }

    void GoToNextPoint()
    {
        if(points.Length == 0)
        {
            return;
        }
        agent.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }





}
