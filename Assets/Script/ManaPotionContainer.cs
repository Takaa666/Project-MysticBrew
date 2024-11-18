using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaPotionContainer : MonoBehaviour
{
    public SpriteRenderer cauldronSpriteRenderer; // Reference to the SpriteRenderer to change the color
    public List<Bahan> currentIngredients = new List<Bahan>(); // List of ingredients in the container
    public ManaPotion[] manaPotions;
    public GameObject potionPrefab; // Prefab of the potion to spawn when created
    public Vector3 potionSpawnPosition; // Position to spawn the created potion

    private bool potionCreated = false; // Tracks if a potion has been created

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

    // Check if the ingredients match any combined food item
    private void CheckCombination()
    {
        bool matchFound = false;

        foreach (ManaPotion manaPotion in manaPotions)
        {
            if (IsCombinationMatch(manaPotion.ingredients))
            {
                CreateManaPotion(manaPotion);
                ClearContainer();
                matchFound = true;
                potionCreated = true; // Mark that a potion has been created
                break;
            }
        }

        // Only turn black if no match is found and the number of ingredients matches the length of any recipe
        if (!matchFound)
        {
            bool lengthMatchFound = false;
            foreach (ManaPotion manaPotion in manaPotions)
            {
                // Check if the number of ingredients matches a recipe length
                if (currentIngredients.Count == manaPotion.ingredients.Length)
                {
                    lengthMatchFound = true;
                    break;
                }
            }

            if (lengthMatchFound)
            {
                // If the ingredients match the length of a recipe but don't form a correct combination, indicate failure
                cauldronSpriteRenderer.color = Color.black;
                Debug.Log("Combination failed! The cauldron turned black.");
            }
            else
            {
                // Reset to white if no recipe length is matched, meaning more ingredients may be needed
                cauldronSpriteRenderer.color = Color.white;
            }
        }
        else
        {
            // Reset the cauldron color to indicate success
            cauldronSpriteRenderer.color = Color.white;
        }
    }

    // Check if the ingredients match the required ingredients
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

    // Create the combined mana potion
    private void CreateManaPotion(ManaPotion manaPotion)
    {
        Debug.Log("Mana Potion created: " + manaPotion.name);
    }

    // Clear the container
    private void ClearContainer()
    {
        currentIngredients.Clear();
    }

    private void Update()
    {
        // Detect if the container is clicked after creating a potion
        if (potionCreated && Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(mousePosition);

            if (collider != null && collider.gameObject == gameObject)
            {
                SpawnPotion();
                potionCreated = false; // Reset the potion creation flag
            }
        }
    }

    // Spawn the potion at a specified location
    private void SpawnPotion()
    {
        if (potionPrefab != null)
        {
            Instantiate(potionPrefab, potionSpawnPosition, Quaternion.identity);
            Debug.Log("Potion spawned at position: " + potionSpawnPosition);
        }
        else
        {
            Debug.LogWarning("Potion prefab is not assigned!");
        }
    }
}
