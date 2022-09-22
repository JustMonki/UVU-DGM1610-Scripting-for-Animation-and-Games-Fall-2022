using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLaser : MonoBehaviour
{
    public float upperBound;
    public float lowerBound;    

    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}