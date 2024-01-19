using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour

    


{
    public Birdscript bird;
    public pause pause1; // add audio 
   


    [Header("------------Audio Source------------")]
    [SerializeField] AudioSource musicSrc;
    [SerializeField] AudioSource sfxSrc;
    [SerializeField] AudioSource sfxSrcNoLoop;

    [Header("------------Audio clip------------")]
    public AudioClip background;
    public AudioClip flyingPlane;
    public AudioClip wasted;
    public AudioClip click;

    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<Birdscript>();
        pause1 = GameObject.FindGameObjectWithTag("Audio").GetComponent<pause>();

        
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
            PauseAudio();
            sfxSrcNoLoop.clip = wasted;
            sfxSrcNoLoop.Play();
        }
    }

    public void buttonClick1()
    {
        sfxSrcNoLoop.clip = click;
        sfxSrcNoLoop.Play();
    }

    public void PauseAudio()
    {
            musicSrc.Pause();
            sfxSrc.Pause();
    }

    public void ResumeAudio()
    {
        musicSrc.UnPause();
        sfxSrc.UnPause();
    }

}
