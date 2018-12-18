using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenUntillTriggerd : MonoBehaviour
{
    public bool canBeHidden = false;
    public PressurePlateScript pressurePlate;
    public int revealValue = 0;
    public Transform xScale;
    
    //looks in the object the script is attached to for a transform component and it is assigned to the xScale variable
    //then sets the xScale localScale to 0,1 which renders it invisible
    void Start()
    {
        GetComponent<Transform>();
        xScale.localScale = new Vector2(0f, 1);
    }
    //if the object that this script is attached to can be hidden and the pressurePlate.doorOpen is equal to the revealValue then the xScale localscale is set to 1f,1 which renders it and visable again
    void Update()
    {
        if (canBeHidden == true && pressurePlate.doorOpen == revealValue)
        {
            xScale.localScale = new Vector2(1f,1);
        }
    }
}
