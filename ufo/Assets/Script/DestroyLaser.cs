using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLaser : MonoBehaviour
{
    public float upperBound;
    public float lowerBound;  
    private ScoreManager scoreManager;  
    private DetectCollision detectCollision;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        detectCollision = GetComponent<DetectCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }

        else if(gameObject.transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            scoreManager.DescreaseScore(detectCollision.scoreToGive); //when ufo gets past player, penalize
        }
    }
}