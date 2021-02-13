using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private GameObject ListContent;
    private GameObject slot;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        ListContent = GameObject.Find("PartyContent");
        canvas = GameObject.Find("MissionBriefingCanvas").GetComponent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
        slot = null;
        Debug.Log("List: " + ListContent.name + " Canvas: " + canvas.name);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        this.gameObject.transform.SetParent(canvas.transform);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = Input.mousePosition;
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerEventData, results);
        bool hit = false;
        foreach(RaycastResult r in results)
        {
            if (r.gameObject.name.Contains("DropBox")) 
            {
                if (slot != null) {
                    Debug.Log("Leaving " + slot.gameObject.name);
                    slot.GetComponent<DropBox>().SetSlottedCharacter(null); //Reset the current slot's character
                }
                Debug.Log("Entering " + r.gameObject.name);
                slot = r.gameObject;    //Set the new slot
                slot.gameObject.GetComponent<DropBox>().SetSlottedCharacter(this.gameObject);   //Set the current slot's character
                hit = true;
            }
        }
        if (!hit) { this.gameObject.transform.SetParent(ListContent.transform); }
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnDrop(PointerEventData eventData)
    {
        
    }
}
