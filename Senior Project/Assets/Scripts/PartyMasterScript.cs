using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMasterScript : MonoBehaviour
{
    private List<Ally> Characters = new List<Ally>();

    public void RecruitCharacter(Ally recruit)
    {
        Characters.Add(recruit);
        Debug.Log("Recruited: " + recruit.CharacterName);
        foreach(Ally a in Characters)
        {
            Debug.Log(a.CharacterName);
        }
    }
}
