using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private Transform playerCamera;
    public float wallOffset = 0.1f;

    private void Start()
    {
        playerCamera = Camera.main.transform;
    }

    private void LateUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out hit))
        {
            float distance = Vector3.Distance(playerCamera.position, hit.point);
            if (distance < wallOffset)
            {
                playerCamera.position = hit.point - playerCamera.forward * wallOffset;
            }
        }
    }
}