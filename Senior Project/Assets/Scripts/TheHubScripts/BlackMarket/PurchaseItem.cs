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
        Item NewAdrenaline = itemFactory.CreateNewConsumable("Adrenaline");
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewAdrenaline);
    }

    public void PurchaseMedpack()
    {
        Item NewMedpack = itemFactory.CreateNewConsumable("Medpack");
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewMedpack);
    }

    public void PurchaseAdvMedpack()
    {
        Item NewAdvMedpack = itemFactory.CreateNewConsumable("Advanced Medpack");
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewAdvMedpack);
    }
    public void PurchaseEmergencyKit()
    {
        Item NewEmergencyKit = itemFactory.CreateNewConsumable("Emergency Kit");
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewEmergencyKit);
    }

    public void PurchaseIceyHot()
    {
        Item NewIceyHot = itemFactory.CreateNewConsumable("IceyHot");
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewIceyHot);
    }

    public void PurchaseAntidote()
    {
        Item NewAntidote = itemFactory.CreateNewConsumable("Antidote");
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewAntidote);
    }

    public void PurchaseTourniquet()
    {
        Item NewTourniquet = itemFactory.CreateNewConsumable("Tourniquet");
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewTourniquet);
    }

    public void PurchaseStardust()
    {
        Item NewStardust = itemFactory.CreateNewConsumable("Stardust");
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewStardust);
    }
}
