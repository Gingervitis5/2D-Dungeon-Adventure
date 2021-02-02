using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ResetBlackMarketScreen : MonoBehaviour
{
    public GameObject ConsumeIconParent, WeaponsIconParent;

    public void Reset()
    {
        transform.parent.transform.Find("WindowPage").GetComponent<Image>().enabled = false;
        Button[] buttons = ConsumeIconParent.GetComponentsInChildren<Button>();
        foreach (Button b in buttons)    //Disable button images 
        {
            b.GetComponent<Image>().enabled = false;
            b.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        }
        WeaponsIconParent.SetActive(false);
    }
}
