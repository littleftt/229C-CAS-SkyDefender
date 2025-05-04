using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    private int score = 0;

    public static ScoreManager instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
        scoreText.text = "Score : " + score.ToString();
        highscoreText.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "Score : " + score.ToString();

        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
            highscoreText.text = score.ToString();
        }
    }
}
