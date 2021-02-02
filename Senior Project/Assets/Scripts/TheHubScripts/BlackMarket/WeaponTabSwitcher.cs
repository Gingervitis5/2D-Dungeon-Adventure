using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WeaponTabSwitcher : MonoBehaviour
{
    public GameObject[] WeaponsGroupArray;
    public GameObject WeaponsGroup;

    public void Switch()
    {
        Debug.Log(WeaponsGroup.transform.name);
        foreach(GameObject g in WeaponsGroupArray)
        {
            if (g.transform.name.Equals(WeaponsGroup.transform.name))
            {
                g.SetActive(true);
            }
            else
            {
                g.SetActive(false);
            }
        }
    }
}
