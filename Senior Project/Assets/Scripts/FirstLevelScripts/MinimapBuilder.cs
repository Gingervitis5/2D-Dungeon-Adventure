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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
                    //689, 387
                    //g.transform.position = new Vector3(r * 10, c * -10);
                    g.transform.position = new Vector3((minimapParent.transform.position.x) +(r * 30),(minimapParent.transform.position.y) + ( c * -30));
                    var spriteRen = g.AddComponent<SpriteRenderer>();
                    spriteRen.sprite = roomSprite;
                    spriteRen.sortingOrder = 100;
                   
                    g.transform.SetParent(minimapParent.transform);
                    g.transform.localScale = new Vector3(3f, 3f, 3f);
                    minimap[r, c] = g;
                }
                
                //s.color = new Color(r, c, r + c);
            }
        }

        miniCont.minimap = minimap;
       
    }
  
}
