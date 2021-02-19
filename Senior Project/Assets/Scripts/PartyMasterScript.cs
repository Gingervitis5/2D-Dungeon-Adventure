using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMasterScript : MonoBehaviour
{
    private List<Ally> Characters = new List<Ally>();
<<<<<<< HEAD
    public GameObject ListContent;
    public GameObject WildlanderPrefab, TechnicianPrefab, ScholarPrefab;
=======
    private static List<Ally> Party = new List<Ally>();
    public GameObject RecruitListContent, PartyListContent;
    public GameObject[] RecruitPrefabs;
    public GameObject[] DraggablePrefabs;
>>>>>>> be95e78810f9adc1a1524b5ca21b78f2444a4a44

    public static List<Ally> GetAllies()
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
        foreach (Ally a in Party)
        {
            Debug.Log("Party Member: " + a.characterName);
        }
    }

    public void RecruitCharacter(Ally recruit)
    {
        Characters.Add(recruit);
        Debug.Log("Recruited: " + recruit.characterName);
        /*foreach(Ally a in Characters)
        {
            Debug.Log(a.CharacterName);
        }*/
    }

    public void DisplayPartyMembers()
    {
        foreach(Ally a in Characters)
        {
            GameObject prefab;
            switch (a.characterName)
            {
                case "Wildlander":
                    prefab = GameObject.Instantiate(WildlanderPrefab);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
                case "Technician":
                    prefab = GameObject.Instantiate(TechnicianPrefab);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
                case "Scholar":
                    prefab = GameObject.Instantiate(ScholarPrefab);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
                case "Psionic":
                    prefab = GameObject.Instantiate(ScholarPrefab);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
                case "Soldier":
<<<<<<< HEAD
                    prefab = GameObject.Instantiate(ScholarPrefab);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
=======
                    prefab = GameObject.Instantiate(RecruitPrefabs[4]);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(RecruitListContent.transform);
                    break;
                case "Operative":
                    prefab = GameObject.Instantiate(RecruitPrefabs[5]);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(RecruitListContent.transform);
                    break;
                case "Delegate":
                    prefab = GameObject.Instantiate(RecruitPrefabs[6]);
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
                    Debug.Log("Display Wildlander");
                    prefab = GameObject.Instantiate(DraggablePrefabs[0]);
                    prefab.GetComponent<DisplayPartyInfo>().SetCharacter(a);
                    prefab.transform.SetParent(PartyListContent.transform);
                    break;
                case "Technician":
                    Debug.Log("Display Technician");
                    prefab = GameObject.Instantiate(DraggablePrefabs[1]);
                    prefab.GetComponent<DisplayPartyInfo>().SetCharacter(a);
                    prefab.transform.SetParent(PartyListContent.transform);
>>>>>>> be95e78810f9adc1a1524b5ca21b78f2444a4a44
                    break;
                case "Operative":
                    prefab = GameObject.Instantiate(ScholarPrefab);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
                case "Delegate":
                    prefab = GameObject.Instantiate(ScholarPrefab);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
                case "Soldier":
                    prefab = GameObject.Instantiate(DraggablePrefabs[4]);
                    prefab.GetComponent<DisplayPartyInfo>().SetCharacter(a);
                    prefab.transform.SetParent(PartyListContent.transform);
                    break;
                case "Operative":
                    prefab = GameObject.Instantiate(DraggablePrefabs[5]);
                    prefab.GetComponent<DisplayPartyInfo>().SetCharacter(a);
                    prefab.transform.SetParent(PartyListContent.transform);
                    break;
                case "Delegate":
                    prefab = GameObject.Instantiate(DraggablePrefabs[6]);
                    prefab.GetComponent<DisplayPartyInfo>().SetCharacter(a);
                    prefab.transform.SetParent(PartyListContent.transform);
                    break;
            }
        }
    }
}
