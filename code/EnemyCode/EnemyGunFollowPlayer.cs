using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunFollowPlayer : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
       Vector2 EnemyGunPosition =  transform.position;
       //Vector2 playerPosition = player.transform;
       //Vector2 Direction = playerPosition - EnemyGunPosition;
       Vector3 Roatation = player.transform.position - transform.position; 
       transform.right = Roatation;
    }
}
