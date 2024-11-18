using UnityEngine;

[CreateAssetMenu(fileName = "NewPotion", menuName = "Potions/Potion")]
public class Potion : ScriptableObject
{
    public string potionName;
    public Bahan[] ingredients; // Required ingredients for this potion
    public GameObject potionPrefab; // The unique prefab for this potion
}
