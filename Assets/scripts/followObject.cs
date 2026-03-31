using UnityEngine;

public class followObject : MonoBehaviour
{
    public Transform target; 

    private void Update()
    {
        if (target != null)
        {
            transform.position = target.position; 
           
        }
    }
}