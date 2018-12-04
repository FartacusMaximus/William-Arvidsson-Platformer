using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateScript : MonoBehaviour
{
    public bool doorOpen;
    public BoxCollider2D connectedDoor;
    public BoxCollider2D TriggerCollider;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "PickupAble")
        {
            connectedDoor.isTrigger = true;
            doorOpen = true;
        }
        if (collision.tag == "Player")
        {
            connectedDoor.isTrigger = true;
            doorOpen = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        connectedDoor.isTrigger = false;
        doorOpen = false;
    }
}
