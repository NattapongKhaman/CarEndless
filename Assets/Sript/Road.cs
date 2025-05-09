using UnityEngine;

public class Road : MonoBehaviour
{
    private Vector3 startPos;
    public float speed = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -20)
        {
            transform.position = startPos;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);
    }
}
