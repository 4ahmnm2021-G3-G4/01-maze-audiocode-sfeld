using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroableOrb : MonoBehaviour
{
    public AudioClip throwSound;
    public AudioClip hitSound;

    public GameObject target;
    public Vector3 defaultPos; 
    AudioSource source;
    bool isBeingThrown = false; 

    private void Start()
    {
        defaultPos = gameObject.transform.position; 
        source = GetComponent<AudioSource>(); 
    }
    public void playThrowSound()
    {
        isBeingThrown = true;
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
        else if (isBeingThrown)
        {
            isBeingThrown = false;
            gameObject.transform.position = defaultPos; 
        }
        else
            print("wrong collider"); 
    }

  
    
}
