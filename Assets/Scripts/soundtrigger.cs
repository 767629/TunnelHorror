using UnityEngine;

public class soundtrigger : MonoBehaviour
{
    public Collider player;
    public AudioSource audiosource;
    public AudioClip audioclip;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player")) ;
        {
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
