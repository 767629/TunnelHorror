using UnityEngine;

public class Opendoor : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            myDoor.SetBool("Open", true);

        }
    }
}
