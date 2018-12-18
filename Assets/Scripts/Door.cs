using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public BoxCollider2D connectedDoor;
    public Transform nextLevelLocation;
    public Transform player;
    private SpriteRenderer door;
    public SpriteRenderer doorOpenSprite;
    public PressurePlateScript pressurePlate;
    public SpriteRenderer doorClosedSprite;
    public int neededToOpen;


    //looks for a SpriteRenderer within the object that this is attached to and assigns this to the door variable
    //looks for a BoxCollider2D within the object that this is attached to assigns this to the connectedDoor variable
    private void Start()
    {
        door = GetComponent<SpriteRenderer>();
        connectedDoor = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        PressurePlateCheck();
    }

    //if a player enters the doorTrigger the player position is set to next level location
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.position = nextLevelLocation.position;
        }
    }

    //Checks if the pressurePlate.doorOpen is more or  equal to the neededToOpen variable if so the connectedDoor.isTrigger is set to true and the door.sprite is set to the doorOpenSprite.sprite
    //if the pressurePlate.doorOpen is less than neededToOpen then connectedDoor.isTrigger is set to false and the door.sprite is set the doorClosedSprite.sprite
    private void PressurePlateCheck()
    {
        if (pressurePlate.doorOpen >= neededToOpen)
        {
            connectedDoor.isTrigger = true;
            door.sprite = doorOpenSprite.sprite;
        }
        if (pressurePlate.doorOpen < neededToOpen)
        {
            connectedDoor.isTrigger = false;
            door.sprite = doorClosedSprite.sprite;
        }
    }
}
