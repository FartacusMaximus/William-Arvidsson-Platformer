using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //A variable for the score that is the same on all scripts that this is applied to
    public static int score;

    private float spinSpeed = 180;
    public int amount = 1;
    
    private void Update()
    {
        //makes it so that the coins spins based on assigned spinSpeed
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When something collides with the coin and that object has the "Player" tag the coin is destroyed and the score is increased by the coin's value
        if (collision.tag == "Player")
        {
            Coins.score += amount;
            Destroy(gameObject);
        }
    }
}
