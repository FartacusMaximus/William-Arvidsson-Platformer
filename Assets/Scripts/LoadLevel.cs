using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int minimumScoreNeeded = 0;
    public string sceneLoad = "Scene1";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && SkatteSmitning.score >= minimumScoreNeeded)
        {
            SkatteSmitning.score = 0;
            SceneManager.LoadScene(sceneLoad);
        }
    }
}
