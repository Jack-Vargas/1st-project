using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EGunType2 : MonoBehaviour
{
    public Transform EnemyFirePoint;
    public GameObject EnemyBulletType2Prefab;
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
        Instantiate(EnemyBulletType2Prefab, EnemyFirePoint.position, EnemyFirePoint.rotation);
    }
}
