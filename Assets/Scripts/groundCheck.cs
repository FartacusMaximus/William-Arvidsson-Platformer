using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    //A bool variable for that is says if the player is touching the ground or not
    public int touching = 0;

    //When something enters the GroundCheckHitbox trigger the isGrounded is set to true
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touching = touching + 1;
    }

    //When something leaves the GroundCheckHitbox trigger the isGrounded variable is set to false
    private void OnTriggerExit2D(Collider2D collision)
    {
        touching = touching - 1;
    }

}
