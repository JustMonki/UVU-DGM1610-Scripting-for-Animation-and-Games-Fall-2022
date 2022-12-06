using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Flag Info")]
    public bool hasFlag;
    public bool flagPlaced;

    void Start()
    {
        hasFlag = false;
        flagPlaced = false;
    }

    void Update()
    {
        if(flagPlaced)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("You've won!");
    }

    public void PlaceFlag()
    {
        flagPlaced = true;
    }
}