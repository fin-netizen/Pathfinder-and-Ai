using UnityEngine;
using UnityEngine.AI;

public enum EnemyStates
{
    Idle,
    MoveAway,
}
public class EnemyScript : MonoBehaviour
{
    EnemyStates state;
    Vector3 destinationPoint;
    public NavMeshAgent agent;
    public float inBetweenDistance = 10f;
    public float range = 20f;
    public float walkTimer = 3f;
    public float idleTimer = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        state = EnemyStates.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        DoLogic();
    }

    public void DoLogic()
    {
        if(state == EnemyStates.Idle)
        {
            DoIdle();
        }
        if(state == EnemyStates.MoveAway)
        {
            MoveAwayState();
        }
    }

    void MakeTargetPoint()
    {
        destinationPoint = transform.position;
        float x, z;

        x = Random.Range(-range, range);

        if (x < 0)
        {
            x -= inBetweenDistance;
        }
        else
        {
            x += inBetweenDistance;
        }
        z = Random.Range(-range, range);

        if (z < 0)
        {
            z -= inBetweenDistance;
        }
        else
        {
            z += inBetweenDistance;
        }
        destinationPoint.x = x;
        destinationPoint.z = z;
        destinationPoint.y = transform.position.y;
        agent.SetDestination(destinationPoint);
    }
    void DoIdle()
    {
        walkTimer = 3;
        idleTimer -= Time.deltaTime;
        if(idleTimer <= 0)
        {
            MakeTargetPoint();
            state = EnemyStates.MoveAway;
        }
    }
    void MoveAwayState()
    {
        float distance = Vector3.Distance(destinationPoint, transform.position);

        if(distance < 3.0f)
        {
            idleTimer = 3;
            walkTimer -= Time.deltaTime;
            if(walkTimer <= 0)
            {
                state = EnemyStates.Idle;
            }
        }
    }





}
