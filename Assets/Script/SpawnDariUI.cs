using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Include the UI namespace

public class SpawnDariUI : MonoBehaviour
{
    public GameObject prefabToSpawn; // Assign your prefab in the Inspector
    public Transform spawnLocation; // Optional: a specific location to spawn

    void Start()
    {
        // Get the Button component from the UI button and add a listener to it
        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(SpawnPrefab);
        }
    }

    // Method to spawn the prefab
    void SpawnPrefab()
    {
        if (prefabToSpawn != null)
        {
            // Instantiate the prefab at the spawn location or at the origin
            Instantiate(prefabToSpawn, spawnLocation ? spawnLocation.position : Vector3.zero, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Prefab to spawn is not assigned.");
        }
    }

    void Update()
    {
        
    }
}
