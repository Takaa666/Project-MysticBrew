using System.Collections.Generic;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    public List<Customer> customers; // Daftar customer yang sedang menunggu

    // Fungsi untuk memeriksa apakah hidangan yang disajikan pemain cocok dengan pesanan customer tertentu
    public bool CheckOrder(Customer customer, Food servedItem)
    {
        if (servedItem == customer.currentOrder)
        {
            Debug.Log("Correct Order! Customer is happy.");
            return true;
        }
        else
        {
            Debug.Log("Wrong Order! Customer is unhappy.");
            return false;
        }
    }
}
