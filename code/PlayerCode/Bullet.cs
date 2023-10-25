using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
public float speed = -20f; 
public int damage = 2;
public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        if (hitInfo.GetComponent<BoxCollider2D>().tag == "BadGuy")
        {
            Enemy enemy = hitInfo.GetComponent<Enemy>();
            if (enemy != null)
            {
            enemy.TakeDamage(damage);
            }

            boss boss = hitInfo.GetComponent<boss>();
            if (boss != null)
            {
                boss.TakeDamage(damage);
            }

        Destroy(gameObject);
        }

        if (hitInfo.GetComponent<BoxCollider2D>().tag == "Wall")
        {
        Destroy(gameObject);
        }
        
    }
}