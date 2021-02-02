using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MissionContextSwitcher : MonoBehaviour
{

    public GameObject MissionTrans;
    public GameObject[] LVLMarkers;
    public GameObject MissionBriefingScreen;
    public GameObject BackButton;
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
            if (this.gameObject.name.Equals("LVL1Button"))
            {
                g.GetComponent<Image>().enabled = false;
                BackButton.gameObject.SetActive(true);
            }
            else if (this.gameObject.name.Equals("BackButton"))
            {
                g.GetComponent<Image>().enabled = true;
            }
            else
            {
                g.GetComponent<Image>().enabled = true;
                BackButton.gameObject.SetActive(false);
            }          
        }
        MissionBriefingScreen.GetComponent<Image>().sprite = MissionImage;
    }

}
