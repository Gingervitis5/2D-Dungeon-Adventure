using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BlackMarketContextSwitcher : MonoBehaviour
{
    public Sprite[] WindowPages;
    // 0 == Consumables
    // 1 == Weapons
    // 2 == Salvage
    public Image Window;

    public void SwitchToConsumables()
    {
        Window.sprite = WindowPages[0];
    }

    public void SwitchToWeapons()
    {
        Window.sprite = WindowPages[1];
    }

    public void SwitchToSalvage()
    {
        Window.sprite = WindowPages[2];
    }
}
