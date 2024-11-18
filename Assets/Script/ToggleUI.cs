using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleUI : MonoBehaviour
{
    // List untuk UI GameObject yang akan diaktifkan
    public List<GameObject> uiElementsToActivate;

    // List untuk UI GameObject yang akan dinonaktifkan
    public List<GameObject> uiElementsToDeactivate;

    // Fungsi untuk mengaktifkan dan menonaktifkan UI sesuai list
    public void ToggleUIElements()
    {
        // Aktifkan semua UI dalam list uiElementsToActivate
        foreach (GameObject uiElement in uiElementsToActivate)
        {
            if (uiElement != null)
            {
                uiElement.SetActive(true);
            }
        }

        // Nonaktifkan semua UI dalam list uiElementsToDeactivate
        foreach (GameObject uiElement in uiElementsToDeactivate)
        {
            if (uiElement != null)
            {
                uiElement.SetActive(false);
            }
        }
    }
}
