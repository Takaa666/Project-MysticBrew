using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public List<Bahan> currentIngredients = new List<Bahan>(); // List of ingredients in the container
    public Food[] allCombinedFoodItems; // List of all possible combined food items
    public ManaPotion[] manaPotions;
    public SpriteRenderer cauldronSpriteRenderer; // Reference to the SpriteRenderer to change the color

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

    // Check if the ingredients match any combined food item or partially match any recipe
    private void CheckCombination()
    {
        bool fullMatchFound = false;
        bool partialMatchFound = false;

        foreach (Food combinedItem in allCombinedFoodItems)
        {
            if (IsCombinationMatch(combinedItem.ingredients))
            {
                CreateCombinedFood(combinedItem);
                ClearContainer();
                fullMatchFound = true;
                break;
            }
            else if (IsPartialCombinationMatch(combinedItem.ingredients))
            {
                partialMatchFound = true;
            }
        }

        if (!fullMatchFound && !partialMatchFound)
        {
            // No full or partial match found, indicating failure
            cauldronSpriteRenderer.color = Color.black;
            Debug.Log("Combination failed! The cauldron turned black.");
        }
        else
        {
            // Either a full or partial match exists, reset cauldron color
            cauldronSpriteRenderer.color = Color.white;
        }
    }

    // Check if the ingredients fully match the required ingredients
    private bool IsCombinationMatch(Bahan[] requiredIngredients)
    {
        if (currentIngredients.Count != requiredIngredients.Length) return false;

        foreach (Bahan ingredient in requiredIngredients)
        {
            if (!currentIngredients.Contains(ingredient))
            {
                return false;
            }
        }

        return true;
    }

    // Check if the current ingredients partially match the required ingredients
    private bool IsPartialCombinationMatch(Bahan[] requiredIngredients)
    {
        // Convert the array to a list for easier comparison
        List<Bahan> requiredIngredientsList = new List<Bahan>(requiredIngredients);

        foreach (Bahan ingredient in currentIngredients)
        {
            if (!requiredIngredientsList.Contains(ingredient))
            {
                return false;
            }
        }

        return true;
    }

    // Create the combined food item
    private void CreateCombinedFood(Food combinedItem)
    {
        Debug.Log("Combined food created: " + combinedItem.itemName);
        // Additional logic for showing the combined food in UI or inventory
    }

    // Clear the container after creating a combined food item
    private void ClearContainer()
    {
        currentIngredients.Clear();
    }
}
