using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public int health = 60;
    public GameObject ST;
    public HealthBar healthBar;


    void start()
    {
        healthBar.SetMaxHealth(90);
    }

    public void TakeDamage (int damage)
    {
        health -= damage;

        healthBar.SetHealth(health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Destroy(gameObject);
        Instantiate(ST, transform.position, transform.rotation);
    }
}
