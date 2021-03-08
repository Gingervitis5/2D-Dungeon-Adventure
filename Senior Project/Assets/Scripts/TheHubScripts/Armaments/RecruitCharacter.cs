using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp.Assets.Scripts.Classes;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecruitCharacter : MonoBehaviour
{
    private static Ally characterToRecruit;
    public GameObject partyMaster;
    public Sprite BCRSI;
    private ItemFactory itemFactory = new ItemFactory();
    private static GameObject characterIcon;
    public Image characterImage;
    public GameObject brawnText, agilityText, luckText, reasonText, witText, GlamourText, classText;

    public static void SetCharacter(Ally recruit, GameObject icon)
    {
        characterToRecruit = recruit;
        characterIcon = icon;
    }

    public static Ally GetCharacter()
    {
        return characterToRecruit;
    }

    public void Recruit()
    {
        if (characterToRecruit != null)
        {
            characterToRecruit.SetWeapon(itemFactory.CreateNewWeapon("BCR-SI"));
            characterToRecruit.GetWeapon().SetStats(14, 8, 6, 5, 10, 25);
            characterToRecruit.GetWeapon().SetWeaponType("Assault Rifle");
            characterToRecruit.GetWeapon().SetItemImage(BCRSI);
            characterToRecruit.SetLevel(1);
            RecruitmentDisplayer.RemoveRecruit(characterIcon.GetComponent<GenerateCharacterInfo>().GetGeneratedCharacter());
            partyMaster.GetComponent<PartyMasterScript>().RecruitCharacter(characterToRecruit);
            GameObject.Destroy(characterIcon);
            characterToRecruit = null;

            brawnText.GetComponent<TextMeshProUGUI>().text = "Brawn: ";
            agilityText.GetComponent<TextMeshProUGUI>().text = "Agility: ";
            luckText.GetComponent<TextMeshProUGUI>().text = "Luck: ";
            reasonText.GetComponent<TextMeshProUGUI>().text = "Reason: ";
            witText.GetComponent<TextMeshProUGUI>().text = "Wit: ";
            GlamourText.GetComponent<TextMeshProUGUI>().text = "Glamour: ";
            classText.GetComponent<TextMeshProUGUI>().text = "Class: ";
            characterImage.sprite = null;
            characterImage.color = new Color(0,0,0,0);
        }
        
    }
}
