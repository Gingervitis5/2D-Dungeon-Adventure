using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitmentRandomizer : MonoBehaviour
{
    public GameObject ListContent;
    public GameObject[] Prefabs;
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
            RecruitType = Random.Range(1, 5);
            GameObject NewRecruitObject;
            switch (RecruitType)
            {
                case 1: //Wildlander
                    NewRecruitObject = GameObject.Instantiate(Prefabs[0]);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject);
                    break;
                case 2: //Technician
                    NewRecruitObject = GameObject.Instantiate(Prefabs[1]);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject);
                    break;
                case 3: //Scholar
                    NewRecruitObject = GameObject.Instantiate(Prefabs[2]);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject);
                    break;
                case 4: //Psionic
                    NewRecruitObject = GameObject.Instantiate(Prefabs[3]);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    Recruits.Add(NewRecruitObject);
                    break;
            }
            
        }
    }
}
