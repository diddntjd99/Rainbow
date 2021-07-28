using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoyStickBackController : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private Image BackGroundImg;
    private Image JoyStickImg;
    private Vector3 inputVector;

    void Start()
    {
        BackGroundImg = GetComponent<Image>();
        JoyStickImg = transform.GetChild(0).GetComponent<Image>();
    }

    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(BackGroundImg.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / BackGroundImg.rectTransform.sizeDelta.x);
            pos.y = (pos.y / BackGroundImg.rectTransform.sizeDelta.y);

            inputVector = new Vector3(pos.x * 2, pos.y * 2, 0);
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

            JoyStickImg.rectTransform.anchoredPosition = new Vector3(inputVector.x * (BackGroundImg.rectTransform.sizeDelta.x / 3), inputVector.y * (BackGroundImg.rectTransform.sizeDelta.y / 3));
        }
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputVector = Vector3.zero;
        JoyStickImg.rectTransform.anchoredPosition = Vector3.zero;
    }

    public float GetHorizontalValue()
    {
        return inputVector.x;
    }

    public float GetVerticalValue()
    {
        return inputVector.y;
    }
}