using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{
    //looks for a SpriteRenderer within the object that this script is attached to and disables it
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
