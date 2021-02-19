using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject    // Class representing some item the player can use in some fashion
                                        // DO NOT attach to a GameObject
{
    public string ItemName;
    public Sprite ItemImage;

    protected Item(string name)
    {
        ItemName = name;
    }

    public void SetItemName(string NewName) { ItemName = NewName; }
    public void SetItemImage(Sprite image) { ItemImage = image; }
}
