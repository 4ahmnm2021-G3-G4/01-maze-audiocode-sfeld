using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public int ammountOfCollected;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            ammountOfCollected++;
            Destroy(collision.gameObject);
        }
    }


}
