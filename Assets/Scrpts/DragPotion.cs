using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class DragPotion : MonoBehaviour
{
    public Potion potion;  // Reference to the potion object
    public HoverInfoPopup hoverInfoPopup;  // Reference to the HoverInfoPopup script

    private Vector3 originalPosition;
    private bool isDragging;
    private bool isMouseOver;

    private void Start()
    {
        if (potion != null)
        {
            // Set sprite of GameObject based on the Potion's icon
            //GetComponent<SpriteRenderer>().sprite = potion.icon;  // Assuming ManaPotion has an icon field
        }
    }

    private void OnMouseEnter()
    {
        isMouseOver = true;
        // Show popup only if not dragging
        if (hoverInfoPopup != null && potion != null && !isDragging)
        {
            Vector3 worldPosition = transform.position;
            hoverInfoPopup.ShowPopup(potion, worldPosition); // Display potion information
        }
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
        // Hide popup when mouse exits the object
        if (hoverInfoPopup != null)
        {
            hoverInfoPopup.HidePopup();
        }
    }

    private void OnMouseDown()
    {
        // Hide popup when starting to drag
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

        // Show popup again if mouse is still over the object after releasing
        if (isMouseOver && hoverInfoPopup != null)
        {
            Vector3 worldPosition = transform.position;
            hoverInfoPopup.ShowPopup(potion, worldPosition);
        }

        // Return to original position if dropped in invalid area
        if (!IsValidDropPosition())
        {
            transform.position = originalPosition;
        }
    }

    private bool IsValidDropPosition()
    {
        // Implement your logic to determine if the drop position is valid
        return true; // Change this logic based on your requirements
    }
}
