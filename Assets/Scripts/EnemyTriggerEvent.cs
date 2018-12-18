using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerEvent : MonoBehaviour
{
    public EnemyHorizontalMovement enemyToAwake;
    //Makes it so when the player collides with the assigned trigger collider the enemy wakes up
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enemyToAwake.isAwake = true;
        }
    }
}
