using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int highScore;
    public int score;
    public int GetItemscore;

    void Awake()
    {
        if (instance == null)
        {
             instance = this;
             DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
}
