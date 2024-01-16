using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This class represents the main menu behavior in the game.
public class Mainmenu : MonoBehaviour
{
    // This method is called when the "Play" button is clicked and loads the game scene asynchronously.
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    // This method is called when the "Quit" button is clicked and logs a message and quits the application.
    public void QuitGame()
    {
        Debug.Log("QUIT!"); // Print "QUIT!" to the console
        Application.Quit(); // Quit the application
    }
}

