using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;

    // Add 
    public Logicscript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();
    }

    // Add birdIsAlive in to condition if
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapstrength;
        }

        // out of screen by ChhenG
        if (transform.position.y > 19.9f || transform.position.y < -14.9f)
        {
            // Call a function to handle game over
            logic.gameOverOrBestScore();
            birdIsAlive = false;
        }
    }

    // game over if plane hit pipe
    private void OnCollisionEnter2D (Collision2D collision)
    {
        logic.gameOverOrBestScore();
        birdIsAlive = false;

    }
}
