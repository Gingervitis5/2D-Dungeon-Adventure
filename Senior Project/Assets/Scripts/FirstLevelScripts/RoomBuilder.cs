using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBuilder : MonoBehaviour
{
    public Room[,] allRooms;
    public Sprite[] listOfBackgrounds;
    public MinimapBuilder minimapBuilder;
    

    
    public RoomBuilder()
    {
        allRooms = new Room[3, 2];
        //InitializeRooms();
        //awake();
    }
    /*
    private void Start()
    {
        allRooms = new Room[3, 3];
    }
    */

    private void Awake()
    {
        
        allRooms[0, 0] = new Room(listOfBackgrounds[0]);
        allRooms[1, 0] = new Room(listOfBackgrounds[1]);
        allRooms[2, 0] = new Room(listOfBackgrounds[2]);

        allRooms[0, 1] = new Room(listOfBackgrounds[3]);
        allRooms[1, 1] = new Room();
        allRooms[2, 1] = new Room(listOfBackgrounds[4]);

        BuildMinimap();

    }

    private void BuildMinimap()
    {
        minimapBuilder.allRooms = allRooms;
        minimapBuilder.BuildMap();
        
    }
    /*
public bool CheckBoundaries(int x, int y)
{
   if(x < 0 || y < 0)
   {
       return false;
   }
   if(x > allRooms.GetLength(0))
   {
       return false;
   }
   if(y > allRooms.GetLength(1))
   {
       return false;
   }
   else
   {
       return true;
   }
}
*/
}
