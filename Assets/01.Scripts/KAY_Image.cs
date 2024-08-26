using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class KAY_Image : MonoBehaviour , IBeginDragHandler, IDragHandler , IEndDragHandler
{
    public static GameObject beingDraggedIcon;
    Vector3 startPosition;
    [SerializeField] Transform onDraggParent;
    [SerializeField] public Transform startParent;
    public void OnBeginDrag(PointerEventData eventData)
    {
        beingDraggedIcon = gameObject;

        startPosition = transform.position; 
        startParent = transform.parent;

        GetComponent<CanvasGroup>().blocksRaycasts = false;

        transform.SetParent(onDraggParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        beingDraggedIcon = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}

