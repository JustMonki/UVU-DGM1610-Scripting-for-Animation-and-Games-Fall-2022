using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int dmgAmout)
    {
        currentHealth -= dmgAmout;

        if(currentHealth <= 0)
        {
            Destroy(gameObject, deathDelay);
        }
    }

    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount; 

        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
