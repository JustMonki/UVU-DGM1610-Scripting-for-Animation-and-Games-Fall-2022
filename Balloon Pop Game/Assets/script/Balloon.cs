using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //how many clicks to make the balloon pop

    public float scaleToIncrease = 0.10f; //how much the balloon inflates after each click



    // Start is called before the first frame update 
    void Start()
    {
        
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
            Destroy(gameObject);
        }
    }
}
