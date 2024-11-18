/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class DragMakanan : MonoBehaviour
{
    public Potion potion; // Change to Potion
    public HoverInfoPopup hoverInfoPopup;

    private Vector3 originalPosition;
    private bool isDragging;
    private bool isMouseOver;

    private void Start()
    {
        if (potion != null)
        {
            // Set sprite of GameObject based on the Potion's icon
            GetComponent<SpriteRenderer>().sprite = potion.icon; // Ensure Potion has an icon property
        }
    }

    private void OnMouseEnter()
    {
        isMouseOver = true;
        if (hoverInfoPopup != null && potion != null && !isDragging)
        {
            Vector3 worldPosition = transform.position;
            hoverInfoPopup.ShowPopup(potion, worldPosition); // Update to show potion info
        }
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
        if (hoverInfoPopup != null)
        {
            hoverInfoPopup.HidePopup();
        }
    }

    private void OnMouseDown()
    {
        if (hoverInfoPopup != null)
        {
            hoverInfoPopup.HidePopup();
        }

        originalPosition = transform.position;
        isDragging = true;
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, mousePosition.y, originalPosition.z);
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;

        if (isMouseOver && hoverInfoPopup != null)
        {
            Vector3 worldPosition = transform.position;
            hoverInfoPopup.ShowPopup(potion, worldPosition); // Update to show potion info
        }

        if (!IsValidDropPosition())
        {
            transform.position = originalPosition;
        }
    }

    private bool IsValidDropPosition()
    {
        return true; // Implement your logic for valid drop positions if needed
    }
}
*/