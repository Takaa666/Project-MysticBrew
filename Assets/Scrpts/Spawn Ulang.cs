using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpawnUlang : MonoBehaviour
{
    public Bahan foodItem; // Reference to the FoodItem (which contains the icon and prefab)
    public Vector3 respawnPosition; // Position to respawn the object

    private void Start()
    {
        if (foodItem != null)
        {
            // Set sprite GameObject sesuai icon FoodItem
            GetComponent<SpriteRenderer>().sprite = foodItem.icon;
        }

        // Set an initial respawn position if it's not set
        if (respawnPosition == Vector3.zero)
        {
            respawnPosition = transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object has entered the container
        if (other.CompareTag("Container")) // Assuming the container has the tag "Container"
        {
            RespawnObject();
        }
    }

    // Respawn the object using the food item prefab
    private void RespawnObject()
    {
        // Destroy the current object
        Destroy(gameObject);

        // Instantiate a new object using the food item prefab at the respawn position
        if (foodItem != null && foodItem.prefab != null)
        {
            Instantiate(foodItem.prefab, respawnPosition, Quaternion.identity);
            Debug.Log("Food item respawned at position: " + respawnPosition);
        }
        else
        {
            Debug.LogWarning("Food item prefab or icon is not assigned!");
        }
    }
}
