using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EGun2Follow : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public float fixedRotation = 0;


    void Update()
    {
       Vector2 EnemyGunPosition =  transform.position;
       //Vector2 playerPosition = player.transform;
       //Vector2 Direction = playerPosition - EnemyGunPosition;
       Vector3 TrueTransform = transform.position - enemy.transform.position;
       Vector3 Roatation = player.transform.position - enemy.transform.position; 
       transform.right = Roatation;

       Vector3 eulerAngles = transform.eulerAngles;
	   transform.eulerAngles = new Vector3( fixedRotation , fixedRotation , eulerAngles.z );

       if (eulerAngles.z > 180)
       {
           //fixedRotation = 180;
       }
    }
}
