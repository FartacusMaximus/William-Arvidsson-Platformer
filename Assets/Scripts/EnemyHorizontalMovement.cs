using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //A variable for the enemy move speed
    public float speed = 2f;
    //A bool Variable for if the enemy is supposed to go left or not left
    public bool left = true;
    //A private variable that lets you modify the object rigidbody withing the script
    private Rigidbody2D rbody;

    void Start()
    {
        //looks for a Rigidbody2D in the object that this script is attached to
        rbody = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
        //if the left variable is true then the enemy scale is set so that the sprite is facing left and start moving in that direction
        if (left == true)
        {
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        //if else the enemy scale is set so that it is facing the right and will then start moving in that direction
        else
        {
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the enemy collides with a colider that has the tag "InvisibleWall" the left variable current state is set to the opposite state
        if(collision.tag == "InvisibleWall")
        {
            left = !left;
        }
    }
}
