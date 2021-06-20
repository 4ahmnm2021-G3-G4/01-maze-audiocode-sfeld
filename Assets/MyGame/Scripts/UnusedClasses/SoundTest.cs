using UnityEngine;

//this class was used for a past excercise but not in the game
public class SoundTest : MonoBehaviour
{
    public AudioSource audioSource;
 

    public void PlaySound(bool isPlaying)
    {
        if (isPlaying)
            audioSource.Play();
        else
            audioSource.Stop(); 
    }

   
}
