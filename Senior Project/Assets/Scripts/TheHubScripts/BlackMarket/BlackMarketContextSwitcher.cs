using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BlackMarketContextSwitcher : MonoBehaviour
{
    public GameObject[] ItemIcons;
    public Image Window;
    public Sprite Page;
 
    public void SwitchToConsumables()
    {
        Window.sprite = Page;
        ItemIcons[0].SetActive(true);
        foreach(GameObject g in ItemIcons)
        {
            if (!g.transform.name.Equals(ItemIcons[0].name))
            {
                g.SetActive(false);
            }
        }
    }

    public void SwitchToWeapons()
    {
        Window.sprite = Page;
        ItemIcons[1].SetActive(true);
        foreach (GameObject g in ItemIcons)
        {
            if (!g.transform.name.Equals(ItemIcons[1].name))
            {
                g.SetActive(false);
            }
        }
    }

    public void SwitchToSalvage()
    {
        Window.sprite = Page;
        ItemIcons[2].SetActive(true);
        foreach (GameObject g in ItemIcons)
        {
            if (!g.transform.name.Equals(ItemIcons[2].name))
            {
                g.SetActive(false);
            }
        }
    }
}
