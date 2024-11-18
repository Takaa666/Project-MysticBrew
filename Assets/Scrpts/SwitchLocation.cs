using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLocation : MonoBehaviour
{
    public GameObject frontDeskCanvas; // Canvas Front Desk
    public GameObject kitchenCanvas;   // Canvas Dapur

    public GameObject frontDeskCamera;     // Camera untuk Front Desk
    public GameObject kitchenCamera;       // Camera untuk Dapur

    void Start()
    {
        // Set awal
        ShowFrontDesk();
    }

    // Method untuk membuka canvas dapur pada display 2
    public void ShowKitchen()
    {
        frontDeskCanvas.SetActive(false);
        kitchenCanvas.SetActive(true);
        frontDeskCamera.SetActive(false); // Front Desk ke Display 1
        kitchenCamera.SetActive(true); ;
        // Atur kamera

    }
    // Method untuk membuka canvas front desk pada display 1
    public void ShowFrontDesk()
    {
        kitchenCanvas.SetActive(false);
        frontDeskCanvas.SetActive(true);

            // Atur kamera
        frontDeskCamera.SetActive(true); // Front Desk ke Display 1
        kitchenCamera.SetActive(false);   // Kitchen ke Display 2
    
    }
}
