using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Room : MonoBehaviour
public class Room
{
    private bool blocked = true;
    private Sprite roomImage;

    public Room(Sprite backgroundPar)
    {
        roomImage = backgroundPar;
        blocked = false;
    }
    public Room()
    {
        //empty Room that will remain blocked.
    }
    public void setBackground(Sprite background)
    {
        this.roomImage = background;
        this.blocked = false;
    }
    public Sprite getBackground()
    {
        return this.roomImage;
    }

    public bool isBlocked()
    {
        return this.blocked;
    }
}
