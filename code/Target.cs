using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   public int health = 6;
   int damage = 2;
   public Transform point;
   public GameObject ST;

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        if (hitInfo.GetComponent<BoxCollider2D>().tag == "Bullet")
        {
            health -= damage;

        if (health <= 0)
        {
            Die();
        }
         }
    }

    void Die ()
    {
        Destroy(gameObject);
        Instantiate(ST, point.position, point.rotation);
    }
}
