using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulateList : MonoBehaviour
{
    public GameObject ListContent;
    public GameObject PartyMaster;

    public void DisplayAvailableMembers()
    {
        PartyMaster.GetComponent<PartyMasterScript>().DisplayPartyMembers();
    }

    private void DestroyChildren()
    {
        Transform[] children = ListContent.GetComponentsInChildren<Transform>();
        foreach (Transform child in children)
        {
            if (!child.name.Equals("PartyContent"))
            {
                child.SetParent(null);
            }
        }
    }
}
