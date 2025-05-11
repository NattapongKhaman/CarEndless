using UnityEngine;

public class Road : MonoBehaviour
{
    
    public float speed = 0.1f;
    private Vector3 startPos;
    private PlayerCon playerCon;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //รับค่า จุดรัถนน กับ PlayerCon
        startPos = transform.position;
        playerCon = GameObject.Find("Player").GetComponent<PlayerCon>();
    }

    // Update is called once per frame
    void Update()
    {
        // หยุดเมื่อตาย
        if (playerCon.hp == 0)
        {
            speed = 0;
        }
        //วนถนน
        if (transform.position.z < -20)
        {
            transform.position = startPos;
        }
        //ขยับถนน
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);
    }
    
}
