using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarGenerator : MonoBehaviour
{
    public Sprite starSprite;
    GameObject[] spriteArray;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        spriteArray = new GameObject[10];
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {

        index = ++index % 10;
    }
}
