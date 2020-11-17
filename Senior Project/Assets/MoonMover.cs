using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonMover : MonoBehaviour
{
    public GameObject moon;
    int moonWidth = 177;

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(-0.05f, -0.001f, 0);
        moon.gameObject.transform.position += move;
        moon.gameObject.transform.eulerAngles += new Vector3(0,0,(0.025f % 360));

        if (moon.gameObject.transform.position.x < (Screen.width - Screen.width) - (moonWidth))
        {
            moon.gameObject.transform.position = new Vector3(Screen.width + (moonWidth / 2),
                                                             Screen.height - (moonWidth / 2), 0);
        }
    }
}
