using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

 
    void OnTriggerEnter(Collider other)
    {

        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
