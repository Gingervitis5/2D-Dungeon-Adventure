using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MissionContextSwitcher : MonoBehaviour
{

    public GameObject MissionTrans;
    public GameObject[] LVLMarkers;
    public Sprite[] LVLImages;
    public GameObject MissionBriefingScreen;
    public GameObject BackButton;
    public GameObject StartButton;
    public GameObject PartySelect;
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
        PartySelect.SetActive(true);
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
        Debug.Log(PartySelect.activeSelf);
        yield return new WaitForSeconds(1);
        if (PartySelect.activeSelf)
        {
            Debug.Log(" " + levelSelected);
            switch (levelSelected)
            {
                case 1:
                    MissionBriefingScreen.GetComponent<Image>().sprite = LVLImages[0];
                    break;
            }
            PartySelect.SetActive(false);
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
