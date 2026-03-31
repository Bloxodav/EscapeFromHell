using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class please : MonoBehaviour
{
    public Camera mainCamera;
    public string wallTag;

    private bool isWallTouched = false;
    private Color originalColor;

    private void Start()
    {
        if (mainCamera == null)
        {
            // Если не указана камера, используем главную камеру
            mainCamera = Camera.main;
        }

        if (mainCamera != null)
        {
            originalColor = mainCamera.backgroundColor; // Сохраняем исходный цвет заднего фона камеры
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(wallTag) && !isWallTouched)
        {
            isWallTouched = true;
            SetCameraVisibility(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(wallTag) && isWallTouched)
        {
            isWallTouched = false;
            SetCameraVisibility(true);
        }
    }

    private void SetCameraVisibility(bool visible)
    {
        if (mainCamera != null)
        {
            if (visible)
            {
                mainCamera.backgroundColor = originalColor;
                mainCamera.clearFlags = CameraClearFlags.Skybox;
            }
            else
            {
                mainCamera.backgroundColor = Color.black;
                mainCamera.clearFlags = CameraClearFlags.SolidColor;
            }
        }
    }
}
