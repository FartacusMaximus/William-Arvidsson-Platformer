using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform nextLevelLocation;
    public Transform player;
    private SpriteRenderer door;
    public SpriteRenderer doorOpenSprite;
    public PressurePlateScript pressurePlate;
    public SpriteRenderer doorClosedSprite;

    private void Start()
    {
        door = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(pressurePlate.doorOpen == true)
        {
            door.sprite = doorOpenSprite.sprite;
        }
        if(pressurePlate.doorOpen == false)
        {
            door.sprite = doorClosedSprite.sprite;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.position = nextLevelLocation.position;
        }
    }
}
