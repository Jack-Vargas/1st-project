using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LokedDoor : MonoBehaviour
{

    public GameObject enemy;
    public bool EnemyHasDied;

    void Update()
    {

        if (EnemyHasDied == true)
        {
         Destroy(gameObject);
        }
    }
}
