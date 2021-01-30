using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ResetBlackMarketScreen : MonoBehaviour
{
    public void Reset()
    {
        transform.parent.transform.Find("WindowPage").GetComponent<Image>().enabled = false;
    }
}
