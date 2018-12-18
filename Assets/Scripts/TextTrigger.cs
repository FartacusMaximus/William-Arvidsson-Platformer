using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextTrigger : MonoBehaviour
{
    public string textToAdd = "Insert Text";
    private TextMeshProUGUI hudText;
    
    //looks for TextMeshProUGUI in the parent of the object that this script is attached to and assignes it to hudText
    void Start()
    {
        hudText = GetComponentInParent<TextMeshProUGUI>();
    }
    //When something enter the trigger collider the hudText is set to the textToAdd variable
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hudText.text = string.Format(textToAdd);
    }
}
