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
        allRooms = new Room[9, 10];
        
    }
   
    private void Awake()
    {
        //Parameters are (background sprite, (has door to the: )North, east, south, west, number of doors.
        //Empty rooms use the default constructor
        allRooms[0, 0] = new Room(listOfBackgrounds[0],0,1,1,0,2);
        allRooms[1, 0] = new Room(listOfBackgrounds[1],0,1,0,1,2);
        allRooms[2, 0] = new Room(listOfBackgrounds[2],0,1,0,1,2);
        allRooms[3, 0] = new Room(listOfBackgrounds[3],0,0,0,1,1);
        allRooms[4, 0] = new Room(listOfBackgrounds[4],0,1,1,0,2);
        allRooms[5, 0] = new Room(listOfBackgrounds[5],0,1,0,1,2);
        allRooms[6, 0] = new Room(listOfBackgrounds[6],0,1,0,1,2);
        allRooms[7, 0] = new Room(listOfBackgrounds[7],0,0,1,1,2);
        allRooms[8, 0] = new Room();


        allRooms[0, 1] = new Room(listOfBackgrounds[8],1,1,1,0,3);
        allRooms[1, 1] = new Room(listOfBackgrounds[9],0,1,0,1,2);
        allRooms[2, 1] = new Room(listOfBackgrounds[10],0,1,0,1,2);
        allRooms[3, 1] = new Room(listOfBackgrounds[11],0,1,1,1,3);
        allRooms[4, 1] = new Room(listOfBackgrounds[12],1,0,0,1,2);
        allRooms[5, 1] = new Room();
        allRooms[6, 1] = new Room();
        allRooms[7, 1] = new Room(listOfBackgrounds[13],1,1,0,0,2);
        allRooms[8, 1] = new Room(listOfBackgrounds[14],0,0,0,1,1);

        allRooms[0, 2] = new Room(listOfBackgrounds[15],1,1,0,0,2);
        allRooms[1, 2] = new Room(listOfBackgrounds[16],0,1,1,1,3);
        allRooms[2, 2] = new Room(listOfBackgrounds[17],0,1,1,1,3);
        allRooms[3, 2] = new Room(listOfBackgrounds[18],1,0,1,1,3);
        allRooms[4, 2] = new Room();
        allRooms[5, 2] = new Room();
        allRooms[6, 2] = new Room();
        allRooms[7, 2] = new Room();
        allRooms[8, 2] = new Room();

        allRooms[0, 3] = new Room();
        allRooms[1, 3] = new Room(listOfBackgrounds[19],1,1,1,0,3);
        allRooms[2, 3] = new Room(listOfBackgrounds[20],1,0,0,1,2);
        allRooms[3, 3] = new Room(listOfBackgrounds[21],1,1,1,0,3);
        allRooms[4, 3] = new Room(listOfBackgrounds[22],0,0,0,1,1);
        allRooms[5, 3] = new Room();
        allRooms[6, 3] = new Room();
        allRooms[7, 3] = new Room();
        allRooms[8, 3] = new Room();

        allRooms[0, 4] = new Room();
        allRooms[1, 4] = new Room(listOfBackgrounds[23],1,1,1,0,3);
        allRooms[2, 4] = new Room(listOfBackgrounds[24],0,1,0,1,2);
        allRooms[3, 4] = new Room(listOfBackgrounds[25],1,0,1,1,3);
        allRooms[4, 4] = new Room();
        allRooms[5, 4] = new Room();
        allRooms[6, 4] = new Room(listOfBackgrounds[26],0,1,1,0,2);
        allRooms[7, 4] = new Room(listOfBackgrounds[27],0,1,1,1,3);
        allRooms[8, 4] = new Room(listOfBackgrounds[28],0,0,1,1,2);

        allRooms[0, 5] = new Room();
        allRooms[1, 5] = new Room(listOfBackgrounds[29],1,0,1,0,2);
        allRooms[2, 5] = new Room();
        allRooms[3, 5] = new Room(listOfBackgrounds[30],1,0,1,0,2);
        allRooms[4, 5] = new Room();
        allRooms[5, 5] = new Room();
        allRooms[6, 5] = new Room(listOfBackgrounds[31],1,0,1,0,2);
        allRooms[7, 5] = new Room(listOfBackgrounds[32],1,1,0,0,2);
        allRooms[8, 5] = new Room(listOfBackgrounds[33],1,0,0,1,2);

        allRooms[0, 6] = new Room();
        allRooms[1, 6] = new Room(listOfBackgrounds[34],1,1,0,0,2);
        allRooms[2, 6] = new Room(listOfBackgrounds[35],0,1,1,1,3);
        allRooms[3, 6] = new Room(listOfBackgrounds[36],1,1,1,1,4);
        allRooms[4, 6] = new Room(listOfBackgrounds[37],0,1,0,1,2);
        allRooms[5, 6] = new Room(listOfBackgrounds[38],0,1,0,1,2);
        allRooms[6, 6] = new Room(listOfBackgrounds[39],1,1,1,1,4);
        allRooms[7, 6] = new Room(listOfBackgrounds[40],0,0,0,1,1);
        allRooms[8, 6] = new Room();

        allRooms[0, 7] = new Room(listOfBackgrounds[41],0,1,1,0,2);
        allRooms[1, 7] = new Room(listOfBackgrounds[42],0,0,0,1,1);
        allRooms[2, 7] = new Room(listOfBackgrounds[43],1,1,0,0,2);
        allRooms[3, 7] = new Room(listOfBackgrounds[44],1,1,1,1,4);
        allRooms[4, 7] = new Room(listOfBackgrounds[45],0,1,0,1,2);
        allRooms[5, 7] = new Room(listOfBackgrounds[46],0,1,0,1,2);
        allRooms[6, 7] = new Room(listOfBackgrounds[47],1,0,1,1,3);
        allRooms[7, 7] = new Room();
        allRooms[8, 7] = new Room();

        allRooms[0, 8] = new Room(listOfBackgrounds[48],1,1,1,0,3);
        allRooms[1, 8] = new Room(listOfBackgrounds[49],0,1,0,1,2);
        allRooms[2, 8] = new Room(listOfBackgrounds[50],0,1,0,1,2);
        allRooms[3, 8] = new Room(listOfBackgrounds[51],1,1,0,1,3);
        allRooms[4, 8] = new Room(listOfBackgrounds[52],0,1,1,1,3);
        allRooms[5, 8] = new Room(listOfBackgrounds[53],0,1,1,1,3);
        allRooms[6, 8] = new Room(listOfBackgrounds[54],1,1,1,1,4);
        allRooms[7, 8] = new Room(listOfBackgrounds[55],0,0,0,1,1);
        allRooms[8, 8] = new Room();

        allRooms[0, 9] = new Room(listOfBackgrounds[56],1,1,0,0,2);
        allRooms[1, 9] = new Room(listOfBackgrounds[57],0,1,0,1,2);
        allRooms[2, 9] = new Room(listOfBackgrounds[58],0,0,0,1,1);
        allRooms[3, 9] = new Room();
        allRooms[4, 9] = new Room(listOfBackgrounds[59],1,1,0,0,2);
        allRooms[5, 9] = new Room(listOfBackgrounds[60],1,1,0,1,3);
        allRooms[6, 9] = new Room(listOfBackgrounds[61],1,0,0,1,2);
        allRooms[7, 9] = new Room();
        allRooms[8, 9] = new Room();

        BuildMinimap();

    }

    private void BuildMinimap()
    {
        minimapBuilder.allRooms = allRooms;
        minimapBuilder.BuildMap();
        
    }

}
