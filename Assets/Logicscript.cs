using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Logicscript : MonoBehaviour
{
    int playerScore = 0;
    int bestScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public string gameScene;

    void Start()
    {

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

    // activate gameover screen // bestscore scene

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
        PlayerPrefs.SetInt("HighScore", playerScore);

    }

    public void bestScoreScene()
    {
            SceneManager.LoadScene(gameScene);
    }

    public void gameOverOrBestScore()
    {
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            bestScoreScene();
        } else
        {
            gameOver();
        }

    }
}
