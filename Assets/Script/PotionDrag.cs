// using UnityEngine;

// public class PotionDragDrop2D : MonoBehaviour
// {
//     private Vector3 startPosition;
//     private bool isDragging = false;
//     private Cauldron targetCauldron;

//     void Start()
//     {
//         // Simpan posisi awal potion
//         startPosition = transform.position;
//     }

//     void OnMouseDown()
//     {
//         // Mulai drag ketika mouse ditekan pada objek
//         isDragging = true;
//     }

//     void OnMouseDrag()
//     {
//         // Gerakkan potion mengikuti posisi mouse
//         if (isDragging)
//         {
//             Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//             mousePosition.z = 0; // Set z ke 0 untuk 2D
//             transform.position = mousePosition;
//         }
//     }

//     void OnMouseUp()
//     {
//         // Selesai drag saat mouse dilepas
//         isDragging = false;

//         // Cek apakah potion dilepaskan di atas kuali
//         if (targetCauldron != null)
//         {
//             PotionBehaviour potion = GetComponent<PotionBehaviour>();
//             targetCauldron.AddIngredient(potion.potionName, potion.potionColor, potion.isBasePotion);
//             Destroy(gameObject); // Hapus potion dari scene setelah ditambahkan ke kuali
//         }
//         else
//         {
//             // Jika tidak di atas kuali, kembalikan ke posisi awal
//             transform.position = startPosition;
//         }
//     }

//     private void OnTriggerEnter2D(Collider2D other)
//     {
//         // Cek apakah objek yang disentuh adalah kuali
//         if (other.CompareTag("Cauldron"))
//         {
//             targetCauldron = other.GetComponent<Cauldron>();
//         }
//     }

//     private void OnTriggerExit2D(Collider2D other)
//     {
//         // Hapus referensi ke kuali ketika objek keluar dari area kuali
//         if (other.CompareTag("Cauldron"))
//         {
//             targetCauldron = null;
//         }
//     }
// }
