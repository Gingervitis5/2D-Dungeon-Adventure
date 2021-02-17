using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ExitBlackMarket : MonoBehaviour
{
    public GameObject ConsumeIconParent, WeaponsIconParent, CreditsText, PriceText;

    public void ExitBM()
    {
        transform.parent.transform.Find("WindowPage").GetComponent<Image>().enabled = false;
        Button[] buttons = ConsumeIconParent.GetComponentsInChildren<Button>();
        foreach (Button b in buttons)    //Disable button images 
        {
            b.GetComponent<Image>().enabled = false;
            b.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        }
        WeaponsIconParent.SetActive(false);
        CreditsText.SetActive(false);
        PriceText.SetActive(false);
    }
}
