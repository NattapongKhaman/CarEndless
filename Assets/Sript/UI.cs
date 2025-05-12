using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI highScoretext;
    public TextMeshProUGUI itemScoretext;
    public TextMeshProUGUI hpemScoretext;
    private float time;
    private GameManager gm;
    private int score;
    private int highScore;
    private PlayerCon playerCon;
    void Start()
    {
        playerCon =GameObject.Find("Player").GetComponent<PlayerCon>();
        gm = GameManager.instance;
        highScore = gm.highScore;
        
    }

    // Update is called once per frame
    void Update()
    {   
        //แต้ม
        if (playerCon.hp != 0)
        {
             time += Time.deltaTime;
             TimeScore();
        }
        else
        {
         SaveScore();   
        }
        // UI
        scoretext.text = "Score: " + score.ToString();
        highScoretext.text = "High Score: " + highScore.ToString();
        itemScoretext.text = ": X" + gm.GetItemscore.ToString(); 
        hpemScoretext.text = ": X" + playerCon.hp.ToString();
        
        
    }

    void SaveScore()
    {
        gm.score = score;
        gm.highScore = highScore;
    }

    //นับแต้ม
    void TimeScore()
    {
        if (time >=1)
        {
            if (highScore > score)
            {
                score +=1;
            }
            else
            {
                score +=1;
                highScore =score;
            }
        }
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }
}
