using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceManagerScript : MonoBehaviour
{
    public string gameplay;
    public GameObject aboutScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }  

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playGame1()
    {
        SceneManager.LoadScene(gameplay);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void aboutScreenPop()
    {
        aboutScreen.SetActive(true);
    }
}
