using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour

    


{
    public Birdscript bird;


    [Header("------------Audio Source------------")]
    [SerializeField] AudioSource musicSrc;
    [SerializeField] AudioSource sfxSrc;

    [Header("------------Audio clip------------")]
    public AudioClip background;
    public AudioClip flyingPlane;

    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<Birdscript>();

        
            musicSrc.clip = background;
            sfxSrc.clip = flyingPlane;
            musicSrc.Play();
            sfxSrc.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.birdIsAlive == false && musicSrc.isPlaying && sfxSrc.isPlaying)
        {
            musicSrc.Stop();
            sfxSrc.Stop();
        }

    }
}
