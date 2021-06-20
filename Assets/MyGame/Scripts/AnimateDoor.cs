using System.Collections;
using UnityEngine;

public class AnimateDoor : MonoBehaviour
{

    public Vector3 rotationStepSize;
    public Vector3 closeRotation;
    public AudioSource audioSource;
    public AudioClip closeSound; 

    
    private float startTime;
    // Start is called before the first frame update

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    public void CloseDoor()
    {
        
        StartCoroutine(RotateDoor(rotationStepSize));
    }

    public void OpenDoor()
    {
        StartCoroutine(RotateDoor(-rotationStepSize));
    }


    IEnumerator RotateDoor(Vector3 rotationStepSize)
    {
        audioSource.Play();
        while(gameObject.transform.rotation.eulerAngles.y > closeRotation.y)
        {
            gameObject.transform.Rotate(rotationStepSize);
            yield return 1; 
        }
        audioSource.clip = closeSound;
        audioSource.Play(); 
        

    }
}
