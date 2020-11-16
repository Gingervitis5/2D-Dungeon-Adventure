using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRandomizer : MonoBehaviour
{
    public GameObject thisStar;
    public Animator animator;
    int plusXBounds = 770, minusXBounds = 12;
    int plusYBounds = 366, minusYBounds = 16;


    private void Update()
    {
        StartCoroutine(WaitForTime());
        if (IsAnimationFinished())
        {
            thisStar.transform.position = new Vector3(Random.Range(minusXBounds, plusXBounds),
                                                      Random.Range(minusYBounds, plusYBounds),
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
