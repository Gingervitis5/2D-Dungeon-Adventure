using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ContextSwitcher : MonoBehaviour
{
    public GameObject FadeScreen, ControlPanel;
    public Canvas TheHubCanvas, BlackMarketCanvas, MissionBriefingCanvas, ArmamentsCanvas;

    public void HubButtonPressed()
    {
        FadeScreen.GetComponent<Animation>().Play("FadeAnim");
        StartCoroutine(PlayHubAnimation());
    }

    IEnumerator PlayHubAnimation()
    {
        yield return new WaitForSeconds(2.5f);
        switch (this.gameObject.name)
        {
            case "Black Market":
                ControlPanel.GetComponent<ControlPanel>().EnableBlackMarket();
                BlackMarketCanvas.GetComponentInChildren<Animation>().Play("Black Market_Startup");
                break;
            case "Mission Briefing":
                //Reset Mission Briefing screen
                MissionBriefingCanvas.transform.Find("MissionBriefingScreen").position = new Vector3(0, -763, 0);
                ControlPanel.GetComponent<ControlPanel>().EnableMissionBriefing();
                Animation[] BM_Animations = MissionBriefingCanvas.GetComponentsInChildren<Animation>();
                for (int i = 0; i < 2; i++)
                {
                    BM_Animations[i].Play();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case "Armaments":
                //Reset Vault Door
                ArmamentsCanvas.transform.Find("Vault Door").position = new Vector3(798,386,0);
                ControlPanel.GetComponent<ControlPanel>().EnableArmaments();
                Animation[] ARM_Animations = ArmamentsCanvas.GetComponentsInChildren<Animation>();
                for (int i = ARM_Animations.Length-1; i >= 0; i--)
                {
                    ARM_Animations[i].Play();
                    yield return new WaitForSeconds(2f);
                }
                break;
        }
    }
}
