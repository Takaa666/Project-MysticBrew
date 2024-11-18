using UnityEngine;

public class Customer : MonoBehaviour
{
    public OrderList orderList; // Drag and drop OrderList here
    public Potion currentOrder; // Change to Potion
    

    void GenerateRandomOrder()
    {
        if (orderList.availableOrders.Length > 0)
        {
            // Pick a random order from the list of available potions
            int randomIndex = Random.Range(0, orderList.availableOrders.Length);
            currentOrder = orderList.availableOrders[randomIndex];

            // Display this order in the UI or text
            DisplayOrder(currentOrder);
        }
    }

    public bool CheckOrder(Potion servedPotion) // Change parameter to Potion
    {
        if (servedPotion == currentOrder)
        {
            Debug.Log("Correct Order! Customer is happy.");
            Destroy(gameObject);
            
            return true;
        }
        else
        {
            Debug.Log("Wrong Order! Customer is unhappy.");
            return false;
        }
    }

    void DisplayOrder(Potion order) // Change parameter to Potion
    {
        // Example: display the name and image of the potion in the UI
        Debug.Log("Customer ordered: " + order.name);
    }

    void Start()
    {
        //GenerateRandomOrder();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DragPotion dragMakanan = collision.GetComponent<DragPotion>();
        if (dragMakanan != null && dragMakanan.potion == currentOrder) // Change to potion
        {
            CheckOrder(dragMakanan.potion); // Change to potion
        }
        if(collision.tag == "Potion")
        {
            Destroy(collision.gameObject);
        }
    }
}
