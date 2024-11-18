using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenggerusBahan : MonoBehaviour
{
    public Sprite BahanHalus;
    public Sprite BahanKasar;
    public string BahanHalusName;
    public int clickCount = 0;
    private bool isTouchingCobek = false;
    public Transform cobekTransform;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = BahanKasar;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("cobek"))
        {
            isTouchingCobek = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("cobek"))
        {
            isTouchingCobek = false;
        }
    }

    private void OnMouseDown()
    {
        if (isTouchingCobek)
        {
            clickCount++;

            // Jika bahan dihaluskan (setelah klik tertentu), ubah sprite dan tag
            if (clickCount == 6)
            {
                GetComponent<SpriteRenderer>().sprite = BahanHalus;
                gameObject.tag = BahanHalusName; // Set tag sesuai bahan yang dihaluskan
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
        if (isTouchingCobek && cobekTransform != null)
        {
            transform.position = cobekTransform.position;
        }
    }
}
