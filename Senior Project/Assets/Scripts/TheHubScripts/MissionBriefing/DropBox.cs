using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropBox : MonoBehaviour, IDropHandler
{
    private GameObject slottedCharacter;
    public GameObject ListContent;

    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null)
        {
            if (slottedCharacter != null && slottedCharacter != eventData.pointerDrag) { slottedCharacter.transform.SetParent(ListContent.transform); }
            eventData.pointerDrag.GetComponent<RectTransform>().SetParent(this.transform);
            eventData.pointerDrag.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            eventData.pointerDrag.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            slottedCharacter = eventData.pointerDrag;
        }
    }

    public void SetSlottedCharacter(GameObject character)
    {
        slottedCharacter = character;
    }
}
