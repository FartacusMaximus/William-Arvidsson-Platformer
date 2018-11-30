using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateScript : MonoBehaviour
{

    public BoxCollider2D connectedDoor;
    public BoxCollider2D TriggerCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        connectedDoor.isTrigger = true;
    }
}
