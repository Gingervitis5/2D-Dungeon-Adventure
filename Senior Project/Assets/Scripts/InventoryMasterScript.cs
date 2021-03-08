using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryMasterScript : MonoBehaviour  // Attached to InventoryMaster to keep track of the player's inventory
{
    private List<Item> Inventory = new List<Item>();
    private int NumCredits = 10000;
    public TextMeshProUGUI CreditsText;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        CreditsText.text = NumCredits.ToString();
    }

    public int GetNumCredits()
    {
        return NumCredits;
    }

    public void DetractCredits(int takenAway)
    {
        NumCredits -= takenAway;
        CreditsText.text = NumCredits.ToString();
    }

    public void AddItem(Item toAdd)
    {
        Inventory.Add(toAdd);
        foreach(Item i in Inventory)
        {
            Debug.Log(i.ItemName);
        }
    }
}
