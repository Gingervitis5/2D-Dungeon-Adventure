using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class MissionContextSwitcher : MonoBehaviour
{

    public GameObject MissionTrans;
    public GameObject[] LVLMarkers;
    public Sprite[] LVLImages;
    public GameObject MissionBriefingScreen;
    public GameObject BackButton;
    public GameObject StartButton;
    public GameObject PartyScreen;
    public Sprite AssociatedImage;
    private static int levelSelected;

    public void SetLevel(int i)
    {
        levelSelected = i;
    }

    public void MissionButtonPressed()
    {
        MissionTrans.GetComponent<Animation>().Play("MissionTrans");
        StartCoroutine(EnableMissionMenu());
    }

    public void Back()
    {
        MissionTrans.GetComponent<Animation>().Play("MissionTrans");
        StartCoroutine(SwitchBack());
    }

    public void StartPartySelect()
    {
        MissionTrans.GetComponent<Animation>().Play("MissionTrans");
        PartyScreen.SetActive(true);
        StartCoroutine(EnablePartySelect());
    }

    IEnumerator EnableMissionMenu()
    {
        yield return new WaitForSeconds(1);
        foreach (GameObject g in LVLMarkers)
        {
            g.GetComponent<Image>().enabled = false;
            BackButton.SetActive(true);
            StartButton.SetActive(true);         
        }
        MissionBriefingScreen.GetComponent<Image>().sprite = AssociatedImage;
    }

    IEnumerator EnablePartySelect()
    {
        yield return new WaitForSeconds(1);
        StartButton.SetActive(false);
        MissionBriefingScreen.GetComponent<Image>().sprite = AssociatedImage;

    }

    IEnumerator SwitchBack()
    {
        Debug.Log(PartyScreen.activeSelf);
        yield return new WaitForSeconds(1);
        if (PartyScreen.activeSelf)
        {
            Debug.Log(" " + levelSelected);
            switch (levelSelected)
            {
                case 1:
                    MissionBriefingScreen.GetComponent<Image>().sprite = LVLImages[0];
                    break;
            }
            PartyScreen.transform.Find("CharacterImage").GetComponent<Image>().sprite = null;
            PartyScreen.transform.Find("CharacterImage").GetComponent<Image>().color = new Color(0, 0, 0, 0);
            PartyScreen.transform.Find("Brawn").GetComponent<TextMeshProUGUI>().text = "Brawn: ";
            PartyScreen.transform.Find("Agility").GetComponent<TextMeshProUGUI>().text = "Agility: ";
            PartyScreen.transform.Find("Luck").GetComponent<TextMeshProUGUI>().text = "Luck: ";
            PartyScreen.transform.Find("Reason").GetComponent<TextMeshProUGUI>().text = "Reason: ";
            PartyScreen.transform.Find("Wit").GetComponent<TextMeshProUGUI>().text = "Wit: ";
            PartyScreen.transform.Find("Glamour").GetComponent<TextMeshProUGUI>().text = "Glamour: ";
            PartyScreen.transform.Find("Class").GetComponent<TextMeshProUGUI>().text = "Class: ";
            PartyScreen.transform.Find("Level").GetComponent<TextMeshProUGUI>().text = "Level: ";
            Transform[] children = PartyScreen.GetComponentsInChildren<Transform>();
            foreach (Transform child in children)
            {
                if (child.name.Contains("PartyMem"))
                {
                    GameObject.Destroy(child.gameObject);
                }
            }
            PartyScreen.SetActive(false);
            StartButton.SetActive(true);
        }
        else
        {
            foreach (GameObject g in LVLMarkers)
            {
                g.GetComponent<Image>().enabled = true;
                BackButton.gameObject.SetActive(false);
                StartButton.SetActive(false);
            }
            MissionBriefingScreen.GetComponent<Image>().sprite = AssociatedImage;
        }
    }

}
