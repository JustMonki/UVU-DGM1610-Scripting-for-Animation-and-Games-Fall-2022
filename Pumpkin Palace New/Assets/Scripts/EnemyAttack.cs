using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Health playerHealth;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if(other.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);
            Debug.Log("Player takes "+ damage +" points of damage");
        }
    }
}