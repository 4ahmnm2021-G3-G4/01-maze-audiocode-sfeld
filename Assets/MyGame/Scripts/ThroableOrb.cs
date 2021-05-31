using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroableOrb : MonoBehaviour
{
    public AudioClip throwSound;
    public AudioClip hitSound;

    public GameObject target;
    AudioSource source;


    private void Start()
    {
        source = GetComponent<AudioSource>(); 
    }
    public void playThrowSound()
    {
        source.clip = throwSound;
        source.Play(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == target)
        {
            print("collide with target");
            source.clip = hitSound;
            source.Play();

        }
        else
            print("wrong collider"); 
    }
}
