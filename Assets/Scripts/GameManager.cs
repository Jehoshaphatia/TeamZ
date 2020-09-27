using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayNarIntroAudio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PlayNarIntroAudio()
    {
        //play audio 2 seconds after game start
        yield return new WaitForSeconds(2);
        AudioManager.audioManager.PlayNarIntroAudio();

    
    }
}
