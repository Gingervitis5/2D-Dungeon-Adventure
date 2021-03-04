using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitmentDisplayer : MonoBehaviour
{
    public GameObject ListContent;
    //public GameObject[] Prefabs;
    private static List<Ally> Recruits = new List<Ally>();
    public GameObject[] RecruitPrefabs;
    private bool HasRandomized = false;

    public void SetRandomized(bool r)
    {
        HasRandomized = r;
    }

    public static void RemoveRecruit(Ally objectToRemove)
    {
        if (Recruits.Contains(objectToRemove))
        {
            Recruits.Remove(objectToRemove);
        }
    }

    public void DisplayRecruits()
    {
        foreach (Ally a in Recruits)
        {
            GameObject prefab;
            switch (a.characterName)
            {

                case "Wildlander":
                    prefab = GameObject.Instantiate(RecruitPrefabs[0]);
                    prefab.GetComponent<GenerateCharacterInfo>().SetGeneratedCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
                case "Technician":
                    prefab = GameObject.Instantiate(RecruitPrefabs[1]);
                    prefab.GetComponent<GenerateCharacterInfo>().SetGeneratedCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
                case "Scholar":
                    prefab = GameObject.Instantiate(RecruitPrefabs[2]);
                    prefab.GetComponent<GenerateCharacterInfo>().SetGeneratedCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
                case "Psionic":
                    prefab = GameObject.Instantiate(RecruitPrefabs[3]);
                    prefab.GetComponent<GenerateCharacterInfo>().SetGeneratedCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
                case "Soldier":
                    prefab = GameObject.Instantiate(RecruitPrefabs[4]);
                    prefab.GetComponent<GenerateCharacterInfo>().SetGeneratedCharacter(a);
                    prefab.transform.SetParent(ListContent.transform);
                    break;
            }
        }
    }

    public void RandomizeRecruits()
    {
        int NumRecruits = Random.Range(4, 7);
        int RecruitType;
        for (int i = 1; i <= NumRecruits && !HasRandomized; i++)
        {
            RecruitType = Random.Range(1, 6);
            //RecruitType = 5;
            GameObject NewRecruitObject;
            switch (RecruitType)
            {
                case 1: //Wildlander
                    NewRecruitObject = GameObject.Instantiate(RecruitPrefabs[0]);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject.GetComponent<GenerateCharacterInfo>().GetGeneratedCharacter());
                    break;
                case 2: //Technician
                    NewRecruitObject = GameObject.Instantiate(RecruitPrefabs[1]);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject.GetComponent<GenerateCharacterInfo>().GetGeneratedCharacter());
                    break;
                case 3: //Scholar
                    NewRecruitObject = GameObject.Instantiate(RecruitPrefabs[2]);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject.GetComponent<GenerateCharacterInfo>().GetGeneratedCharacter());
                    break;
                case 4: //Psionic
                    NewRecruitObject = GameObject.Instantiate(RecruitPrefabs[3]);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject.GetComponent<GenerateCharacterInfo>().GetGeneratedCharacter());
                    break;
                case 5: //Soldier
                    NewRecruitObject = GameObject.Instantiate(RecruitPrefabs[4]);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject.GetComponent<GenerateCharacterInfo>().GetGeneratedCharacter());
                    break;
            }
        }
       
    }
}
