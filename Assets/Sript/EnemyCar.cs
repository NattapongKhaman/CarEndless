using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCar : MonoBehaviour
{
    private Road road;
    private PlayerCon playerCon;
    private AudioSource audioSource;
    private UI ui;
    
    void Start()
    {
        // รับค่า
        road = GameObject.Find("RoadMain").GetComponent<Road>();
        playerCon = GameObject.Find("Player").GetComponent<PlayerCon>();
        ui =GameObject.Find("Canvas").GetComponent<UI>();

        
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
            if(CompareTag("Enemy")){
                playerCon.hp --;
                if (playerCon.hp > 0)
                {
                      Destroy(this.gameObject);
                }
                else
                {
                    Invoke("LoadScene",0.5f);
                }
            }
            else if (CompareTag("Item"))
            {
                ui.itemScore+=1;
                road.speed *= 1.2f;
                Destroy(this.gameObject);
            }
            
            
            
        }
    }

    void LoadScene()
    {
        SceneManager.LoadSceneAsync(2);
    }
    
    
}
