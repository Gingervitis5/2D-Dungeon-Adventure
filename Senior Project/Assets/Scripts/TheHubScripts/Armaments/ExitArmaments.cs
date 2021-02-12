using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExitArmaments : MonoBehaviour
{
    public GameObject PartyMemberPage, RecruitmentPage;
    public GameObject ListContent;

    public void Exit()
    {
        PartyMemberPage.transform.Find("Level").GetComponent<TextMeshProUGUI>().text = "Level: ";
        PartyMemberPage.transform.Find("Brawn").GetComponent<TextMeshProUGUI>().text = "Brawn: ";
        PartyMemberPage.transform.Find("Agility").GetComponent<TextMeshProUGUI>().text = "Agility: ";
        PartyMemberPage.transform.Find("Luck").GetComponent<TextMeshProUGUI>().text = "Luck: ";
        PartyMemberPage.transform.Find("Wit").GetComponent<TextMeshProUGUI>().text = "Wit: ";
        PartyMemberPage.transform.Find("Glamour").GetComponent<TextMeshProUGUI>().text = "Glamour: ";
        PartyMemberPage.transform.Find("Reason").GetComponent<TextMeshProUGUI>().text = "Reason: ";
        PartyMemberPage.transform.Find("CharacterImage").GetComponent<Image>().color = new Color(0,0,0,0);
        GameObject WeaponTab = PartyMemberPage.transform.Find("WeaponTab").gameObject;
        WeaponTab.transform.Find("WeaponImage").GetComponent<Image>().color = new Color(0, 0, 0, 0);
        WeaponTab.transform.Find("WeaponName").GetComponent<TextMeshProUGUI>().text = "Name: ";
        WeaponTab.transform.Find("Damage").GetComponent<TextMeshProUGUI>().text = "Damage: ";
        WeaponTab.transform.Find("Handling").GetComponent<TextMeshProUGUI>().text = "Handling: ";
        WeaponTab.transform.Find("Type").GetComponent<TextMeshProUGUI>().text = "Type: ";

        RecruitmentPage.transform.Find("Brawn").GetComponent<TextMeshProUGUI>().text = "Brawn: ";
        RecruitmentPage.transform.Find("Agility").GetComponent<TextMeshProUGUI>().text = "Agility: ";
        RecruitmentPage.transform.Find("Luck").GetComponent<TextMeshProUGUI>().text = "Luck: ";
        RecruitmentPage.transform.Find("Wit").GetComponent<TextMeshProUGUI>().text = "Wit: ";
        RecruitmentPage.transform.Find("Glamour").GetComponent<TextMeshProUGUI>().text = "Glamour: ";
        RecruitmentPage.transform.Find("Reason").GetComponent<TextMeshProUGUI>().text = "Reason: ";
        RecruitmentPage.transform.Find("CharacterImage").GetComponent<Image>().color = new Color(0, 0, 0, 0);

        PartyMemberPage.SetActive(true);
        RecruitmentPage.SetActive(false);

        Transform[] children = ListContent.GetComponentsInChildren<Transform>();
        foreach (Transform child in children)
        {
            if (!child.name.Equals("RecruitContent"))
            {
                child.SetParent(null);
            }
        }
    }
}
