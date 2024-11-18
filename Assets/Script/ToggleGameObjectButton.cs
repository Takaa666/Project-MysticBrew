using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGameObjectButtons : MonoBehaviour
{
    [System.Serializable]
    public class ButtonGameObjectPair
    {
        public Button button;
        public GameObject targetObject;
    }

    public List<ButtonGameObjectPair> buttonGameObjectPairs;

    private GameObject currentActiveObject;

    private void Start()
    {
        foreach (var pair in buttonGameObjectPairs)
        {
            pair.button.onClick.AddListener(() => OnButtonClick(pair.targetObject));
            pair.targetObject.SetActive(false); // Pastikan semua objek awalnya tidak aktif
        }
    }

    private void OnButtonClick(GameObject targetObject)
    {
        // Nonaktifkan objek aktif saat ini
        if (currentActiveObject != null)
        {
            currentActiveObject.SetActive(false);
        }

        // Aktifkan objek yang dipilih
        targetObject.SetActive(true);
        currentActiveObject = targetObject;
    }
}
