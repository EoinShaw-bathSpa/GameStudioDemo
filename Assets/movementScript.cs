using UnityEngine;
using UnityEngine.InputSystem;

public class movementScript : MonoBehaviour
{
    public CharacterController controller;
    public float moveForce;
    public Vector3 moveInput;

    InputAction moveAction;

    public Transform mesh;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        //Inputs
        moveInput = new Vector3(moveAction.ReadValue<Vector2>().x, 0, moveAction.ReadValue<Vector2>().y);
    }


    private void FixedUpdate()
    {
        controller.Move(((moveInput * moveForce) + Physics.gravity) * Time.deltaTime);

        

        if(moveInput.magnitude > .125f)
        {
            transform.rotation = Quaternion.Euler(0, Mathf.Atan2(moveInput.x, moveInput.z) * Mathf.Rad2Deg, 0);
        }
    }




}
