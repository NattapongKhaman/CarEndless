using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    void Start()
    {

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            var gm = GameObject.Find("GameManager").GetComponent<GameManager>();
            var h = GameObject.Find("HighScore").GetComponent<TextMeshProUGUI>();
            var s = GameObject.Find("YouScore").GetComponent<TextMeshProUGUI>();
            h.text = "High Score : " + gm.highScore.ToString();
            s.text = "You  Score : " + gm.score.ToString();
        }
    }

    public void play()
    {
        SceneManager.LoadScene(1);
    }
    
}
