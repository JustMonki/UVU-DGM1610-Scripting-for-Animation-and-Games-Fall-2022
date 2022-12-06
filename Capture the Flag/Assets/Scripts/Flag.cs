using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private GameManager gm;
    private Renderer rend;
    

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); //Find objct and reference the game manager component
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        gm.hasFlag = true; //get flag and set bool to true
        rend.enabled = false; //hide flag
    }
}
