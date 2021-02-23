using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;//needed for using <Image>

public class MovementController : MonoBehaviour
{
    public GameObject bckgrnd;
    public RoomBuilder rooms;
    private Point position = new Point(0,0);
    private Point nextPos = new Point(0,0);
    public MinimapController miniCont;
    

    // Update is called once per frame
    void Update()
    {
        float verticalValue = Input.GetAxis("Vertical");
        float horizontalValue = Input.GetAxis("Horizontal");
        //down
        //if (verticalValue < 0)
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            nextPos = position;
            nextPos.Y++;
            //verticalValue = 0;
            CheckAndChangeBackground();
        }
        //up
        //else if (verticalValue > 0)
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            nextPos = position;
            nextPos.Y--;
            //verticalValue = 0;
            CheckAndChangeBackground();
        }
        //left
        //else if (horizontalValue < 0)
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            nextPos = position;
            nextPos.X--;
            //horizontalValue = 0;
            CheckAndChangeBackground();
        }
        //right
        //else if (horizontalValue > 0)
        else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            nextPos = position;
            nextPos.X++;
            //horizontalValue = 0;
            CheckAndChangeBackground();
        }
    }//end update

    private void CheckAndChangeBackground()
    {
        //if (rooms.CheckBoundaries(nextPos.X, nextPos.Y) == true)
        if(CheckBoundaries(nextPos.X,nextPos.Y) == true)
        {
            if (rooms.allRooms[nextPos.X, nextPos.Y].isBlocked() == false)
            {
                miniCont.updateMinimap(position, nextPos);
                bckgrnd.GetComponent<Image>().sprite = rooms.allRooms[nextPos.X, nextPos.Y].getBackground();
                position = nextPos;
                print("In room:" + position);
            }
            else
            {
                print("Room Blocked.");
            }
        }
        else
        {
            print("Cannot proceed.");
        }
    }

    public bool CheckBoundaries(int x, int y)
    {
        if (x < 0 || y < 0)
        {
            //BadBoundary(x, y);
            return false;
        }
        if (x >= rooms.allRooms.GetLength(0))
        {
            //BadBoundary(x, y);
            return false;
        }
        if (y >= rooms.allRooms.GetLength(1))
        {
            //BadBoundary(x, y);
            return false;
        }
        else
        {
            return true;
        }
    }

    public void BadBoundary(int a, int b)
    {

    }
}
