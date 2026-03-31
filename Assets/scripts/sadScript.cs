using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sadScript : MonoBehaviour
{
    public GameObject door;
   
    public GameObject soundobject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key2"))
        {
            Destroy(gameObject);
            Animation doorAnimation = door.GetComponent<Animation>();
            if (doorAnimation != null)
            {
                doorAnimation.Play("OpenDinnerRoomDoor");
            }
       if (soundobject != null)
            {
                AudioSource audioSource = soundobject.GetComponent<AudioSource>();
                if (audioSource != null)
                {
                    audioSource.Play();
                }
            }
        }
    }
}
