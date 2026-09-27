using UnityEngine;
using UnityEngine.AI;

public class aiMovementScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public float walkRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance <= .25f)
        {
            Vector2 x = (Random.insideUnitCircle * walkRange);
            agent.destination = transform.position + new Vector3(x.x, 0, x.y);
        }
    }
}
