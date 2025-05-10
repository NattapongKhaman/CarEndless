using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsEnemy;
    public GameObject[] spawnPoints;
    
    private int prefabIndex;
    private int spawnIndex;
    private PlayerCon playerCon;
    void Start()
    {
        //หา script Playercon 
        playerCon = GameObject.Find("Player").GetComponent<PlayerCon>();
        // ทำซ้ำ
        InvokeRepeating("spawn",1,1.5f);
    }
    
    void Update()
    {

    }
    
   // เสกรถ
   void spawn()
    {
        if (playerCon.hp != 0)
        {
            // สุ่มตำแน่งกับจุดเกิดรถ
            prefabIndex = Random.Range(0,prefabsEnemy.Length);
            spawnIndex  = Random.Range(0,spawnPoints.Length);  
            // สร้างรถ
            Instantiate(prefabsEnemy[prefabIndex], spawnPoints[spawnIndex].transform.position, prefabsEnemy[prefabIndex].transform.rotation);
        }

    }
}
