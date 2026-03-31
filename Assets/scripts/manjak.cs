using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manjak : MonoBehaviour
{
    public GameObject maniak;
    void Start()
    {
        Animation doorAnimation = maniak.GetComponent<Animation>();
        if (doorAnimation != null)
        {
            doorAnimation.Play("Idle_gun");
        }
    }

  
    void Update()
    {
        
    }
}
