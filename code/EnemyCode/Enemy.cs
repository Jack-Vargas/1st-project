using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 60;
    public GameObject lockedDoor;
    //public bool EnemyHasDied = false;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Destroy(lockedDoor.gameObject);
        Destroy(gameObject);
    }

}