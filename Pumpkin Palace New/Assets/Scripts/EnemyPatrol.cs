using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public float rayDistance;
    private bool isMovingRight = true;
    public Transform  groundDetection;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //move enemy to right
        //raycasting - produces a ray from an origin point in a certain direction with a set distance
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, rayDistance);

        if(groundInfo.collider == false)
        {
            if(isMovingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0); //flip enemy at edge to move left
                isMovingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0,0,0); //flip enemy at edge to move right
                isMovingRight = true;
            }
        }
    }
}
