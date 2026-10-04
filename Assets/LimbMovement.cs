using UnityEngine;
using UnityEngine.AI;

public class LimbMovement : MonoBehaviour
{
    public Transform targetObject;
    public Transform mainBody;
    public Vector3 targetLocation;
    public Rigidbody limb;

    public float moveSpeed;
    public float distanceToMove;

    public bool canMove = true;

    public bool inMovement;

    public LimbMovement otherFoot;

    public LayerMask environment;

    public float footCheckRange = 1.5f;
    public Transform defaultLocation;

    public NavMeshAgent controller;

    public Vector3 footPos;

    private void Start()
    {
        targetLocation = targetObject.position;

    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(limb.position, targetObject.position) > distanceToMove)
        {
            if (canMove && !otherFoot.inMovement)
            {
                canMove = false;

                //Raycast down from target and set the targetLocation y to be where it hits
                RaycastHit hit;
                if(Physics.Raycast(targetObject.position, Vector3.down, out hit, footCheckRange, environment))
                {
                    targetLocation = hit.point;
                }
                else
                {
                    targetLocation = defaultLocation.position;
                }

            }

        }
        else
        {
            canMove = true;
        }

        if (controller.velocity.magnitude < .125f)
        {
            targetLocation = defaultLocation.position;
        }

        limb.linearVelocity = ((targetLocation - limb.position) * moveSpeed);

        inMovement = !canMove;



    }
}
