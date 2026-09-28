using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class unitManager : MonoBehaviour
{
    public Transform flag;

    public List<aiMovementScript> selectedUnits;

    InputAction click;

    public Camera cam;

    private void Start()
    {
        click = InputSystem.actions.FindAction("Click");
    }

    private void FixedUpdate()
    {
        if (click.WasPressedThisFrame())
        {
            /*
            RaycastHit hit;
            if(Physics.Raycast(cam.ScreenPointToRay(), out hit))
            {
                foreach(aiMovementScript unit in selectedUnits)
                {
                    unit.targetList.Add(hit.point);
                }
            }
            */
        }
    }
}
