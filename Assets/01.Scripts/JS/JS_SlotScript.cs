using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JS_SlotScript : MonoBehaviour, IDropHandler
{
    public event Action<GameObject> OnDroped;
    GameObject Icon()
    {
        if(transform.childCount > 0) 
            return transform.GetChild(0).gameObject;
        else
            return null;
    }
    public void OnDrop(PointerEventData eventData)
    {
        if(Icon() == null)
        {
            JS_DragSlotScript.beingDraggedIcon.transform.SetParent(transform);
            JS_DragSlotScript.beingDraggedIcon.transform.position = transform.position;
            OnDroped?.Invoke(JS_DragSlotScript.beingDraggedIcon);
        }
    }
    
}
