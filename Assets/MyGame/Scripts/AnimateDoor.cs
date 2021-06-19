using System.Collections;
using UnityEngine;

public class AnimateDoor : MonoBehaviour
{

    public Vector3 rotationStepSize;
    public Vector3 closeRotation; 
    

    public float speed = 1.0F;
    private float startTime;
    // Start is called before the first frame update

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
        while(gameObject.transform.rotation.eulerAngles.y > closeRotation.y)
        {
            gameObject.transform.Rotate(rotationStepSize);
            yield return 1; 
        }

    }
}
