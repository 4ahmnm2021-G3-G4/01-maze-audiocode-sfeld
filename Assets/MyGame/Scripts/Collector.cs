using UnityEngine;

public class Collector : MonoBehaviour
{
    public int ammountOfCollected;
    public AudioClip pickUpSound; 
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            ammountOfCollected++;
            GetComponent<AudioSource>().clip = pickUpSound;
            GetComponent<AudioSource>().Play(); 

            //parent paricles or kois to the lamp so they'll follow the player; 

            if (collision.transform.Find("Particle System"))
            {
            Transform particles = collision.transform.Find("Particle System");
            particles.SetParent(transform);    
            particles.localScale = new Vector3(1, 1, 1); //correct for the scale change from parenting; 
            }

            else if (collision.transform.parent.Find("Kois"))
            {
                Transform kois = (collision.transform.parent.Find("Kois"));
                kois.SetParent(transform);
                kois.localScale = new Vector3(0.007812348f, 0.007812348f, 0.007812348f);  //these numbers were just kopied out of play mode
                kois.localPosition = new Vector3(0.00728f, -0.00089f, -0.00401f);
            }

            Destroy(collision.gameObject); 

        }
    }


}
