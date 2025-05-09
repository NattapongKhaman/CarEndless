using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCon : MonoBehaviour
{
    private float horizontalInput = 0;
    
    public GameObject maxMove;
    public float speed = 1;
    private InputAction movementAction;
    void Start()
    {
        movementAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = movementAction.ReadValue<Vector2>();
        horizontalInput = input.x;

        if (input.x != 0)
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }

        if (transform.position.x < -maxMove.transform.position.x)
        {
            transform.position = new Vector3(-maxMove.transform.position.x, 
                transform.position.y, transform.position.z);
        } 
        if (transform.position.x > maxMove.transform.position.x)
        {
            transform.position = new Vector3(maxMove.transform.position.x, 
                transform.position.y, transform.position.z);
        }
    }
}
