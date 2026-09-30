using UnityEngine;
using UnityEngine.InputSystem;

public class cardInteractionScript : MonoBehaviour
{
    public LayerMask cardLayer;

    public Transform selectedCard;

    public Transform cardAnchor;

    public Vector3 startPosition;
    public float snapBackSpeed;

    public Camera cam;

    Vector2 mousePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());


        if(Physics.Raycast(ray, out hit))
        {
            selectedCard.position = hit.point;
        }

    }
}
