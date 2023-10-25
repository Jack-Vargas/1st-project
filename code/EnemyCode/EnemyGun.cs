using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public Transform EnemyFirePoint;
    public GameObject EnemyBulletPrefab;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 1)
        {
            timer = 0;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(EnemyBulletPrefab, EnemyFirePoint.position, EnemyFirePoint.rotation);
    }
}
