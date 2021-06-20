using System.Collections;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public new AnimateDoor animation;

    public enum DoorType 
    { close, open, lockedOpen};

    #pragma warning disable 0649
    [SerializeField] DoorType doorType;
    #pragma warning disable 0649


    //switch stateme to avoid having to use else if chains
    //and it also reads way cleaner 
    private void OnTriggerEnter(Collider other)
    {

        switch (doorType)
        {
            case DoorType.close:
                {             
                     if (other.gameObject.tag == "Player")
                    {
                        animation.CloseDoor();
                        Destroy(GetComponent<Collider>());
                    }
                    break;
                }
            case DoorType.open:
                {
                    if (other.gameObject.tag == "Player") 
                    {
                        animation.OpenDoor();
                    }
                    break; 
                }
            case DoorType.lockedOpen:
                {
                    if (other.gameObject.tag == "Key")
                    {
                        Destroy(GetComponent<Collider>());
                        AudioSource source = GetComponent<AudioSource>();

                        //I use a corutine here so the unlock and open sounds don't overlap
                        StartCoroutine(WaitForCloseSound(source));                      
                      
                    }
                    break;
                }
        }   
    }

    IEnumerator WaitForCloseSound(AudioSource source)
    {
        source.Play();
        yield return new WaitForSeconds(1.2f);

        //door gets opened after unlock sound finished playing; 
        animation.OpenDoor();

    }
    
}
