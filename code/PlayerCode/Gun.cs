using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //to see how to make fire1 watch 2d shooting in unity by brackeys
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        Instantiate(BulletPrefab, firePoint.position, firePoint.rotation); //the bit that spawns the bullet
    }
}
