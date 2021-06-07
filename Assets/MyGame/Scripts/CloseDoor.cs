using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public AnimateDoor animation;

    public enum DoorType
    { close, open, lockedOpen};

    #pragma warning disable 0649
    [SerializeField] DoorType doorType;
    #pragma warning disable 0649



    private void OnTriggerEnter(Collider other)
    {

        switch (doorType)
        {
            case DoorType.close:
                {             
                     if (other.gameObject.tag == "Player")
                    {
                    animation.CloseDoor();
                    }
                    break;
                }
            case DoorType.open:
                {
                    if (other.gameObject.tag == "Player") ;
                    {
                        animation.OpenDoor();
                    }
                    break; 
                }
            case DoorType.lockedOpen:
                {
                    if (other.gameObject.tag == "Key")
                    {
                        animation.OpenDoor();
                    }
                    break;
                }
        }
      //
    }
}
