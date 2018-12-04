using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOpener : MonoBehaviour
{
    public SpriteRenderer activeOpener;
    public Sprite pushed;
    public GameObject connectedLock;

    void Start()
    {
        GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        activeOpener.sprite = pushed;
        connectedLock.SetActive(false);
    }
}
