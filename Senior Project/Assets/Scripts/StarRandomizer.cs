using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRandomizer : MonoBehaviour
{
    public GameObject thisStar;
    public Animator animator;
    int centerX = 394, centerY = 194;


    private void Update()
    {
        StartCoroutine(WaitForTime());
        if (IsAnimationFinished())
        {
            thisStar.transform.position = new Vector3(Random.Range((centerX+25) - (Screen.width/2), (centerX-25) + (Screen.width/2)),
                                                      Random.Range((centerY+25) - (Screen.height/2), (centerY-25) + (Screen.height/2)),
                                                      0);
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds((float)Random.Range(4,9));
    }

    private bool IsAnimationFinished()
    {
        float norm1 = animator.GetCurrentAnimatorStateInfo(0).normalizedTime % 1;
        if (norm1 >= 0.99)
        {
            return true;
        }
        return false;
    }

}
