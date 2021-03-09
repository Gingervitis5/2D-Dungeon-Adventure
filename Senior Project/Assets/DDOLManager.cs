using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DDOLManager : MonoBehaviour
{
    public Image[] PartyMembers; 

    void Awake()
    {
        List<Ally> allies = PartyMasterScript.GetParty();
        for (int i = 0; i < PartyMembers.Length; i++)
        {
            PartyMembers[i].sprite = allies[i].characterImage;
        }
    }
}
