using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDropDown : MonoBehaviour
{
    private PlatformEffector2D effector2D;
    public float waitTime;

    void Start()
    {
        effector2D = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        //resets wait time when key is released
        if(Input.GetKeyUp(KeyCode.S))
        {
            waitTime = 0.5f;
        }

        //flipping effector down
        if(Input.GetKey(KeyCode.S))
        {
            if(waitTime <=0)//if wait time is 0, flip effector down
            {
                effector2D.rotationalOffset = 180f; //flips effector
                waitTime = 0.5f; //sets wait time
            }
            else
            {
                waitTime -= Time.deltaTime; //reduces waittime over time
            }
        }

        //flipping effector back up
        if(Input.GetKey(KeyCode.Space))
        {
            effector2D.rotationalOffset = 0;
        }
    }
}
