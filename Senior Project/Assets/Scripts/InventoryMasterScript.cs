using System.Collections.Generic;
using UnityEngine;

public class InventoryMasterScript : MonoBehaviour  // Attached to InventoryMaster to keep track of the player's inventory
{
    private List<Item> Inventory = new List<Item>();
    private int NumCredits = 0;

    public void AddItem(Item toAdd)
    {
        Inventory.Add(toAdd);
        foreach(Item i in Inventory)
        {
            Debug.Log(i.ItemName);
        }
    }
}
