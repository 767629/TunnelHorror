using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool closeTrigger = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Close the door");
            myDoor.SetBool("Open", false);
        }
    }

}




