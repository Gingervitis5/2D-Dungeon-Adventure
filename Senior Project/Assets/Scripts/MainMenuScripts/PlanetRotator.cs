using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotator : MonoBehaviour
{
    public GameObject redPlanet;

    // Update is called once per frame
    void Update()
    {
        redPlanet.gameObject.transform.eulerAngles += new Vector3(0, 0, (0.005f % 360));
        if (redPlanet.gameObject.transform.rotation.z > 360)
        {
            redPlanet.gameObject.transform.eulerAngles = new Vector3(0,0,0);
        }
    }
}
