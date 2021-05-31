using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDoor : MonoBehaviour
{

    public Vector3 rotationStepSize;
    public Vector3 closeRotation;

    public float speed = 1.0F;
    private float startTime;
    public float Speed;
    // Start is called before the first frame update

    public void closeDoor()
    {
        
        StartCoroutine(RotateDoor());
    }
    IEnumerator RotateDoor()
    {
        while(gameObject.transform.rotation.eulerAngles.y > closeRotation.y)
        {
            gameObject.transform.Rotate(rotationStepSize);
            yield return 1; 
        }

    }
}
