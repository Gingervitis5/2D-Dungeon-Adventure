using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecruitCharacter : MonoBehaviour
{
    private static Ally CharacterToRecruit;
    public GameObject PartyMaster;
    private static GameObject CharacterIcon;

    public static void SetCharacter(Ally recruit, GameObject icon)
    {
        CharacterToRecruit = recruit;
        CharacterIcon = icon;
    }

    public void Recruit()
    {
        if (CharacterToRecruit != null)
        {
            //Debug.Log(CharacterToRecruit.CharacterName);
            PartyMaster.GetComponent<PartyMasterScript>().RecruitCharacter(CharacterToRecruit);
            GameObject.Destroy(CharacterIcon);
            CharacterToRecruit = null;
        }
        
    }
}
