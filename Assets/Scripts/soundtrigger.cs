using UnityEngine;

public class Soundtrigger : MonoBehaviour
{
    public Collider player;
    public AudioSource audiosource;
    public AudioClip audioclip;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            audiosource.clip = audioclip;
            audiosource.Play();

        }

        {

        }

    }
}
