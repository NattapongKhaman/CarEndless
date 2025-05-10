using System;
using UnityEngine;

public class EnemyCar : MonoBehaviour
{
    private Road road;
    private PlayerCon playerCon;
    
    void Start()
    {
        // รับค่า
        road = GameObject.Find("RoadMain").GetComponent<Road>();
        playerCon = GameObject.Find("Player").GetComponent<PlayerCon>();
    }
    
    void Update()
    {   
        //ขยับ
        transform.Translate(Vector3.forward * Time.deltaTime * -road.speed,Space.World);
        //ออกนอกจอ
        if (transform.position.z < - 40)
        {
            Destroy(this.gameObject);
        }
    }
    // เช็คชน
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerCon.hp -= 1;
            Destroy(this.gameObject);
        }
    }
}
