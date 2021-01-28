using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MissionContextSwitcher : MonoBehaviour
{

    public GameObject MissionTrans;
    public GameObject[] LVLMarkers;
    public GameObject MissionBriefingScreen;
    public Sprite MissionImage;
    
    public void MissionButtonPressed()
    {
        Debug.Log("Hit");
        MissionTrans.GetComponent<Animation>().Play("MissionTrans");
        StartCoroutine(PlayMissionAnimation());
    }

    IEnumerator PlayMissionAnimation()
    {
        yield return new WaitForSeconds(1);
        foreach (GameObject g in LVLMarkers)
        {
            g.GetComponent<Image>().enabled = false;
        }
        MissionBriefingScreen.GetComponent<Image>().sprite = MissionImage;
    }

}
