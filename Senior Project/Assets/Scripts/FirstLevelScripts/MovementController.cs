using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;//needed for using <Image>
using System.Linq;//Used for the contains method for arrays

public class MovementController : MonoBehaviour
{
    public GameObject bckgrnd;
    public RoomBuilder rooms;
    private Point position = new Point(3,0);
    private Point nextPos = new Point(3,0);
    private Point oldPos = new Point(3, 0);
    public MinimapController miniCont;
    public GameObject miniCam;
    public GameObject boundary;
    public MinimapBuilder miniBuilder;
    private int minimapMoveValue = 50;
    

    // Update is called once per frame
    void Update()
    {
        
        //down
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            nextPos = position;
            nextPos.Y++;
            if (CheckAndChangeBackground(2))
            {
                moveMinimap(3);
            }
        }
        //up
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            nextPos = position;
            nextPos.Y--;
            if (CheckAndChangeBackground(0))
            {
                    moveMinimap(1);
            }
        }
        //left
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            nextPos = position;
            nextPos.X--;
            if(CheckAndChangeBackground(3))
            {
                moveMinimap(4);
            }
            
        }
        //right
        else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            nextPos = position;
            nextPos.X++;
            if (CheckAndChangeBackground(1))
            {  
                moveMinimap(2);
            }
        }
    }//end update

    private bool CheckAndChangeBackground(int direction)
    {
        
        if(CheckBoundaries(nextPos.X,nextPos.Y) == true)
        {
            int[] doors = rooms.allRooms[nextPos.X, nextPos.Y].getDoors();
            if (rooms.allRooms[nextPos.X, nextPos.Y].isBlocked() == false)
            {
                if(direction == 0)
                {
                    if(doors[2] == 1)
                    {
                        return CheckAndChangeBackgroundHelper();
                    }
                    else
                    {
                        print("No Door.");
                        return false;
                    }
                }
                else if (direction == 1)
                {
                    if (doors[3] == 1)
                    {
                        return CheckAndChangeBackgroundHelper();
                    }
                    else
                    {
                        print("No Door.");
                        return false;
                    }
                }
                else if (direction == 2)
                {
                    if (doors[0] == 1)
                    {
                        return CheckAndChangeBackgroundHelper();
                    }
                    else
                    {
                        print("No Door.");
                        return false;
                    }
                }
                else if (direction == 3)
                {
                    if (doors[1] == 1)
                    {
                        return CheckAndChangeBackgroundHelper();
                    }
                    else
                    {
                        print("No Door.");
                        return false;
                    }
                }
                else
                {
                    print("Room Blocked.");
                    return false;
                }

            }
            else
            {
                print("Room Blocked.");
                return false;
            }
        }
        else
        {
            print("Cannot proceed.");
            return false;
        }
    }

    private bool CheckAndChangeBackgroundHelper()
    {
        
        Sprite previousMiniSprite = miniBuilder.determineRoomSprite(rooms.allRooms[position.X, position.Y]);
        miniCont.updateMinimap(position, nextPos, previousMiniSprite);
        bckgrnd.GetComponent<Image>().sprite = rooms.allRooms[nextPos.X, nextPos.Y].getBackground();
        oldPos = position;
        position = nextPos;
        print("In room:" + position);
        return true;
    }

    private void moveMinimap(int direction)
    {
        //Up
        if(direction == 1)
        {
            
            miniCam.transform.position = new Vector3(miniCam.transform.position.x, miniCam.transform.position.y + (minimapMoveValue), -50);

        }
        //Right
        else if (direction == 2)
        {
            
            miniCam.transform.position = new Vector3(miniCam.transform.position.x + (minimapMoveValue), miniCam.transform.position.y, -50);
        }
        //Down
        else if (direction == 3)
        {
            
            miniCam.transform.position = new Vector3(miniCam.transform.position.x, miniCam.transform.position.y - (minimapMoveValue), -50);
        }
        //Left
        else if (direction == 4)
        {
            
            miniCam.transform.position = new Vector3(miniCam.transform.position.x - (minimapMoveValue), miniCam.transform.position.y, -50);
        }

    }

    public bool CheckBoundaries(int x, int y)
    {
        if (x < 0 || y < 0)
        {
            
            return false;
        }
        if (x >= rooms.allRooms.GetLength(0))
        {
            
            return false;
        }
        if (y >= rooms.allRooms.GetLength(1))
        {
            
            return false;
        }
        else
        {
            return true;
        }
    }

}
