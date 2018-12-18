using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateScript : MonoBehaviour
{
    public int doorOpen;
    public BoxCollider2D TriggerCollider;
    //Makes it so when either the player or the pickup able object stays inside the assigned trigger the doorOpen Value is set to 1
    //I used OnTriggerStay instead of OnTriggerEnter because the collider wouldn't trigger when the pickup objects entered since their
    //position is set to a location so it technically it doesn't enter it just appears in the trigger.
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "PickupAble")
        {
            doorOpen = +1;
        }
        if (collision.tag == "Player")
        {
            doorOpen = +1;
        }
    }
    //maks it so when either the player or a pickup object leaves the assigned trigger collider the doorOpen value is set to 0
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "PickupAble")
        {
            doorOpen = 0;
        }
        if (collision.tag == "Player")
        {
            doorOpen = 0;
        }
    }
}
