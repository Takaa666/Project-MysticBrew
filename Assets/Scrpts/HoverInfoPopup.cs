using UnityEngine;
using UnityEngine.UI;

public class HoverInfoPopup : MonoBehaviour
{
    public GameObject popupUI;  // Reference to the popup GameObject (UI Canvas)
    public Text itemNameText;

    private RectTransform popupRectTransform;
    private Canvas canvas;

    private void Start()
    {
        // Hide popup initially
        popupUI.SetActive(false);
        popupRectTransform = popupUI.GetComponent<RectTransform>();

        // Get the Canvas component
        canvas = popupUI.GetComponentInParent<Canvas>();
    }

    public void ShowPopup(Potion food, Vector3 worldPosition)
    {
        // Set text and icon based on the Food object
        itemNameText.text = food.potionName;

        // Convert world position to screen position
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(worldPosition);

        // Convert screen position to Canvas position
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform, 
            screenPosition, 
            canvas.worldCamera, 
            out Vector2 localPoint
        );

        // Update the popup's position within the canvas
        popupRectTransform.localPosition = localPoint;

        // Show the popup
        popupUI.SetActive(true);
    }

    public void HidePopup()
    {
        popupUI.SetActive(false);
    }

    public void ShowPopupBahan(Bahan bahan, Vector3 worldPosition)
    {
        // Set text and icon based on the Food object
        itemNameText.text = bahan.itemName;

        // Convert world position to screen position
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(worldPosition);

        // Convert screen position to Canvas position
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform,
            screenPosition,
            canvas.worldCamera,
            out Vector2 localPoint
        );

        // Update the popup's position within the canvas
        popupRectTransform.localPosition = localPoint;

        // Show the popup
        popupUI.SetActive(true);
    }

    public void HidePopupBahan()
    {
        popupUI.SetActive(false);
    }
}
