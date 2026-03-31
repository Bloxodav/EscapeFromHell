using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class the_end : MonoBehaviour
{
    public GameObject door;

    public GameObject soundobject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key3"))
        {
            Destroy(gameObject);
            Animation doorAnimation = door.GetComponent<Animation>();
            if (doorAnimation != null)
            {
                doorAnimation.Play("OpenLiving");
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
