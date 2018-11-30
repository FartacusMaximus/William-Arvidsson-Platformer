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

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
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
}
