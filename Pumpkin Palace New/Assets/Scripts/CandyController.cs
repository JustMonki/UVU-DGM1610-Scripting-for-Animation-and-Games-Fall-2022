using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyController : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.tag == "Player")
        {
            scoreManager.score += 1;
            Destroy(gameObject);
        }
    }
}
