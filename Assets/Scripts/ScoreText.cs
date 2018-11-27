using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    //Creates a private TextMeshProGui variable.
    private TextMeshProUGUI text;

    void Start()
    {
        //looks for a TextMeshProGui component in the object which the script is attached to and assignes the component to the "text" variable
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Tells the text variable to change its text to "Skatte Pengar Stolen"
        //the number within this  => {} will change accordingly to coin score
        text.text = string.Format("Skatte Pengar Stolen:{0}", Coins.score);
    }
}
