using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        //if (transform.childCount == 0) 
      // {
           
       // }

        
        GameObject dropped = eventData.pointerDrag;
        DraggableItems draggableItem = dropped.GetComponent<DraggableItems>();
        if (transform.childCount > 0)
        {
            transform.GetChild(0).SetParent(draggableItem.ParentBeforeDrag);
        }
        draggableItem.parentAfterDrag = transform;
    }


}
