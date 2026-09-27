using UnityEngine;
using UnityEngine.InputSystem;

public class cameraScript : MonoBehaviour
{
    public GameObject frog;
     InputAction click;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        click = InputSystem.actions.FindAction("Click");
    }

    // Update is called once per frame
    void Update()
    {
        if(click.WasPressedThisFrame())
        {
            Instantiate(frog);
        }
    }
}
