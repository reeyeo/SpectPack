using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTargetController : MonoBehaviour
{
    // Array untuk menyimpan referensi ke semua image targets
    public GameObject[] imageTargets;

    // Metode untuk mematikan semua image targets dan menyalakan satu target tertentu
    public void ActivateImageTarget(int index)
    {
        // Matikan semua image targets
        for (int i = 0; i < imageTargets.Length; i++)
        {
            if (imageTargets[i] != null)
            {
                imageTargets[i].SetActive(false);
            }
        }

        // Nyalakan image target yang sesuai dengan index yang diberikan
        if (index >= 0 && index < imageTargets.Length && imageTargets[index] != null)
        {
            imageTargets[index].SetActive(true);
        }
        else
        {
            Debug.LogWarning("Index out of range or image target is null.");
        }
    }
}

