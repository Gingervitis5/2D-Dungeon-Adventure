using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp.Assets.Scripts.Classes;
using UnityEngine;

public class PurchaseWeapon : MonoBehaviour
{
    public GameObject InventoryMaster;
    private ItemFactory itemFactory = new ItemFactory();
    private string WeaponToPurchase;

    public void SetWeaponPurchase(string name)
    {
        WeaponToPurchase = name;
    }

    public void Purchase()
    {
        switch (WeaponToPurchase)
        {
            case "CRAVS Model 86":
                PurchaseCRAVS();
                break;
            case "AR-3117":
                PurchaseAR3117();
                break;
            case "MR-38":
                PurchaseMR38();
                break;
            case "ES-943":
                PurchaseES943();
                break;
            case "KML-199":
                PurchaseKML199();
                break;
            case "Karn 99s":
                PurchaseKarn99s();
                break;
            case "55-Stinger":
                Purchase55Stinger();
                break;
            case "CQ-24":
                PurchaseCQ24();
                break;
            case "48b Anti-Personnel Rifle":
                Purchase48bAntiPersonnelRifle();
                break;
        }
    }
    //Rifles
    public void PurchaseCRAVS()
    {
        Weapon NewCRAVS= itemFactory.CreateNewWeapon("CRAVS Model 86");
        NewCRAVS.SetStats(39, 36, 6, 5, 10, 30);
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewCRAVS);
        Debug.Log("Successfully purchased CRAVS");
    }

    public void PurchaseAR3117()
    {
        Weapon NewAR3117 = itemFactory.CreateNewWeapon("AR-3117");
        NewAR3117.SetStats(20, 10, 6, 5, 10, 35);
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewAR3117);
        Debug.Log("Successfully purchased AR-3117");
    }

    public void PurchaseMR38()
    {
        Weapon NewMR38 = itemFactory.CreateNewWeapon("MR-38");
        NewMR38.SetStats(130, 50, 2, 20, 25, 25);
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewMR38);
        Debug.Log("Successfully purchased MR-38");
    }

    public void PurchaseES943()
    {
        Weapon NewES943 = itemFactory.CreateNewWeapon("ES-943");
        NewES943.SetStats(100, 80, 4, 25, 10, 30);
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewES943);
        Debug.Log("Successfully purchased ES-943");
    }

    //SMGs
    public void PurchaseKML199()
    {
        Weapon NewKML199 = itemFactory.CreateNewWeapon("KML-199");
        NewKML199.SetStats(72, 30, 6, 10, 20, 20);
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewKML199);
        Debug.Log("Successfully purchased KML-199");
    }

    public void PurchaseKarn99s()
    {
        Weapon NewKarn99s = itemFactory.CreateNewWeapon("Karn 99s");
        NewKarn99s.SetStats(90, 60, 6, 15, 10, 25);
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewKarn99s);
        Debug.Log("Successfully purchased Karn 99s");
    }

    //Shotguns
    public void Purchase55Stinger()
    {
        Weapon New55Stinger = itemFactory.CreateNewWeapon("55-Stinger");
        New55Stinger.SetStats(96, 36, 10, 5, 10, 50);
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(New55Stinger);
        Debug.Log("Successfully purchased 55-Stinger");
    }

    public void PurchaseCQ24()
    {
        Weapon New55CQ24 = itemFactory.CreateNewWeapon("CQ-24");
        New55CQ24.SetStats(100, 50, 10, 5, 10, 50);
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(New55CQ24);
        Debug.Log("Successfully purchased CQ-24");
    }

    public void Purchase48bAntiPersonnelRifle()
    {
        Weapon New48b = itemFactory.CreateNewWeapon("48b Anti-Personnel Rifle");
        New48b.SetStats(120, 90, 1, 50, 70, 40);
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(New48b);
        Debug.Log("Successfully purchased 48b Anti-Personnel Rifle");
    }
}
