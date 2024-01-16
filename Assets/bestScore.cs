using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bestScore : MonoBehaviour
{
    public string gameplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            loadGamePlay();
        }
        
    }

    void loadGamePlay()
    {
        SceneManager.LoadScene(gameplay);
    }
}
