using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject panel;
    public Sprite originalHub, BM_Highlighted, MB_Highlighted, ArmHighlighted;
    /* BM = Black Market
       MB = Mission Briefing
       Arm = Armaments
    */

    private void FixedUpdate()
    {
        IsMouseOver();
    }

    private void IsMouseOver()  //Check to see if the mouse is over a highlightable object. If so, change the background 
    {
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerEventData, results);

        for (int i = results.Count-1; i >= 0; i--)
        {
            if (results[i].gameObject.GetComponent<UIHighlight>() != null)  //Found a highlightable element
            {
                string objectName = results[i].gameObject.name;
                switch (objectName)
                {
                    case "Black Market":
                        panel.GetComponent<Image>().sprite = BM_Highlighted;
                        break;
                    case "Armaments":
                        panel.GetComponent<Image>().sprite = ArmHighlighted;
                        break;
                    case "Mission Briefing":
                        panel.GetComponent<Image>().sprite = MB_Highlighted;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                panel.GetComponent<Image>().sprite = originalHub;
            }
        }
    }
}
