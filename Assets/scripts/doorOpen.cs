using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    public GameObject door;
    public GameObject zamok;
    public GameObject soundobject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key1"))
        {
            Destroy(gameObject);
            Animation doorAnimation = door.GetComponent<Animation>();
            if (doorAnimation != null)
            {
                doorAnimation.Play("OpenBoilerRoom");
            }
            Animation zamokAnimation = zamok.GetComponent<Animation>();
            if (zamokAnimation != null)
            {
                zamokAnimation.Play("TakeOff_2");
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
