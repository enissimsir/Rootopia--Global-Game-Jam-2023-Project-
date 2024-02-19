using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScaling : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public RectTransform Button;
    // Start is called before the first frame update
    void Start()
    {
        Button.GetComponent<Animator>().Play("Button Not Pointing");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("Button Pointing");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("Button Not Pointing");
    }

}
