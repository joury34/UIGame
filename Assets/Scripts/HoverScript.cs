
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;  

public class HoverScript : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    [Header("Assign these in Inspector")]
    public Image borderImage;
    public TMP_Text buttonText;

    [Header("Colors")]
    public Color borderNormalColor = Color.white;
    public Color borderHoverColor = Color.yellow;
    public Color textNormalColor = Color.white;
    public Color textHoverColor = Color.yellow;


    public void OnPointerEnter(PointerEventData eventData)
    {
        if (borderImage != null)
            borderImage.color = borderHoverColor;

        if (buttonText != null)
            buttonText.color = textHoverColor;
    }

    // Called when mouse pointer exits the button area
    public void OnPointerExit(PointerEventData eventData)
    {
        if (borderImage != null)
            borderImage.color = borderNormalColor;

        if (buttonText != null)
            buttonText.color = textNormalColor;
    }
}


