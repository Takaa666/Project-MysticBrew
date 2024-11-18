using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WadahManager : MonoBehaviour
{
    public Transform nampan1; // Referensi untuk nampan1
    public Transform nampan2; // Referensi untuk nampan2

    void Update()
    {
        // Sinkronkan jumlah child antara nampan1 dan nampan2
        SyncChildObjects();
    }

    void SyncChildObjects()
    {
        // Jika nampan1 memiliki child object
        if (nampan1.childCount > 0)
        {
            // Hapus semua child di nampan2 terlebih dahulu
            foreach (Transform child in nampan2)
            {
                Destroy(child.gameObject);
            }

            // Tambahkan child yang sama dari nampan1 ke nampan2
            foreach (Transform child in nampan1)
            {
                GameObject newChild = Instantiate(child.gameObject, nampan2);
                newChild.name = child.name; // Tetapkan nama yang sama
            }
        }
        else
        {
            // Jika nampan1 tidak memiliki child, hapus semua child dari nampan2
            foreach (Transform child in nampan2)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
