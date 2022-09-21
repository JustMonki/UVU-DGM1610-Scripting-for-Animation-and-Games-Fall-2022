using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;

    public float xRange;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalloon()
    {
        //get random position on x axis
        Vector3 spawnPosX = new Vector3(Random.Range(xRange,-xRange),0,0);
        //pick random balloon from array
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);
        //spawn a random balloon at spawnpoint
        Instantiate(balloonPrefabs[balloonIndex], spawnPosX, balloonPrefabs[balloonIndex].transform.rotation);

    }
}
