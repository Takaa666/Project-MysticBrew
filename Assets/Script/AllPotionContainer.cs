using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPotionContainer : MonoBehaviour
{
    public SpriteRenderer cauldronSpriteRenderer; // Reference to the SpriteRenderer to change the color
    public List<Bahan> currentIngredients = new List<Bahan>(); // List of ingredients in the container
    public Potion[] allPotions; // Array of all potion ScriptableObjects
    public Transform potionSpawnPoint; // Transform to define where the potion spawns

    private bool potionCreated = false; // Tracks if a potion has been created
    private bool combinationFailed = false; // Tracks if the combination has failed
    private Potion createdPotion; // Tracks the created potion to spawn its prefab

    private void OnTriggerEnter2D(Collider2D other)
    {
        Drag draggableFood = other.GetComponent<Drag>();

        if (draggableFood != null && draggableFood.foodItem != null)
        {
            AddIngredient(draggableFood.foodItem);
            Destroy(other.gameObject);
        }
    }

    // Add ingredient to the container and check the combination
    private void AddIngredient(Bahan ingredient)
    {
        currentIngredients.Add(ingredient);
        CheckCombination();
    }

    // Check if the ingredients match any combined potion recipe
    private void CheckCombination()
    {
        bool matchFound = false;

        foreach (Potion potion in allPotions)
        {
            if (IsCombinationMatch(potion.ingredients))
            {
                createdPotion = potion; // Store the created potion
                CreatePotion(potion);
                ClearContainer();
                matchFound = true;
                potionCreated = true; // Mark that a potion has been created
                cauldronSpriteRenderer.color = Color.magenta; // Change to purple on success
                break;
            }
        }

        if (!matchFound)
        {
            bool lengthMatchFound = false;
            foreach (Potion potion in allPotions)
            {
                if (currentIngredients.Count == potion.ingredients.Length)
                {
                    lengthMatchFound = true;
                    break;
                }
            }

            if (lengthMatchFound)
            {
                cauldronSpriteRenderer.color = Color.black;
                combinationFailed = true; // Mark that the combination failed
                Debug.Log("Combination failed! The cauldron turned black.");
            }
            else
            {
                cauldronSpriteRenderer.color = Color.white; // Reset to default if no match
            }
        }
    }

    // Check if the ingredients match the required ingredients for a potion
    private bool IsCombinationMatch(Bahan[] requiredIngredients)
    {
        if (currentIngredients.Count != requiredIngredients.Length)
        {
            return false;
        }

        foreach (Bahan requiredIngredient in requiredIngredients)
        {
            if (!currentIngredients.Contains(requiredIngredient))
            {
                return false;
            }
        }

        return true;
    }

    // Create the specified potion
    private void CreatePotion(Potion potion)
    {
        Debug.Log("Potion created: " + potion.potionName);
    }

    // Clear the container
    private void ClearContainer()
    {
        currentIngredients.Clear();
        combinationFailed = false; // Reset the failure flag
        cauldronSpriteRenderer.color = Color.white; // Reset cauldron color to normal
    }

    private void Update()
    {
        if (potionCreated && Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(mousePosition);

            if (collider != null && collider.gameObject == gameObject)
            {
                SpawnPotion();
                potionCreated = false; // Reset the potion creation flag
                cauldronSpriteRenderer.color = Color.white; // Reset cauldron color to normal after potion pickup
            }
        }

        if (combinationFailed && Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(mousePosition);

            if (collider != null && collider.gameObject == gameObject)
            {
                ClearContainer(); // Clear ingredients and reset color
                Debug.Log("Failed combination cleared. The cauldron color reset to normal.");
            }
        }
    }

    // Spawn the potion at the specified transform position
    private void SpawnPotion()
    {
        if (createdPotion != null && createdPotion.potionPrefab != null)
        {
            Instantiate(
                createdPotion.potionPrefab,
                potionSpawnPoint.position,
                potionSpawnPoint.rotation
            );
            Debug.Log(
                "Potion spawned: "
                    + createdPotion.potionName
                    + " at position: "
                    + potionSpawnPoint.position
            );
        }
        else
        {
            Debug.LogWarning("No potion prefab assigned for the created potion!");
        }
    }
}
