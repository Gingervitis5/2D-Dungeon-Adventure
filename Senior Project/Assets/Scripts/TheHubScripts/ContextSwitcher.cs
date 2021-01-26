using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ContextSwitcher : MonoBehaviour
{
    public GameObject FadeScreen, ControlPanel;
    public Canvas TheHubCanvas, BlackMarketCanvas, MissionBriefingCanvas, ArmamentsCanvas;

    public void ButtonPressed()
    {
        FadeScreen.GetComponent<Animation>().Play("FadeAnim");
        StartCoroutine(PlayAnimation());
    }

    IEnumerator PlayAnimation()
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
                foreach (Animation anim in BM_Animations)
                {
                    anim.Play();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case "Armaments":
                //Reset Vault Door
                ArmamentsCanvas.transform.Find("Vault Door").position = new Vector3(789,386,0);
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
