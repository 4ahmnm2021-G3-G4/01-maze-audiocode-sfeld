﻿using System.Collections;
using UnityEngine;


public class LoopWithOffset : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;
    public float timeBetweenSounds; 
      
    void Start()
    {
        StartCoroutine(SoundLoop());
    }


    //If you want to play it forever
    IEnumerator SoundLoop()    {

        while (true)
        { //or for(;;){
            yield return new WaitForSeconds(timeBetweenSounds);
            audioSource.clip = audioClip; 
            audioSource.Play();
        }
    }
}
