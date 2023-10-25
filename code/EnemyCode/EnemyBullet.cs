using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

   public float speed = 1f; 
   public int damage = 2;
   public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        
        if (hitInfo.GetComponent<BoxCollider2D>().tag == "Player")
        {
            PlayerStats Player = hitInfo.GetComponent<PlayerStats>();

            if (Player != null)
            {
                Player.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
        
    }
}
