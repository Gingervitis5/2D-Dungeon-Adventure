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
            if (g.GetComponent<DropBox>().GetSlottedCharacter() == null) { promising = false; }
        }
        if (promising)
        {
            Transition.GetComponent<Animation>().Play("MissionStart");
            WaitForAnim();
        }
    }
    IEnumerator WaitForAnim()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}
