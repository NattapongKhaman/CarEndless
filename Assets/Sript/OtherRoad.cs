using System;
using UnityEngine;

public class OtherRoad : MonoBehaviour
{ 
    public GameObject road;
    public GameObject otherRoad;
    public float dawnMax = 30 ;
    
    private Vector3 startPos;
   
    private float speed;
    

    void Start()
    {
        
        startPos = otherRoad.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        speed = road.GetComponent<Road>().speed;
        if (transform.position.z < -dawnMax)
        {
            transform.position = startPos;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);

    }
}
