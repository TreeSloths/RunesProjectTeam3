using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler {

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public Transform parentToReturnTo = null;
    
    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag");

        parentToReturnTo = rectTransform.parent;
        rectTransform.SetParent(rectTransform.parent.parent);
        
        canvasGroup.blocksRaycasts = false;
    }
    
    public void OnDrag(PointerEventData eventData) {
        rectTransform.anchoredPosition += eventData.delta;
    }
    
    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("OnEndDrag");
        rectTransform.SetParent(parentToReturnTo);
        
        canvasGroup.blocksRaycasts = true;
    }

}