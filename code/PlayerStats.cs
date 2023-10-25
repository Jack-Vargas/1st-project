using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int PlayerHealth = 8;

    public Behaviour MovementCode;
    public GameObject PlayerGun;
    public Text healthCount;

    public void TakeDamage (int damage)
    {
        PlayerHealth -= damage;

        if (PlayerHealth <= 0)
        {
            Destroy(PlayerGun);
            MovementCode.enabled = false;
            FindObjectOfType<Death>().Dying();

        }
    }


    public void HealToFull()
    {
        PlayerHealth = 8;
    }


    public float fixedRotation = 5;
 	void Update ()
	{
		Vector3 eulerAngles = transform.eulerAngles;
		transform.eulerAngles = new Vector3( eulerAngles.x , fixedRotation , fixedRotation );
        healthCount.text = PlayerHealth.ToString();
	}
}
