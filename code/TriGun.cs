using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriGun : MonoBehaviour
{
    public Transform EFirePoint;
    public Transform EFirePoint1;
    public Transform EFirePoint2;
    public GameObject EnemyBulletType2Prefab;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 1)
        {
            timer = -1;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(EnemyBulletType2Prefab, EFirePoint.position, EFirePoint.rotation);
        Instantiate(EnemyBulletType2Prefab, EFirePoint1.position, EFirePoint1.rotation);
        Instantiate(EnemyBulletType2Prefab, EFirePoint2.position, EFirePoint2.rotation);
    }   
}
