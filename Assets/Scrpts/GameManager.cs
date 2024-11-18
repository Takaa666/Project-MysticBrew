using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Transform canvas;
    public GameObject itemInfoPrefab;
    private GameObject currentItemInfo = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayItemInfo(string itemName, Vector2 buttonPos)
    {
        if(currentItemInfo != null)
        {

        }
        currentItemInfo = Instantiate(itemInfoPrefab, buttonPos, Quaternion.identity, canvas);
        currentItemInfo.GetComponent<ItemInfo>().SetUp(itemName);
    }
    public void DestroyItemInfo()
    {
       if(currentItemInfo != null)
        {
            Destroy(currentItemInfo.gameObject);
        }
    }
}
