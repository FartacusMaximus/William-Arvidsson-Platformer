﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    //A variable for what score is required before you can complete the level
    public int minimumScoreNeeded = 0;

    //A variable for the name of the scene that should load.
    public string sceneLoad = "Scene1";

    //Makes it so when a trigger triggers in the object to which this is attached
    //and the thing that collided with the trigger was a player and the coins collected is higher or equal to the minimumScoreNeeded the assigned scene loads.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Coins.score >= minimumScoreNeeded)
        {
            Coins.score = 0;
            SceneManager.LoadScene(sceneLoad);
        }
    }
}
