using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundController : MonoBehaviour
{
    public Sprite Room2;
    public GameObject bckgrnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        float verticalValue = Input.GetAxis("Vertical");
        float horizontalValue = Input.GetAxis("Horizontal");
        if(verticalValue < 0){
            print("Down");
            //this.gameObject.GetComponent<SpriteRenderer>().sprite = Room2;
            bckgrnd.GetComponent<Image>().sprite = Room2;
        }
        else if(verticalValue > 0){
            print("Up");
        }
        else if(horizontalValue < 0) {
            print("Left");
        }
        else if(horizontalValue > 0) {
            print("Right");
        }
    }
}
