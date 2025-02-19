using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float score;
    public float point;
    public bool isGame;
    public bool gotTomato;
    public float countdownTimerMax;
    public float countdownTimer;

    public TMP_Text scoreText;
    public TMP_Text countdownText;

    public GameObject gameOverPanel;
    public TMP_Text yourScoreText;

    public Spawner spawner;

    void Start()
    {
        ResetGame();    
    }

    void Update()
    {
        if (isGame)
        {
            if (countdownTimer > 0)
            {
                countdownTimer -= Time.deltaTime;
                countdownText.text = countdownTimer.ToString("0");
            }
            else
            {
                EndGame();
            }
        }
        else
        {
            Destroy(spawner);
        }
    }

    public void EndGame()
    {
        countdownText.text = "0";
        isGame = false;
        SetGameOverPanel();
    }

    public void Score()
    {
        score += point;
        scoreText.text = score + "";
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ResetGame()
    {
        Time.timeScale = 1;
        gameOverPanel.SetActive(false);
        isGame = true;
        score = 0;
        countdownText.text = countdownTimerMax.ToString("0");
        countdownTimer = countdownTimerMax;
        scoreText.text = score + "";
    }
    public void SetGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        yourScoreText.text = "Your Score: " + score;
    }
}
