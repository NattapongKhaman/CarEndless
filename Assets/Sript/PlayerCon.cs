using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCon : MonoBehaviour
{

    public GameObject maxMove;
    public float speed = 1;
    public int hp = 3; 
    public AudioClip [] Sounds;
    
    private AudioSource audioSource;
    private float horizontalInput = 0;
    private InputAction movementAction;
    void Start()
    {
        //หาปุ่ม
        movementAction = InputSystem.actions.FindAction("Move");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //รับค่าจากคีบอร์ด
        Vector2 input = movementAction.ReadValue<Vector2>();
        horizontalInput = input.x;
        //ขยับซ้ายขวา
        if (input.x != 0 && hp != 0)
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }
        //ปรับไม่ให้ออกนอกถนน
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

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Item"))
        {
            audioSource.PlayOneShot(Sounds[0]);
        }

        if (other.collider.CompareTag("Enemy"))
        {
            audioSource.PlayOneShot(Sounds[1]);
        }
    }
    
}
