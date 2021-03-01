using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MinimapController : MonoBehaviour
{
    //public Room [,] allRooms;
    public GameObject[,] minimap;
    public Sprite unfocusedRoom;
    public Sprite focusedRoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateMinimap(Point from, Point to)
    {
        minimap[from.X, from.Y].GetComponent<SpriteRenderer>().sprite = unfocusedRoom;
        minimap[to.X, to.Y].GetComponent<SpriteRenderer>().sprite = focusedRoom;
    }
    private void Awake()
    {
        minimap[0, 0].GetComponent<SpriteRenderer>().sprite = focusedRoom;
    }
}
