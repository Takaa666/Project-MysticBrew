using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    private List<string> ingredients = new List<string>(); // Daftar bahan yang masuk ke kuali
    private Dictionary<string, List<string>> recipes; // Resep-resep potion
    private Dictionary<string, Color> potionColors; // Warna-warna untuk setiap potion

    private Color mixingColor = new Color(0.55f, 0.27f, 0.07f); // Warna kuali saat bahan sedang dicampur
    private Color failColor = Color.black; // Warna kuali jika kombinasi gagal
    private Color currentPotionColor = Color.clear;
    private bool potionReady = false;
    private string createdPotion = null; // Nama potion yang berhasil dibuat

    private void Start()
    {
        InitializeRecipes();
    }

    // Fungsi untuk menginisialisasi resep potion
    private void InitializeRecipes()
    {
        recipes = new Dictionary<string, List<string>>();
        potionColors = new Dictionary<string, Color>();

        // Tambahkan resep sesuai gambar yang Anda berikan
        recipes["cold potion"] = new List<string> { "health potion", "slime biru", "jamur biru" };
        potionColors["cold potion"] = Color.cyan;

        recipes["warmer potion"] = new List<string> { "health potion", "slime merah", "jamur merah" };
        potionColors["warmer potion"] = Color.red;

        recipes["speed potion"] = new List<string> { "mana potion", "bulu ekor werewolf", "bunga hijau" };
        potionColors["speed potion"] = Color.green;

        recipes["strong potion"] = new List<string> { "mana potion", "taring orc", "bulu ekor werewolf" };
        potionColors["strong potion"] = new Color(0.8f, 0.2f, 0.2f); // Contoh warna

        recipes["health potion"] = new List<string> { "bunga merah", "bunga hijau", "bunga biru" };
        potionColors["health potion"] = Color.magenta;

        recipes["mana potion"] = new List<string> { "jamur merah", "jamur biru", "jamur hijau" };
        potionColors["mana potion"] = new Color(0.2f, 0.2f, 1.0f); // Contoh warna
    }

    // Fungsi untuk menambahkan bahan ke dalam kuali
    public void AddIngredient(string ingredient)
    {
        if (!potionReady && ingredients.Count < 3)
        {
            ingredients.Add(ingredient);
            UpdateCauldronColor();
        }
    }

    // Fungsi untuk memeriksa apakah kombinasi bahan sesuai dengan resep yang ada
    private string CheckRecipe()
    {
        foreach (var recipe in recipes)
        {
            if (MatchRecipe(recipe.Value, ingredients))
            {
                return recipe.Key; // Mengembalikan nama potion jika cocok
            }
        }
        return null; // Mengembalikan null jika tidak ada resep yang cocok
    }

    // Fungsi untuk mencocokkan bahan dengan resep
    private bool MatchRecipe(List<string> recipeIngredients, List<string> inputIngredients)
    {
        if (recipeIngredients.Count != inputIngredients.Count)
            return false;

        // Salin daftar bahan yang dimasukkan dan resep untuk dicocokkan
        List<string> ingredientsCopy = new List<string>(inputIngredients);

        foreach (var ingredient in recipeIngredients)
        {
            if (ingredientsCopy.Contains(ingredient))
            {
                ingredientsCopy.Remove(ingredient); // Hapus bahan yang cocok
            }
            else
            {
                return false; // Jika tidak ada bahan yang cocok, resep gagal
            }
        }
        return true;
    }

    // Update warna kuali berdasarkan bahan-bahan yang dimasukkan
    private void UpdateCauldronColor()
    {
        createdPotion = CheckRecipe();

        if (createdPotion != null)
        {
            potionReady = true;
            currentPotionColor = potionColors[createdPotion];
            GetComponent<SpriteRenderer>().color = potionColors[createdPotion];
            Debug.Log("Potion berhasil dibuat: " + createdPotion);
        }
        else if (ingredients.Count >= 3) // Jika bahan lebih dari 3 dan gagal cocok dengan resep, berarti gagal
        {
            GetComponent<SpriteRenderer>().color = failColor;
            potionReady = false;
            Debug.Log("Kombinasi gagal!");
        }
        else
        {
            GetComponent<SpriteRenderer>().color = mixingColor; // Warna coklat saat bahan sedang dicampur
        }
    }

    // Fungsi untuk mengecek apakah potion sudah siap
    public bool IsPotionReady()
    {
        return potionReady;
    }

    // Fungsi untuk mendapatkan warna potion
    public Color GetPotionColor()
    {
        return currentPotionColor;
    }

    // Fungsi untuk reset kuali setelah potion diambil
    public void ResetCauldron()
    {
        ingredients.Clear();
        potionReady = false;
        createdPotion = null;
        currentPotionColor = Color.clear;
        GetComponent<SpriteRenderer>().color = mixingColor; // Kembali ke warna awal
    }
}
