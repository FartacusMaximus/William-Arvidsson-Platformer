using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOpener : MonoBehaviour
{
    public SpriteRenderer activeOpener;
    public Sprite pushed;
    public GameObject connectedLock;
    
    //Look for a SpriteRenderer within the object that this script is attached to
    void Start()
    {
        GetComponent<SpriteRenderer>();
    }

    //when something enters the trigger the activeOpener.sprite is set to pushed and then the connectedLock is set to inactive
    private void OnTriggerEnter2D(Collider2D collision)
    {
        activeOpener.sprite = pushed;
        connectedLock.SetActive(false);
    }
}
