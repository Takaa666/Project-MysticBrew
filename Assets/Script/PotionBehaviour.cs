// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PotionBehaviour : MonoBehaviour
// {
//      // Nama potion untuk membedakan jenis potion
//     public string potionName;

//     // Warna potion yang akan digunakan untuk mengubah warna kuali jika ini adalah potion dasar
//     public Color potionColor;

//     // Apakah ini potion dasar atau tidak
//     public bool isBasePotion;

//     // Fungsi untuk menambahkan potion ini ke kuali
//     public void AddToCauldron(Cauldron cauldron)
//     {
//         if (cauldron != null)
//         {
//             // Menambahkan potion ini ke dalam kuali
//             cauldron.AddIngredient(potionName, potionColor, isBasePotion);
//             Debug.Log("Potion " + potionName + " ditambahkan ke kuali.");
//         }
//         else
//         {
//             Debug.Log("Kuali tidak ditemukan!");
//         }
//     }
// }
