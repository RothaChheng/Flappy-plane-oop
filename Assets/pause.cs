using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting; 
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject pauseMenu; // Reference to the pause menu UI game object
    public static bool isPaused; // Flag to track if the game is paused or not

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false); // Deactivates the pause menu UI at the start
    }

    // Update is called once per frame
    void Update()
    {
        // Checks for the Esc key input to handle the game pause/resume logic
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame(); // If the game is already paused, resume the game
            }
            else
            {
                PauseGame(); // If the game is not paused, pause the game
            }
        }
    }

    // Pauses the game
    public void PauseGame()
    { 
        pauseMenu.SetActive(true); // Sets the pause menu UI to be active
        Time.timeScale = 0f; // Freezes the in-game time to 0, effectively pausing the game
        isPaused = true; // Sets the isPaused flag to true
    }

    // Resumes the game
    public void ResumeGame()
    {
        pauseMenu.SetActive(false); // Deactivates the pause menu UI
        Time.timeScale = 1f; // Restores the in-game time to normal, resuming the game
        isPaused = false; // Sets the isPaused flag to false
    }

    public void GoToMainmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mainmenu");
    }
}
