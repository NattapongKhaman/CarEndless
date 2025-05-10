using System;
using UnityEngine;

public class OtherRoad : MonoBehaviour
{ 
    public GameObject otherRoad;
    public float dawnMax = 30 ;
    private Vector3 startPos;
    private float speed;
    private Road roadMain;
    void Start()
    {
        //รับค้าจากRoad ที่อยู่ใน Roadmain
        roadMain = GameObject.Find("RoadMain").GetComponent<Road>();
        startPos = otherRoad.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //รับค่าความเร็วจากRoadMain
        speed = roadMain.GetComponent<Road>().speed;
        if (transform.position.z < -dawnMax)
        {
            transform.position = startPos;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        


    }
}
