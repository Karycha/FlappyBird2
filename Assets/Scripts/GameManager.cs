using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    public int points = 0;
   
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI FinalScoreText;
    public TextMeshProUGUI MaxScoreText;
    public int highScore;


    public void StartGame()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("highScore", 0);
    }

    private void ShowLoseUI()
    {
        Time.timeScale = 0;

       

        if(highScore < points)
        { 
            highScore = points;
            PlayerPrefs.SetInt("highScore", highScore);

        }
        else
        {
            PlayerPrefs.GetInt("highScore");
        }


         loseUI.SetActive(true);
        MaxScoreText.text = "Best Score: " + PlayerPrefs.GetInt("highScore");

    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");

    }


    public void OnGameOver()
    { 
        
        

        ShowLoseUI();
        Time.timeScale = 0;

    }

    public void UpdateScore()
    {
        points++;
        AudioManager.Instance.PlayPoint();
        scoreText.text = points.ToString();
        FinalScoreText.text = "Total score: " + points;
    }
}
