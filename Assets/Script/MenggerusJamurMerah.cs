using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenggerusJamurMerah : MonoBehaviour
{
    public GameObject JamurMerahHalusPrefab; // Prefab jamur merah halus yang akan muncul setelah proses menggerus selesai
    public string JamurMerahHalusTag = "JamurMerahHalus"; // Tag untuk jamur merah halus
    public int clickCount = 0;
    private bool isTouchingCobek = false;

    // Variabel untuk menentukan posisi spawn menggunakan koordinat x, y, z
    public float spawnX = 0f;
    public float spawnY = 0f;
    public float spawnZ = 0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cobek"))
        {
            isTouchingCobek = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cobek"))
        {
            isTouchingCobek = false;
        }
    }

    private void OnMouseDown()
    {
        if (isTouchingCobek)
        {
            clickCount++;

            // Jika jamur merah dihaluskan (setelah klik tertentu), spawn prefab jamur merah halus di posisi xyz yang ditentukan
            if (clickCount == 6)
            {
                // Tentukan posisi spawn menggunakan koordinat xyz
                Vector3 spawnPosition = new Vector3(spawnX, spawnY, spawnZ);

                // Spawn prefab jamur merah halus pada posisi spawnPosition
                GameObject jamurMerahHalus = Instantiate(JamurMerahHalusPrefab, spawnPosition, Quaternion.identity);
                
                // Set tag sesuai dengan jamur merah halus
                jamurMerahHalus.tag = JamurMerahHalusTag;
                
                // Hapus game object jamur merah kasar saat ini
                Destroy(gameObject);
                
                clickCount = 0;
            }
        }
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z;
        transform.position = mousePosition;
    }

    private void OnMouseUp()
    {
        // Kembali ke posisi semula atau tindakan lain (sesuaikan sesuai kebutuhan)
    }
}
