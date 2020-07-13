using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {
    public Image Image;
    public Sprite Sprite, HoverSprite;
    public UnityEvent ClickEvent;

    public void OnPointerEnter(PointerEventData eventData) {
        Image.sprite = HoverSprite;
    }

    public void OnPointerExit(PointerEventData eventData) {
        Image.sprite = Sprite;
    }

    public void OnPointerClick(PointerEventData eventData) {
        ClickEvent?.Invoke();
    }

}
