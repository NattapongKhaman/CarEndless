using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsEnemy;
    public GameObject[] spawnPoints;

    private int rng;
    private int prefabIndex;
    private int newPrefabIndex;
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
        //สุ่มแพทเทิร์น
        rng = Random.Range(0,5);
        if (playerCon.hp != 0)
        {
            //แพทเทิร์น 1
            if (rng == 0)
            {
                prefabIndex = Random.Range(0,prefabsEnemy.Length);
                Instantiate(prefabsEnemy[prefabIndex], spawnPoints[0].transform.position, prefabsEnemy[prefabIndex].transform.rotation);
                do
                {
                    newPrefabIndex = Random.Range(0,prefabsEnemy.Length);
                } while (newPrefabIndex == prefabIndex);
                Instantiate(prefabsEnemy[newPrefabIndex], spawnPoints[1].transform.position, prefabsEnemy[newPrefabIndex].transform.rotation);
            }
            //แพทเทิร์น 2
            if (rng == 1)
            {
                
                prefabIndex = Random.Range(0,prefabsEnemy.Length);
                Instantiate(prefabsEnemy[prefabIndex], spawnPoints[2].transform.position, prefabsEnemy[prefabIndex].transform.rotation);
                do
                {
                    newPrefabIndex = Random.Range(0,prefabsEnemy.Length);
                } while (newPrefabIndex == prefabIndex);
                Instantiate(prefabsEnemy[newPrefabIndex], spawnPoints[3].transform.position, prefabsEnemy[newPrefabIndex].transform.rotation);
            }
            //แพทเทิร์น 3
            if (rng == 2)
            {
                
                prefabIndex = Random.Range(0,prefabsEnemy.Length);
                Instantiate(prefabsEnemy[prefabIndex], spawnPoints[0].transform.position, prefabsEnemy[prefabIndex].transform.rotation);
                do
                {
                    newPrefabIndex = Random.Range(0,prefabsEnemy.Length);
                } while (newPrefabIndex == prefabIndex);
                Instantiate(prefabsEnemy[newPrefabIndex], spawnPoints[1].transform.position, prefabsEnemy[newPrefabIndex].transform.rotation);
                do
                {
                    prefabIndex = Random.Range(0,prefabsEnemy.Length);
                } while (prefabIndex == newPrefabIndex);
                Instantiate(prefabsEnemy[prefabIndex], spawnPoints[2].transform.position, prefabsEnemy[prefabIndex].transform.rotation);
            }
            //แพทเทิร์น 4
            if (rng == 3)
            {
                
                prefabIndex = Random.Range(0,prefabsEnemy.Length);
                Instantiate(prefabsEnemy[prefabIndex], spawnPoints[3].transform.position, prefabsEnemy[prefabIndex].transform.rotation);
                do
                {
                    newPrefabIndex = Random.Range(0,prefabsEnemy.Length);
                } while (newPrefabIndex == prefabIndex);
                Instantiate(prefabsEnemy[newPrefabIndex], spawnPoints[2].transform.position, prefabsEnemy[newPrefabIndex].transform.rotation);
                do
                {
                    prefabIndex = Random.Range(0,prefabsEnemy.Length);
                } while (prefabIndex == newPrefabIndex);
                Instantiate(prefabsEnemy[prefabIndex], spawnPoints[1].transform.position, prefabsEnemy[prefabIndex].transform.rotation);
            }
            //แพทเทิร์น 5
            if (rng == 4)
            {
                
                prefabIndex = Random.Range(0,prefabsEnemy.Length);
                Instantiate(prefabsEnemy[prefabIndex], spawnPoints[0].transform.position, prefabsEnemy[prefabIndex].transform.rotation);
                do
                {
                    newPrefabIndex = Random.Range(0,prefabsEnemy.Length);
                } while (newPrefabIndex == prefabIndex);
                Instantiate(prefabsEnemy[newPrefabIndex], spawnPoints[2].transform.position, prefabsEnemy[newPrefabIndex].transform.rotation);
            }
            //แพทเทิร์น 6
            if (rng == 5)
            {
                
                prefabIndex = Random.Range(0,prefabsEnemy.Length);
                Instantiate(prefabsEnemy[prefabIndex], spawnPoints[3].transform.position, prefabsEnemy[prefabIndex].transform.rotation);
                do
                {
                    newPrefabIndex = Random.Range(0,prefabsEnemy.Length);
                } while (newPrefabIndex == prefabIndex);
                Instantiate(prefabsEnemy[newPrefabIndex], spawnPoints[1].transform.position, prefabsEnemy[newPrefabIndex].transform.rotation);
            }
            


        }

    }
}
