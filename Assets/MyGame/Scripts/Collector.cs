
using UnityEngine;

public class Collector : MonoBehaviour
{
    public int ammountOfCollected;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            ammountOfCollected++;

            Transform particles = collision.transform.Find("Particle System");
            particles.SetParent(transform); //parent paricles to the lamp so they'll follow the player;    
            particles.localScale = new Vector3(1, 1, 1); //correct for the scale change from parenting; 

            Destroy(collision.gameObject);

        }
    }


}
