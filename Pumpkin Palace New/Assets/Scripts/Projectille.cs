using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectille : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 10;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//reference rigidbody2d component
        rb.velocity = transform.right * speed;//moves the projectile forward
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if(other.gameObject.CompareTag("Enemy"))//if it hits something tagged as enemy
        {
            enemy.TakeDamage(damage);//run takedamage function
        }
        Destroy(gameObject);//unalive projectile
    }
}
