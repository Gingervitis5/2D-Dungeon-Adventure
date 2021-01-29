using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ResetMissionScreen : MonoBehaviour
{
    public GameObject background;
    public Sprite image;
    public GameObject[] LVLMarkers;
    public GameObject BackButton;

    public void Reset()
    {
        background.GetComponent<Image>().sprite = image;
        foreach (GameObject g in LVLMarkers)
        {
            g.GetComponent<Image>().enabled = true;
        }
        BackButton.gameObject.SetActive(false);
    }


}
