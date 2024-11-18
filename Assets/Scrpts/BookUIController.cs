using UnityEngine;

public class BookUIController : MonoBehaviour
{
    public GameObject bookPanel;  // Drag & drop panel buku ke sini di Inspector

    void Start()
    {
        // Memastikan book panel dalam keadaan tidak aktif di awal permainan
        if (bookPanel != null)
        {
            bookPanel.SetActive(false);
        }
    }

    public void ToggleBookPanel()
    {
        // Memeriksa jika panel buku ada
        if (bookPanel != null)
        {
            // Mengaktifkan atau menonaktifkan panel
            bool isActive = bookPanel.activeSelf;
            bookPanel.SetActive(!isActive);
        }
    }
}