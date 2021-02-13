using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ResetMissionScreen : MonoBehaviour
{
    public GameObject background;
    public Sprite image;
    public GameObject[] LVLMarkers;
    public GameObject BackButton;
    public GameObject PartyScreen;
    public GameObject ListContent;

    public void Reset()
    {
        background.GetComponent<Image>().sprite = image;
        foreach (GameObject g in LVLMarkers)
        {
            g.GetComponent<Image>().enabled = true;
        }
        BackButton.gameObject.SetActive(false);
        PartyScreen.transform.Find("CharacterImage").GetComponent<Image>().sprite = null;
        PartyScreen.transform.Find("CharacterImage").GetComponent<Image>().color = new Color(0,0,0,0);
        PartyScreen.transform.Find("Brawn").GetComponent<TextMeshProUGUI>().text = "Brawn: ";
        PartyScreen.transform.Find("Agility").GetComponent<TextMeshProUGUI>().text = "Agility: ";
        PartyScreen.transform.Find("Luck").GetComponent<TextMeshProUGUI>().text = "Luck: ";
        PartyScreen.transform.Find("Reason").GetComponent<TextMeshProUGUI>().text = "Reason: ";
        PartyScreen.transform.Find("Wit").GetComponent<TextMeshProUGUI>().text = "Wit: ";
        PartyScreen.transform.Find("Glamour").GetComponent<TextMeshProUGUI>().text = "Glamour: ";
        PartyScreen.transform.Find("Class").GetComponent<TextMeshProUGUI>().text = "Class: ";
        PartyScreen.transform.Find("Level").GetComponent<TextMeshProUGUI>().text = "Level: ";
        Transform[] children = ListContent.GetComponentsInChildren<Transform>();
        foreach (Transform child in children)
        {
            if (!child.name.Equals("PartyContent"))
            {
                child.SetParent(null);
                GameObject.Destroy(child.gameObject);
            }
        }
        children = PartyScreen.GetComponentsInChildren<Transform>();
        foreach(Transform child in children)
        {
            if (child.name.Contains("PartyMem"))
            {
                GameObject.Destroy(child.gameObject);
            }
        }
        PartyScreen.SetActive(false);
    }


}
