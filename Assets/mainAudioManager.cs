using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainAudioManager : MonoBehaviour
{

    [Header("------------Audio Source------------")]
    [SerializeField] AudioSource musicSrc;
    [SerializeField] AudioSource sfxSrc;

    [Header("------------Audio clip------------")]
    public AudioClip background;
    public AudioClip click;

    // Start is called before the first frame update
    void Start()
    {

        musicSrc.clip = background;
        musicSrc.Play();
    }

    public void clickButton()
    {
        sfxSrc.clip = click;
        sfxSrc.Play();
    }
}

