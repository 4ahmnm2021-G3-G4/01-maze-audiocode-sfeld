using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundTest : MonoBehaviour
{
    public AudioSource audioSource;


    public void playSound(bool isPlaying)
    {
        if (isPlaying)
            audioSource.Play();
        else
            audioSource.Stop(); 
    }
}
