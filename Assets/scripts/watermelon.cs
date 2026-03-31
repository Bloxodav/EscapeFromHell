using UnityEngine;

public class Watermelon : MonoBehaviour
{
    public GameObject watermelon;
    public GameObject watermelonHalf1;
    public GameObject watermelonHalf2;
    public GameObject key;

    private bool isCut = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isCut && other.CompareTag("knife"))
        {
            isCut = true;
            Cut();
        }
    }

    private void Cut()
    {
        watermelon.SetActive(false);

        watermelonHalf1.SetActive(true);
        watermelonHalf2.SetActive(true);
        key.SetActive(true);
    }
}