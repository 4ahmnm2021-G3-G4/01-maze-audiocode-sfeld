using UnityEngine;

//this class was used for a past excercise but not in the game
public class AudioController : MonoBehaviour
{

    private int a = 4;
    private int b = 5;
    public bool debug = true;
    
    // Start is called before the first frame update
    void Start()
    {
        if (debug)
        {
            Debug.Log("a = " + a + " b = " + b);
        }
    }

}
