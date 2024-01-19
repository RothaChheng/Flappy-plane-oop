using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;



public class Logicscript : MonoBehaviour
{
    int playerScore = 0;
    int highScore = 0; // highScore
    public Text scoreText;
    public Text highScoreText; // highScore Text
    public string SceneName; // bestScore Scene
    public GameObject gameOverScreen;
    public string gameScene;


    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    void Update()
    {
        // Check for the "R" key press to reset the high score
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteKey("HighScore");
        }
    }

    [ContextMenu("Increase Score")]

    // checking is gameOver 
    public bool isGameOver()
    {
        return gameOverScreen.activeSelf;
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    // activate gameover screen

    public void gameOver()
    {
            gameOverScreen.SetActive(true);  
    }



    public void addScore()
    {
        if (!isGameOver())
        {
            playerScore = playerScore + 1;
            scoreText.text = playerScore.ToString();

        }

        if (playerScore > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            highScoreText.text = playerScore.ToString();
        }

    }

    public void bestScoreScene()
    {
        SceneManager.LoadScene(SceneName);

    }
    public void gameOverOrBestScore()
    {
        if (playerScore > highScore)
        {
            bestScoreScene();
        }
        else
        {
            gameOver();
        }
    }
  
}


