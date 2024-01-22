using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting; // Importing necessary libraries for using Unity's Visual Scripting API
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject pauseMenu; // Reference to the pause menu UI game object
    public static bool isPaused; // Flag to track if the game is paused or not
    public string sceneName;
    public AudioManger audio1; // call Audio Manager
    public Birdscript bird; // call birdScript

    void Start()
    {
        pauseMenu.SetActive(false); // Deactivates the pause menu UI at the start
        audio1 = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManger>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<Birdscript>();

    }

    // Update is called once per frame
    void Update()
    {
        // Checks for the Esc key input to handle the game pause/resume logic
        if (Input.GetKeyDown(KeyCode.Escape) && bird.birdIsAlive)
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
        Debug.Log("Pausing Game"); // Logs a message to the console
        pauseMenu.SetActive(true); // Sets the pause menu UI to be active
        Time.timeScale = 0f; // Freezes the in-game time to 0, effectively pausing the game
        isPaused = true; // Sets the isPaused flag to true
        audio1.PauseAudio();
    }

    // Resumes the game
    public void ResumeGame()
    {
        Debug.Log("Resuming Game"); // Logs a message to the console
        pauseMenu.SetActive(false); // Deactivates the pause menu UI
        Time.timeScale = 1f; // Restores the in-game time to normal, resuming the game
        isPaused = false; // Sets the isPaused flag to false
        audio1.ResumeAudio();
    }

    // back to menu 
    public void backToMenu()
    {
        SceneManager.LoadScene(sceneName);

    }

}
