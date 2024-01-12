using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Logicscript : MonoBehaviour
{
    int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;

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

    }
}
