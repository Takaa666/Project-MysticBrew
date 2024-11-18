using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Order List", menuName = "Food Prep/Order List")]
public class OrderList : ScriptableObject
{
    public Potion[] availableOrders;

}
