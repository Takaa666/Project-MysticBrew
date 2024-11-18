using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleFiller : MonoBehaviour
{
    public Cauldron cauldron; // Referensi ke Cauldron
    private SpriteRenderer bottleSpriteRenderer; // Komponen SpriteRenderer botol untuk mengubah warna botol
    public Color emptyColor = Color.clear; // Warna botol kosong
    private bool isFilled = false; // Mengecek apakah botol sudah terisi

    private void Start()
    {
        bottleSpriteRenderer = GetComponent<SpriteRenderer>();
        bottleSpriteRenderer.color = emptyColor; // Mulai dengan botol kosong
    }

    private void OnMouseDown()
    {
        if (!isFilled && cauldron.IsPotionReady()) // Jika botol kosong dan potion sudah jadi
        {
            FillBottle(cauldron.GetPotionColor()); // Isi botol dengan warna potion
            cauldron.ResetCauldron(); // Reset kuali setelah potion diambil
        }
    }

    private void FillBottle(Color potionColor)
    {
        bottleSpriteRenderer.color = potionColor;
        isFilled = true;
        Debug.Log("Botol telah terisi dengan potion!");
    }
}
