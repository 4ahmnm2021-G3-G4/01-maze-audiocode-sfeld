
using UnityEngine;

public class ThroableOrb : MonoBehaviour
{
   
    public AudioClip hitSound;
    public AudioClip throwSound;
    public AudioClip bridgeApearSound; 

    public GameObject target;
    public Vector3 defaultPos; 
    AudioSource source;
    bool isBeingThrown = false;

    GameObject[] bridgePieces;

    private void Start()
    {
        bridgePieces = GameObject.FindGameObjectsWithTag("BridgePiece");
        
        foreach (GameObject piece in bridgePieces)
        {
            piece.SetActive(false);
        }
          
        defaultPos = gameObject.transform.position; 

        source = GetComponent<AudioSource>(); 
    }
    public void playThrowSound()
    {
        isBeingThrown = true;
        source.clip = throwSound;
        source.Play(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        source.clip = hitSound;
        source.Play();
        if (collision.gameObject == target)
        {
            print("collide with target");

            source.clip = bridgeApearSound;
            source.Play(1000);

            foreach (GameObject piece in bridgePieces)
            {
                piece.SetActive(true);
            }
            
        }

        //resets ball back to it's initail position so it can be thrown again
        else if (isBeingThrown)
        {
            isBeingThrown = false;
            gameObject.transform.position = defaultPos; 
        }
        else
            print("wrong collider"); 
        
    }

    

}
