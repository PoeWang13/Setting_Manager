using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIDrager : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private RectTransform dragingRect;
    [SerializeField] private Canvas myCanvas;
    [SerializeField] private Image myImage;
    [SerializeField] private Color myBackgroundColor;

    private void Start()
    {
        myBackgroundColor = myImage.color;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        SetBackgroundColor(0.3f);
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        SetBackgroundColor(1);
    }
    private void SetBackgroundColor(float alpha)
    {
        myBackgroundColor.a = alpha;
        if (myImage != null)
        {
            myImage.color = myBackgroundColor;
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        dragingRect.anchoredPosition += eventData.delta / myCanvas.scaleFactor;
    }
}