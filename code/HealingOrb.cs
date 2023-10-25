using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingOrb : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        
        if (hitInfo.GetComponent<BoxCollider2D>().tag == "Player")
        {
            PlayerStats Player = hitInfo.GetComponent<PlayerStats>();

            if (Player != null)
            {
                Player.HealToFull();
            }
            Destroy(gameObject);
        }
        
    }
}
