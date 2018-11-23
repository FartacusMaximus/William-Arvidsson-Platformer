using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkatteSmitning : MonoBehaviour
{
    public static int score;

    private float spinSpeed = 180;
    public int amount = 1;

    private void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SkatteSmitning.score += amount;
            Destroy(gameObject);
        }
    }
}
