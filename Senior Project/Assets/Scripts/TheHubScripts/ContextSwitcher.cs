using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ContextSwitcher : MonoBehaviour    //This switches between menus in The Hub 
{
    public GameObject FadeScreen, ControlPanel;
    public Canvas TheHubCanvas, BlackMarketCanvas, MissionBriefingCanvas, ArmamentsCanvas;
    public GameObject ConsumeIconParent, BMLastScreenOn;

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
                Animation[] BM_Animations = BlackMarketCanvas.GetComponentsInChildren<Animation>();
                for (int i = 0; i < BM_Animations.Length; i++)  // Play animations
                {
                    BM_Animations[i].Play();
                    yield return new WaitForSeconds(2f);
                    if (i == 0)
                    {
                        BlackMarketCanvas.transform.Find("WindowPage").GetComponent<Image>().enabled = true;
                    }
                }
                Button[] buttons = ConsumeIconParent.GetComponentsInChildren<Button>();
                foreach(Button b in buttons)    //Enable button images 
                {
                    b.GetComponent<Image>().enabled = true;
                    b.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
                }
                if (BMLastScreenOn != null) //Set active the last page seen on the Black Market
                {
                    BMLastScreenOn.SetActive(true);
                }
                break;
            case "Mission Briefing":
                //Reset Mission Briefing screen
                MissionBriefingCanvas.transform.Find("MissionBriefingScreen").position = new Vector3(0, -763, 0);
                ControlPanel.GetComponent<ControlPanel>().EnableMissionBriefing();
                Animation[] MB_Animations = MissionBriefingCanvas.GetComponentsInChildren<Animation>();
                for (int i = 0; i < 2; i++) // Play animations
                {
                    MB_Animations[i].Play();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case "Armaments":
                //Reset Vault Door
                ArmamentsCanvas.transform.Find("Vault Door").position = new Vector3(820,420,0);
                ControlPanel.GetComponent<ControlPanel>().EnableArmaments();
                Animation[] ARM_Animations = ArmamentsCanvas.GetComponentsInChildren<Animation>();
                for (int i = ARM_Animations.Length-1; i >= 0; i--)  // Play all animations 
                {
                    ARM_Animations[i].Play();
                    yield return new WaitForSeconds(2f);
                }
                GameObject.FindGameObjectWithTag("Party Master").gameObject.GetComponent<PartyMasterScript>().DisplayRecruitedMembers();
                break;
        }
    }

    public void SetBMLastScreenOn(GameObject last)
    {
        BMLastScreenOn = last;
    }
}
