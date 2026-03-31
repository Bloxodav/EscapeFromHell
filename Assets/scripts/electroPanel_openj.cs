using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electroPanel_openj : MonoBehaviour
{
    public GameObject door;
    public GameObject soundobject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("screw"))
        {
            Destroy(gameObject);
            if (soundobject != null)
            {
                AudioSource audioSource = soundobject.GetComponent<AudioSource>();
                if (audioSource != null)
                {
                    audioSource.Play();
                }
            }
            Rigidbody doorRig = door.GetComponent<Rigidbody>();
            if(doorRig != null)
            {
                doorRig.isKinematic = false;
            }
        }
        
    }
}