﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class DisplayWeapon : MonoBehaviour
{
    public Image TargetGraphic;
    public Sprite DisplayGraphic;
    public TextMeshProUGUI Name, Damage, Range, Handling, Type; 

    public void DisplayCRAVS()
    {
        Name.text = "Name: CRAVS Model 86";
        Damage.text = "Damage: 78-108";
        Range.text = "Range: 20-30m";
        Handling.text = "Handling: 30";
        Type.text = "Type: Assault Rifle";

        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
    }

    public void DisplayAR3117()
    {
        Name.text = "Name: AR-3117";
        Damage.text = "Damage: 60-120";
        Range.text = "Range: 10-20m";
        Handling.text = "Handling: 35";
        Type.text = "Type: Assault Rifle";

        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
    }

    public void DisplayMR38()
    {
        Name.text = "Name: MR-38";
        Damage.text = "Damage: 50-130";
        Range.text = "Range: 25-35m";
        Handling.text = "Handling: 25";
        Type.text = "Type: Marksman Rifle";

        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
    }

    public void DisplayES943()
    {
        Name.text = "Name: ES-943";
        Damage.text = "Damage: 80-100";
        Range.text = "Range: 20-25m";
        Handling.text = "Handling: 30";
        Type.text = "Type: Pulse Rifle";

        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
    }

    public void DisplayKML199()
    {
        Name.text = "Name: KML-199";
        Damage.text = "Damage: 30-72";
        Range.text = "Range: 5-12m";
        Handling.text = "Handling: 20";
        Type.text = "Type: Sub Machine Gun";

        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
    }

    public void DisplayKarn99s()
    {
        Name.text = "Name: Karn 99s";
        Damage.text = "Damage: 40-90";
        Range.text = "Range: 10-15m";
        Handling.text = "Handling: 25";
        Type.text = "Type: Sub Machine Gun";

        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
    }

    public void Display55Stinger()
    {
        Name.text = "Name: 55-Stinger";
        Damage.text = "Damage: 36-96";
        Range.text = "Range: 3-8m";
        Handling.text = "Handling: 50";
        Type.text = "Type: Shotgun";

        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
    }

    public void DisplayCQ24()
    {
        Name.text = "Name: CQ-24";
        Damage.text = "Damage: 50-100";
        Range.text = "Range: 5-10m";
        Handling.text = "Handling: 45";
        Type.text = "Type: Shotgun";

        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
    }

    public void Display48bAntiPersonnel()
    {
        Name.text = "Name: 48b AP Rifle";
        Damage.text = "Damage: 90-140";
        Range.text = "Range: 90-120m";
        Handling.text = "Handling: 40";
        Type.text = "Type: Sniper Rifle";

        TargetGraphic.sprite = DisplayGraphic;
        TargetGraphic.color = new Color(255, 255, 255, 255);
    }
}