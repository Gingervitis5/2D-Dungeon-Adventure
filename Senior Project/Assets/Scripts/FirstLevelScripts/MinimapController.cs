using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MinimapController : MonoBehaviour
{
    
    public GameObject[,] minimap;
    public Sprite unfocusedRoom;
    public Sprite focusedRoom;
    public Sprite prevRoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    public void updateMinimap(Point from, Point to, Sprite prevMiniSprite)
    {
        minimap[from.X, from.Y].GetComponent<SpriteRenderer>().sprite = prevMiniSprite;
        minimap[to.X, to.Y].GetComponent<SpriteRenderer>().sprite = focusedRoom;
    }
    private void Awake()
    {
        minimap[3, 0].GetComponent<SpriteRenderer>().sprite = focusedRoom;
    }

   
}
