using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp.Assets.Scripts.Classes;
using UnityEngine;
using UnityEngine.UI;

public class RecruitCharacter : MonoBehaviour
{
    private static Ally CharacterToRecruit;
    public GameObject PartyMaster;
    public Sprite BCRSI;
    private ItemFactory itemFactory = new ItemFactory();
    private static GameObject CharacterIcon;

    public static void SetCharacter(Ally recruit, GameObject icon)
    {
        CharacterToRecruit = recruit;
        CharacterIcon = icon;
    }

    public static Ally GetCharacter()
    {
        return CharacterToRecruit;
    }

    public void Recruit()
    {
        if (CharacterToRecruit != null)
        {
            //Debug.Log(CharacterToRecruit.CharacterName);
            CharacterToRecruit.SetWeapon(itemFactory.CreateNewWeapon("BCR-SI"));
            CharacterToRecruit.GetWeapon().SetStats(14, 8, 6, 5, 10, 25);
            CharacterToRecruit.GetWeapon().SetWeaponType("Assault Rifle");
            CharacterToRecruit.GetWeapon().SetItemImage(BCRSI);
            CharacterToRecruit.SetLevel(1);
            RecruitmentDisplayer.RemoveRecruit(CharacterIcon.GetComponent<GenerateCharacterInfo>().GetGeneratedCharacter());
            PartyMaster.GetComponent<PartyMasterScript>().RecruitCharacter(CharacterToRecruit);
            GameObject.Destroy(CharacterIcon);
            CharacterToRecruit = null;
        }
        
    }
}
