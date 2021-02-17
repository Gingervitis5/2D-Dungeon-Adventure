using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMasterScript : MonoBehaviour
{
    private List<Ally> Characters = new List<Ally>();
    public GameObject ListContent;
    public GameObject WildlanderPrefab, TechnicianPrefab, ScholarPrefab;

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
                    prefab = GameObject.Instantiate(ScholarPrefab);
                    prefab.GetComponent<DisplayCharacterInfo>().SetCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
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
            }
        }
    }
}
