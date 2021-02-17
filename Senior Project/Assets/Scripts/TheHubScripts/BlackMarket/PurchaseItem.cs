using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp.Assets.Scripts.Classes;
using UnityEngine;

public class PurchaseItem : MonoBehaviour   // PurchaseItem will be attached to a button in the BlackMarket menu
{
    public GameObject InventoryMaster;
    private ItemFactory itemFactory = new ItemFactory();

    public void PurchaseAdrenaline()
    {
        if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 200)
        {
            Item NewAdrenaline = itemFactory.CreateNewConsumable("Adrenaline");
            InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewAdrenaline);
            InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(200);
        }
    }

    public void PurchaseMedpack()
    {
        if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 500)
        {
            Item NewMedpack = itemFactory.CreateNewConsumable("Medpack");
            InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewMedpack);
            InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(500);
        }
    }

    public void PurchaseAdvMedpack()
    {
        if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 1000)
        {
            Item NewAdvMedpack = itemFactory.CreateNewConsumable("Advanced Medpack");
            InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewAdvMedpack);
            InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(1000);
        }
    }
    public void PurchaseEmergencyKit()
    {
        if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 2000)
        {
            Item NewEmergencyKit = itemFactory.CreateNewConsumable("Emergency Kit");
            InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewEmergencyKit);
            InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(2000);
        }
    }

    public void PurchaseIceyHot()
    {
        if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 100)
        {
            Item NewIceyHot = itemFactory.CreateNewConsumable("IceyHot");
            InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewIceyHot);
            InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(100);
        }
    }

    public void PurchaseAntidote()
    {
        if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 100)
        {
            Item NewAntidote = itemFactory.CreateNewConsumable("Antidote");
            InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewAntidote);
            InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(100);
        }
    }

    public void PurchaseTourniquet()
    {
        if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 400)
        {
            Item NewTourniquet = itemFactory.CreateNewConsumable("Tourniquet");
            InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewTourniquet);
            InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(400);
        }
    }

    public void PurchaseStardust()
    {
        if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 5000)
        {
            Item NewStardust = itemFactory.CreateNewConsumable("Stardust");
            InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewStardust);
            InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(5000);
        }
    }
}
