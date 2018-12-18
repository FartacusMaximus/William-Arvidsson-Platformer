using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMove : MonoBehaviour
{

    public Transform rockPosition;
    public Transform pickupPosition;
    public Transform dropLocation;
    public BoxCollider2D rockCollider;
    public bool isHolding = false;

    // Update is called once per frame
    void Update()
    {
        PickUpRock();
    }
    //When the player is inside the rock trigger collider it checks if isHolding == false and the F key is pressed the isHolding is set to true and the rock collider is disabled
    //used GetKeyUp instead of GetKeyDown because using the same for both picking up and dropping caused me to instantly drop the rock upon picking it up.
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            DropRock();
        }
    }
    //if isHolding == true then the rocks position is set to the pickup position
    //if isHolding == true and you press the F key isHolding is set to false the rocks colider is reactivated and the rocks position is set to assigned drop pos
    private void PickUpRock()
    {
        if (isHolding == true)
        {
            rockPosition.position = pickupPosition.position;
        }
        if (isHolding == true && Input.GetKeyDown(KeyCode.F))
        {
            isHolding = false;
            rockCollider.enabled = true;
            rockPosition.position = dropLocation.position;
        }
    }
    private void DropRock()
    {
        if (isHolding == false && Input.GetKeyUp(KeyCode.F))
        {
            {
                isHolding = true;
                rockCollider.enabled = false;
            }
        }
    }
}

