using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotManager : MonoBehaviour
{
    public List<Bahan> items; // List of items to display
    public Image[] slotImages; // Array of UI Image components for displaying item icons
    public Button previousButton;
    public Button nextButton;
    private int currentIndex = 0;
    private int slotsPerPage = 5;

    private void Start()
    {
        UpdateSlots();
        previousButton.onClick.AddListener(ShowPrevious);
        nextButton.onClick.AddListener(ShowNext);
        UpdateButtonStates();
    }

    private void UpdateSlots()
    {
        // Clear all slots
        for (int i = 0; i < slotImages.Length; i++)
        {
            if (i + currentIndex < items.Count)
            {
                slotImages[i].sprite = items[i + currentIndex].icon;
                slotImages[i].gameObject.SetActive(true);
            }
            else
            {
                slotImages[i].gameObject.SetActive(false);
            }
        }
    }

    private void ShowPrevious()
    {
        if (currentIndex - slotsPerPage >= 0)
        {
            currentIndex -= slotsPerPage;
            UpdateSlots();
            UpdateButtonStates();
        }
    }

    private void ShowNext()
    {
        if (currentIndex + slotsPerPage < items.Count)
        {
            currentIndex += slotsPerPage;
            UpdateSlots();
            UpdateButtonStates();
        }
    }

    private void UpdateButtonStates()
    {
        previousButton.interactable = currentIndex > 0;
        nextButton.interactable = currentIndex + slotsPerPage < items.Count;
    }
}
