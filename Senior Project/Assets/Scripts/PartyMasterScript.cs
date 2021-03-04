using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMasterScript : MonoBehaviour
{
    private List<Ally> Characters = new List<Ally>();
    private static List<Ally> Party = new List<Ally>();
    public GameObject RecruitListContent, PartyListContent;
    public GameObject[] RecruitPrefabs;
    public GameObject[] DraggablePrefabs;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static List<Ally> GetParty()
    {
        return Party;
    }

    public static void AddPartyMember(Ally ally)
    {
        Party.Add(ally);
        foreach(Ally a in Party)
        {
            Debug.Log("Party Member: " + a.characterName);
        }
    }

    public static void RemovePartyMember(Ally ally)
    {
        Party.Remove(ally);
        Debug.Log("Removing: " + ally.GetCharacterName());
        foreach (Ally a in Party)
        {
            Debug.Log("Party Member: " + a.characterName);
        }
    }

    public void RecruitCharacter(Ally recruit)
    {
        Characters.Add(recruit);
        //Debug.Log("Recruited: " + recruit.characterName);
        /*foreach(Ally a in Characters)
        {
            Debug.Log(a.characterName);
        }*/
    }

    public void DisplayRecruitedMembers()
    {
        foreach(Ally a in Characters)
        {
            GameObject prefab;
            switch (a.characterName)
            {
               
                case "Wildlander":
                    prefab = GameObject.Instantiate(RecruitPrefabs[0]);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(RecruitListContent.transform);
                    break;
                case "Technician":
                    prefab = GameObject.Instantiate(RecruitPrefabs[1]);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(RecruitListContent.transform);
                    break;
                case "Scholar":
                    prefab = GameObject.Instantiate(RecruitPrefabs[2]);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(RecruitListContent.transform);
                    break;
                case "Psionic":
                    prefab = GameObject.Instantiate(RecruitPrefabs[3]);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(RecruitListContent.transform);
                    break;
                case "Soldier":
                    prefab = GameObject.Instantiate(RecruitPrefabs[4]);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(RecruitListContent.transform);
                    break;
            }
        }
    }

    public void DisplayPartyMembers()
    {
        foreach (Ally a in Characters)
        {
            GameObject prefab;
            switch (a.characterName)
            {

                case "Wildlander":
                    prefab = GameObject.Instantiate(DraggablePrefabs[0]);
                    prefab.GetComponent<DisplayPartyInfo>().SetCharacter(a);
                    prefab.transform.SetParent(PartyListContent.transform);
                    break;
                case "Technician":
                    prefab = GameObject.Instantiate(DraggablePrefabs[1]);
                    prefab.GetComponent<DisplayPartyInfo>().SetCharacter(a);
                    prefab.transform.SetParent(PartyListContent.transform);
                    break;
                case "Scholar":
                    prefab = GameObject.Instantiate(DraggablePrefabs[2]);
                    prefab.GetComponent<DisplayPartyInfo>().SetCharacter(a);
                    prefab.transform.SetParent(PartyListContent.transform);
                    break;
                case "Psionic":
                    prefab = GameObject.Instantiate(DraggablePrefabs[3]);
                    prefab.GetComponent<DisplayPartyInfo>().SetCharacter(a);
                    prefab.transform.SetParent(PartyListContent.transform);
                    break;
                case "Soldier":
                    prefab = GameObject.Instantiate(DraggablePrefabs[4]);
                    prefab.GetComponent<DisplayPartyInfo>().SetCharacter(a);
                    prefab.transform.SetParent(PartyListContent.transform);
                    break;
            }
        }
    }
}
