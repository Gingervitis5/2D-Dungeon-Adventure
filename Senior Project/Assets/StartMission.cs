using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartMission : MonoBehaviour
{
    public GameObject[] DropBoxes;
    public GameObject Transition;

    public void StartMission1()
    {
        bool promising = true;
        foreach (GameObject g in DropBoxes)
        {
            if (g.GetComponent<DropBox>().GetSlottedCharacter() == null) {
                promising = false;
            }
        }
        if (promising)
        {
            foreach (GameObject g in DropBoxes)
            {
                PartyMasterScript.AddPartyMember(g.GetComponent<DropBox>().GetSlottedCharacter().GetComponent<DisplayPartyInfo>().GetCharacter());
            }
            Transition.GetComponent<Animation>().Play("MissionStart");
            StartCoroutine(WaitForAnim());
        }
    }
    IEnumerator WaitForAnim()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
