using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarGenerator : MonoBehaviour
{
    public Texture2D starSprite;
    Sprite[] spriteArray = new Sprite[10];
    private SpriteRenderer sr;
    int index = 0;

    private void Start()
    {
        sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
    }

    // Update is called once per frame
    void Update()
    {
        spriteArray[index] = Sprite.Create(starSprite, new Rect(0.0f, 0.0f, starSprite.width, starSprite.height), new Vector2(0.5f, 0.5f));
        //spriteArray[index].
        index = ++index % 10;
    }
}
