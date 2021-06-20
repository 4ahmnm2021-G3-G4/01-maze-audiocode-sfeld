
using UnityEngine;

public class CheckForCollectibles : MonoBehaviour
{
    public GameObject[] spheres;
    GameObject key;

    private void Start()
    {
        key = GameObject.FindGameObjectWithTag("Key");
        key.SetActive(false);
        foreach (GameObject sphere in spheres)
        {
            sphere.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lamp") 
        {
            Collector collector = other.GetComponent<Collector>();
            
            for (int i = 0; i < collector.ammountOfCollected; i++)
            {
                spheres[i].SetActive(true); 

            }
            if (collector.ammountOfCollected >= 3)
            {
                key.SetActive(true);
            }
        }
    }

}
