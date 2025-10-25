using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ToggleAudio();
        }
    }

    private void ToggleAudio()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }
    }
}
