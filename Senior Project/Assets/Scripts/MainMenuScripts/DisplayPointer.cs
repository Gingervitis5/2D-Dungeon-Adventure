using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DisplayPointer : MonoBehaviour, IPointerEnterHandler
{
    public Image pointer;

    public void OnPointerEnter(PointerEventData eventData) {
        pointer.transform.position = new Vector3(pointer.transform.position.x,
                                                 this.transform.position.y,
                                                 pointer.transform.position.z);
    }

}
