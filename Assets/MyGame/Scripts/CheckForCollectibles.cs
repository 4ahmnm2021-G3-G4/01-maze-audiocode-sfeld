
using UnityEngine;

public class CheckForCollectibles : MonoBehaviour
{
    public GameObject[] spheres;


    private void Start()
    {
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
        }
    }

}
