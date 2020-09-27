using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager audioManager;
    public AudioSource audioSource;
    public AudioClip narIntro;
    public AudioClip narGrtJob;
    public AudioClip narLostGame;
    public AudioClip narMHFeelBetter;
    public AudioClip narTimeUP;

    private void Awake()
    {
        audioManager = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void PlayNarIntroAudio()
    {
        audioSource.PlayOneShot(narIntro);
    }

    public void PlayNarGrtJob()
    {
        audioSource.PlayOneShot(narGrtJob);
    }

    public void PlayNarLostGame()
    {
        audioSource.PlayOneShot(narLostGame);
    }
    public void PlayNarMHFeelBetter()
    {
        audioSource.PlayOneShot(narMHFeelBetter);
    }
    public void PlayNarTimeUP()
    {
        audioSource.PlayOneShot(narTimeUP);
    }




}
