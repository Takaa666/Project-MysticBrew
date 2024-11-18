using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jam : MonoBehaviour
{
    public int hour = 8;          // Jam mulai
    public int minute = 0;        // Menit tetap di 0
    public float timeSpeed = 1f;  // Kecepatan waktu (20 detik per jam)
    public Text clockText;        // UI teks untuk jam
    public GameObject gameOverPopup; // Popup game over

    private float elapsedTime = 0f;

    void Update()
    {
        // Tambahkan waktu sesuai kecepatan
        elapsedTime += Time.deltaTime * timeSpeed;

        // Setiap 20 detik berlalu, tambahkan jam
        if (elapsedTime >= 20f)
        {
            elapsedTime = 0f;
            hour++;

            // Jika waktu mencapai 22:00, tampilkan popup game over
            if (hour >= 22)
            {
                hour = 22;
                gameOverPopup.SetActive(true); // Aktifkan popup game over
                enabled = false;               // Hentikan skrip
            }
        }

        // Tampilkan waktu (format hanya jam dan menit)
        clockText.text = string.Format("{0:D2}:{1:D2}", hour, minute);
    }
}
