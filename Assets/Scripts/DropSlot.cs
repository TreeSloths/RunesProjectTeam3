using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler {

    public int amountOfSpaces;
    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null && transform.childCount < amountOfSpaces) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<Draggable>().parentToReturnTo = transform;
        }
    }
}
