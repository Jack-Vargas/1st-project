using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightEnemy : MonoBehaviour
{

    public GameObject player;
    private float distance;
    public Behaviour EGunType2;
    public int sight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        if(distance < sight)
        {
         EGunType2.enabled = true;
        }
    }
}
