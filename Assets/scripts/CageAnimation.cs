using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageAnimation : MonoBehaviour
{
    public GameObject cage;
    public AnimationClip breakAnimation;
    public AnimationClip openAnimation;
    public GameObject mont;

    private Animation cageAnimation;
    private bool isMontActive = true;
    private MeshRenderer montRenderer;
    private MeshCollider montCollider;

    private void Start()
    {
        cageAnimation = cage.GetComponent<Animation>();
        montRenderer = mont.GetComponent<MeshRenderer>();
        montCollider = mont.GetComponent<MeshCollider>();

        if (cageAnimation == null)
        {
            Debug.LogError("CageAnimation script: Animation component not found on the cage object.");
        }

        if (montRenderer == null)
        {
            Debug.LogError("CageAnimation script: MeshRenderer component not found on the mont object.");
        }

        if (montCollider == null)
        {
            Debug.LogError("CageAnimation script: MeshCollider component not found on the mont object.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("mont") && isMontActive)
        {
            if (cageAnimation != null && breakAnimation != null)
            {
                StartCoroutine(PlayBreakAnimation());
            }
        }
    }

    private IEnumerator PlayBreakAnimation()
    {
        if (mont != null)
        {
            montRenderer.enabled = false;
            montCollider.enabled = false;
            isMontActive = false;
        }

        cageAnimation.clip = breakAnimation;
        cageAnimation.Play();

        yield return new WaitForSeconds(breakAnimation.length);

        if (cageAnimation != null && openAnimation != null)
        {
            cageAnimation.clip = openAnimation;
            cageAnimation.Play();

            yield return new WaitForSeconds(openAnimation.length);

            if (mont != null)
            {
                montRenderer.enabled = true;
                montCollider.enabled = true;
                isMontActive = true;
            }
        }
    }
}