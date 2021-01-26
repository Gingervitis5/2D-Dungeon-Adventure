using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlPanel : MonoBehaviour
{
    public Canvas TheHub, BlackMarket, MissionBriefing, Armaments;

    private void Awake()
    {
        TheHub.enabled = true;
        BlackMarket.enabled = false;
        MissionBriefing.enabled = false;
        Armaments.enabled = false;
    }

    public void BackToHub()
    {
        TheHub.enabled = true;
        TheHub.GetComponentInChildren<RawImage>().color = new Color(0, 0, 0, 0);
        BlackMarket.enabled = false;
        MissionBriefing.enabled = false;
        Armaments.enabled = false;
    }

    public void EnableBlackMarket()
    {
        BlackMarket.enabled = true;
        TheHub.enabled = false;
    }

    public void EnableMissionBriefing()
    {
        MissionBriefing.enabled = true;
        TheHub.enabled = false;
    }

    public void EnableArmaments()
    {
        Armaments.enabled = true;
        TheHub.enabled = false;
    }
}
