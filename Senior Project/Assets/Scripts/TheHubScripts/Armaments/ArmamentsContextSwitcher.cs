﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmamentsContextSwitcher : MonoBehaviour
{
    public Image WindowPage;
    public Sprite[] Graphics;
    public GameObject[] Pages;
    public GameObject PartyMaster;
    public GameObject RecruitmentPage;
    public GameObject ListContent;
    // 0 == Recruit
    // 1 == Party Page

    public void SwitchMenus()
    {
        switch (Pages[0].activeSelf)
        {
            case true:
                Debug.Log("Switch to party");
                Pages[0].SetActive(false);
                Pages[1].SetActive(true);
                WindowPage.sprite = Graphics[1];
                DestroyChildren();
                PartyMaster.GetComponent<PartyMasterScript>().DisplayRecruitedMembers();
                break;
            case false:
                Debug.Log("Switch to recruit");
                Pages[0].SetActive(true);
                Pages[1].SetActive(false);
                DestroyChildren();
                WindowPage.sprite = Graphics[0];
                RecruitmentPage.GetComponent<RecruitmentDisplayer>().DisplayRecruits();
                break;
        }
    }

    private void DestroyChildren()  
    {
        Transform[] children = ListContent.GetComponentsInChildren<Transform>();
        foreach(Transform child in children)
        {
            if (!child.name.Equals("RecruitContent"))
            {
                child.SetParent(null);
                GameObject.Destroy(child.gameObject);
            }
        } 
    }
}
