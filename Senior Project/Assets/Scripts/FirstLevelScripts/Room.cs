using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Room : MonoBehaviour
public class Room
{
    private bool blocked = true;
    private Sprite roomImage;
    private int north,east,south,west;
    private int numberOfDoors;

    public Room(Sprite backgroundPar, int n, int e, int s, int w, int numOfDoors)
    {
        roomImage = backgroundPar;
        blocked = false;
        this.north = n;
        this.east = e;
        this.south = s;
        this.west = w;
        this.numberOfDoors = numOfDoors;
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

    public int [] getDoors()
    {
        int[] doors = { north, east, south, west };
        return doors;
    }

    public int getNumberOfDoors()
    {
        return numberOfDoors;
    }
}
