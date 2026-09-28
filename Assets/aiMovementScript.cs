using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class aiMovementScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public float walkRange;

    unitManager manager;

    public bool canBeOrdered = true;


    public List<Vector3> targetList;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = FindFirstObjectByType<unitManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance <= .5f)
        {
            if(targetList.Count > 0)
            {
                agent.destination = targetList[0];
                targetList.Remove(targetList[0]);
            }    
        }
    }
}
