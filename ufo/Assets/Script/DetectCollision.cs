using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    public ScoreManager ScoreManager;
    public int scoreToGive;


    // Start is called before the first frame update
    void Start()
    {
        ScoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

 
    void OnTriggerEnter(Collider other)
    {
        ScoreManager.IncreaseScore(scoreToGive); //increase score by scoretogive value
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
