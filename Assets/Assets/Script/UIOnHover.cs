using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class UIOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 _cachedScale;
    
    void Start()
    {
        _cachedScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = new Vector3(1.2f, 1.2f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = _cachedScale;
    }
}
