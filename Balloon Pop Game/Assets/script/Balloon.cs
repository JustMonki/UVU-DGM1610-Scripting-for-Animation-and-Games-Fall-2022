using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //how many clicks to make the balloon pop

    public float scaleToIncrease = 0.10f; //how much the balloon inflates after each click
    public int scoreToGive = 100;
    private ScoreManager scoreManager;



    // Start is called before the first frame update 
    void Start()
    {
        //reference scoremanager component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDown()
    {
        clickToPop -= 1; //reduce clicks by 1

        //inflate balloon a certain ammount upon click
        transform.localScale += Vector3.one * scaleToIncrease;


        //check to see if click to pop has reached 0, if it has then pop balloon
        if(clickToPop == 0)
        {
            //send points to score manager and update score
            scoreManager.IncreaseScoreText(scoreToGive);
            //destroy balloon
            Destroy(gameObject);
        }
    }
}
