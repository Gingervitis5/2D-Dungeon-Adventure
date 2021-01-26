using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ContextSwitcher : MonoBehaviour
{
    public GameObject FadeScreen, ControlPanel;
    public Canvas TheHubCanvas, BlackMarketCanvas, MissionBriefingCanvas;

    public void ButtonPressed()
    {
        FadeScreen.GetComponent<Animation>().Play("FadeAnim");
        StartCoroutine(PlayAnimation());
    }

    IEnumerator PlayAnimation()
    {
        yield return new WaitForSeconds(2);
        switch (this.gameObject.name)
        {
            case "Black Market":
                ControlPanel.GetComponent<ControlPanel>().EnableBlackMarket();
                BlackMarketCanvas.GetComponentInChildren<Animation>().Play("Black Market_Startup");
                break;
            case "Mission Briefing":
                ControlPanel.GetComponent<ControlPanel>().EnableMissionBriefing();
                Animation[] animations = MissionBriefingCanvas.GetComponentsInChildren<Animation>();
                foreach (Animation anim in animations)
                {
                    anim.Play();
                }
                break;
            case "Armaments":
                Debug.Log("Armaments Pressed");
                break;
        }
    }
}
