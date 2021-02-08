using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitmentRandomizer : MonoBehaviour
{
    public GameObject ListContent;
    public GameObject WildlanderPrefab, TechnicianPrefab, ScholarPrefab;
    private List<GameObject> Recruits = new List<GameObject>();
    private bool HasRandomized = false;

    public void SetRandomized(bool r)
    {
        HasRandomized = r;
    }

    public void DisplayRecruits()
    {
        foreach(GameObject recruit in Recruits)
        {
            recruit.transform.SetParent(ListContent.transform);
        }
    }

    public void RandomizeRecruits()
    {
        int NumRecruits = Random.Range(1, 6);
        int RecruitType;
        for (int i = 1; i <= NumRecruits && !HasRandomized; i++)
        {
            RecruitType = Random.Range(1, 4);
            GameObject NewRecruitObject;
            switch (RecruitType)
            {
                case 1: //Wildlander
                    NewRecruitObject = GameObject.Instantiate(WildlanderPrefab);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject);
                    break;
                case 2: //Technician
                    NewRecruitObject = GameObject.Instantiate(TechnicianPrefab);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject);
                    break;
                case 3: //Scholar
                    NewRecruitObject = GameObject.Instantiate(ScholarPrefab);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject);
                    break;
            }
            
        }
    }
}
