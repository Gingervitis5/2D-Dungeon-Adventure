using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapBuilder : MonoBehaviour
{
    public Room[,] allRooms;
    public MinimapController miniCont;
    public GameObject[,] minimap;
    public Sprite roomSprite;
    public GameObject minimapParent;
    public int positionChanger = 30;

    public Sprite[] oneDoorSprites;
    public Sprite[] twoDoorSprites;
    public Sprite[] threeDoorSprites;
    public Sprite[] fourDoorSprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BuildMap()
    {
        minimap = new GameObject[allRooms.GetLength(0), allRooms.GetLength(1)];
        for (int r = 0; r < allRooms.GetLength(0); r++)
        {
            for (int c = 0; c < allRooms.GetLength(1); c++)
            {
                if(allRooms[r,c].isBlocked() == false)
                {
                    GameObject g = new GameObject();
                    g.transform.position = new Vector3((minimapParent.transform.position.x) + (r * 50), (minimapParent.transform.position.y) + (c * -50));
                    var spriteRen = g.AddComponent<SpriteRenderer>();
                    spriteRen.sprite = determineRoomSprite(allRooms[r, c]);
                    spriteRen.sortingOrder = 100;
                   
                    g.transform.SetParent(minimapParent.transform);
                    g.transform.localScale = new Vector3(3f, 3f, 3f);
                    minimap[r, c] = g;
                }
                
            }
        }

        miniCont.minimap = minimap;
       
    }

    public Sprite determineRoomSprite(Room theRoom)
    {
        int[] doors = theRoom.getDoors();
        int numberOfDoors = theRoom.getNumberOfDoors();
        if (numberOfDoors == 1)
        {
            
            for(int x = 0; x < doors.Length; x++)
            {
                if(doors[x] == 1)
                {
                    return oneDoorSprites[x];
                }
            }
        }
        else if(numberOfDoors == 2)
        {
            
            if(doors[0] == 1 && doors[1] == 1)
            {
                return twoDoorSprites[0];
            }
            else if(doors[1] == 1 && doors[2] == 1)
            {
                return twoDoorSprites[1];
            }
            else if (doors[2] == 1 && doors[3] == 1)
            {
                return twoDoorSprites[2];
            }
            else if (doors[3] == 1 && doors[0] == 1)
            {
                return twoDoorSprites[3];
            }
            else if (doors[0] == 1 && doors[2] == 1)
            {
                return twoDoorSprites[4];
            }
            else if (doors[1] == 1 && doors[3] == 1)
            {
                return twoDoorSprites[5];
            }

        }

        else if (numberOfDoors == 3)
        {
            if (doors[3] == 1 && doors[0] == 1 && doors[1] == 1)
            {
                return threeDoorSprites[0];
            }
            else if (doors[0] == 1 && doors[1] == 1 && doors[2] == 1)
            {
                return threeDoorSprites[1];
            }
            else if (doors[1] == 1 && doors[2] == 1 && doors[3] == 1)
            {
                return threeDoorSprites[2];
            }
            else if (doors[2] == 1 && doors[3] == 1 && doors[0] == 1)
            {
                return threeDoorSprites[3];
            }
        }

        else if (numberOfDoors == 4)
        {
            return fourDoorSprites[0];
        }

        
        return roomSprite;
        
    }
  
}
