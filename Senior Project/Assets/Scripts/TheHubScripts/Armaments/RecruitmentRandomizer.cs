using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitmentRandomizer : MonoBehaviour
{
    public GameObject ListContent;
    public GameObject WildlanderPrefab, TechnicianPrefab, ScholarPrefab;
    private bool HasRandomized = false;

    public void SetRandomized(bool r)
    {
        HasRandomized = r;
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
                    break;
                case 2: //Technician
                    NewRecruitObject = GameObject.Instantiate(TechnicianPrefab);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    break;
                case 3: //Scholar
                    NewRecruitObject = GameObject.Instantiate(ScholarPrefab);
                    NewRecruitObject.transform.SetParent(ListContent.transform);
                    break;
            }
        }
    }
}
