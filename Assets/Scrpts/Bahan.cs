using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bahan", menuName = "Food Prep/Food Item")]
public class Bahan : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public bool isCooked;
    public GameObject prefab; // The prefab to respawn
}
