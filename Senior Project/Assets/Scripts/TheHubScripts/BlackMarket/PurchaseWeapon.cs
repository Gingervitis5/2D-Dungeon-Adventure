using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp.Assets.Scripts.Classes;
using UnityEngine;

public class PurchaseWeapon : MonoBehaviour
{
    public GameObject InventoryMaster;
    private ItemFactory itemFactory = new ItemFactory();
    private string WeaponToPurchase;
    private Sprite WeaponSprite;

    public void SetWeaponPurchase(string name)
    {
        WeaponToPurchase = name;
    }

    public void SetWeaponSprite(Sprite sprite)
    {
        WeaponSprite = sprite;
    }

    public void Purchase()
    {
        switch (WeaponToPurchase)
        {
            case "CRAVS Model 86":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 5000)
                {
                    PurchaseCRAVS();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(5000);
                }
                break;
            case "AR-3117":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 3000)
                {
                    PurchaseAR3117();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(3000);
                }
                break;
            case "MR-38":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 4250)
                {
                    PurchaseMR38();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(4250);
                }
                break;
            case "ES-943":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 5500)
                {
                    PurchaseES943();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(5500);
                }
                break;
            case "KML-199":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 2500)
                {
                    PurchaseKML199();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(2500);
                }
                break;
            case "Karn 99s":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 2650)
                {
                    PurchaseKarn99s();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(2650);
                }
                break;
            case "55-Stinger":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 3250)
                {
                    Purchase55Stinger();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(3250);
                }   
                break;
            case "CQ-24":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 3000)
                {
                    PurchaseCQ24();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(3000);
                }
                break;
            case "48b Anti-Personnel Rifle":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 7000)
                {
                    Purchase48bAntiPersonnelRifle();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(7000);
                }
                break;
            case "Draksolv":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 4800)
                {
                    PurchaseDraksolv();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(4800);
                }
                break;
            case "Stormfront PS":
                if (InventoryMaster.GetComponent<InventoryMasterScript>().GetNumCredits() >= 7500)
                {
                    PurchaseStormfrontPS();
                    InventoryMaster.GetComponent<InventoryMasterScript>().DetractCredits(7500);
                }
                break;
            default:
                Debug.Log("Nothing was bought");
                break;
        }
    }
    //Rifles
    public void PurchaseCRAVS()
    {
        Weapon NewCRAVS= itemFactory.CreateNewWeapon("CRAVS Model 86");
        NewCRAVS.SetStats(39, 36, 6, 5, 10, 30);
        NewCRAVS.SetWeaponType("Assault Rifle");
        NewCRAVS.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewCRAVS);
        Debug.Log("Successfully purchased CRAVS");
    }

    public void PurchaseAR3117()
    {
        Weapon NewAR3117 = itemFactory.CreateNewWeapon("AR-3117");
        NewAR3117.SetStats(20, 10, 6, 5, 10, 35);
        NewAR3117.SetWeaponType("Assault Rifle");
        NewAR3117.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewAR3117);
        Debug.Log("Successfully purchased AR-3117");
    }

    public void PurchaseMR38()
    {
        Weapon NewMR38 = itemFactory.CreateNewWeapon("MR-38");
        NewMR38.SetStats(130, 50, 2, 20, 25, 25);
        NewMR38.SetWeaponType("Marksman Rifle");
        NewMR38.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewMR38);
        Debug.Log("Successfully purchased MR-38");
    }

    public void PurchaseES943()
    {
        Weapon NewES943 = itemFactory.CreateNewWeapon("ES-943");
        NewES943.SetStats(100, 80, 4, 25, 10, 30);
        NewES943.SetWeaponType("Energy Rifle");
        NewES943.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewES943);
        Debug.Log("Successfully purchased ES-943");
    }

    //SMGs
    public void PurchaseKML199()
    {
        Weapon NewKML199 = itemFactory.CreateNewWeapon("KML-199");
        NewKML199.SetStats(72, 30, 6, 10, 20, 20);
        NewKML199.SetWeaponType("Sub Machine Gun");
        NewKML199.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewKML199);
        Debug.Log("Successfully purchased KML-199");
    }

    public void PurchaseKarn99s()
    {
        Weapon NewKarn99s = itemFactory.CreateNewWeapon("Karn 99s");
        NewKarn99s.SetStats(90, 60, 6, 15, 10, 25);
        NewKarn99s.SetWeaponType("Sub Machine Gun");
        NewKarn99s.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewKarn99s);
        Debug.Log("Successfully purchased Karn 99s");
    }

    //Shotguns
    public void Purchase55Stinger()
    {
        Weapon New55Stinger = itemFactory.CreateNewWeapon("55-Stinger");
        New55Stinger.SetStats(96, 36, 10, 5, 10, 50);
        New55Stinger.SetWeaponType("Shotgun");
        New55Stinger.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(New55Stinger);
        Debug.Log("Successfully purchased 55-Stinger");
    }

    public void PurchaseCQ24()
    {
        Weapon NewCQ24 = itemFactory.CreateNewWeapon("CQ-24");
        NewCQ24.SetStats(100, 50, 10, 5, 10, 50);
        NewCQ24.SetWeaponType("Shotgun");
        NewCQ24.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewCQ24);
        Debug.Log("Successfully purchased CQ-24");
    }

    public void Purchase48bAntiPersonnelRifle()
    {
        Weapon New48b = itemFactory.CreateNewWeapon("48b Anti-Personnel Rifle");
        New48b.SetStats(120, 90, 1, 50, 70, 40);
        New48b.SetWeaponType("Sniper Rifle");
        New48b.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(New48b);
        Debug.Log("Successfully purchased 48b Anti-Personnel Rifle");
    }

    public void PurchaseDraksolv()
    {
        Weapon NewDraksolv = itemFactory.CreateNewWeapon("Draksolv");
        NewDraksolv.SetStats(125, 70, 1, 40, 50, 20);
        NewDraksolv.SetWeaponType("Sniper Rifle");
        NewDraksolv.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewDraksolv);
        Debug.Log("Successfully purchased Draksolv");
    }

    public void PurchaseStormfrontPS()
    {
        Weapon NewStormfrontPS = itemFactory.CreateNewWeapon("Stormfront PS");
        NewStormfrontPS.SetStats(112, 62, 1, 50, 50, 15);
        NewStormfrontPS.SetWeaponType("Energy Sniper");
        NewStormfrontPS.ItemImage = WeaponSprite;
        InventoryMaster.GetComponent<InventoryMasterScript>().AddItem(NewStormfrontPS);
        Debug.Log("Successfully purchased Stormfront PS");
    }
}
