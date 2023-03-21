using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.transform.GetChild(0).GetComponent<LineRenderer>().enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        gameObject.transform.GetChild(0).GetComponent<LineRenderer>().enabled = false;
    }
}
