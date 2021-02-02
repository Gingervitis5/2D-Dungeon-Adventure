using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerSpinner : MonoBehaviour
{

    void Update()
    {
        this.gameObject.transform.eulerAngles += new Vector3(0, 0, (0.5f % 360));
        if (this.gameObject.transform.rotation.z > 360)
        {
            this.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
