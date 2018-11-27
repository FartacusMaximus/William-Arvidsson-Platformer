using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    //Variable for player movement Speed which is editable in unity
    public float moveSpeed = 6f;
    //Variable for player jump height which is editable in unity
    public float jumpSpeed = 12f;

    //A private variable which lets me edit the players Rigidbody2D within this script
    private Rigidbody2D rbody;
    //A Variable which is linked to the groundCheck script and this lets me call upon variables from the groundCheck
    public groundCheck groundcheck;
    // Use this for initialization
    void Start()
    {
        //Looks for a Rigidbody2D in the object that the script is attached to
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes it so when the assigned input keys for horizontal movement are pressed the player characther moves based on player moveSpeed
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") *moveSpeed, rbody.velocity.y);
        //When the assigned jump key is pressed and the player is grounded the player will jump based on jumpSpeed
        if (Input.GetButtonDown("Jump"))
        {
            if(groundcheck.isGrounded == true)
            rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
        }

    }
}
