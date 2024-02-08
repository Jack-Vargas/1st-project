using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OhDip : MonoBehaviour
{
    public Behaviour trigun1;
    public Behaviour trigun2;
    public Behaviour ohdip;
    public GameObject lockedDoor;
    public Transform point;
    public Animator animator;

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        
        if (hitInfo.GetComponent<BoxCollider2D>().tag == "Player")
        {
            FindObjectOfType<Cut>().CutTo();
            trigun1.enabled = true;
            trigun2.enabled = true;
            Instantiate(lockedDoor, point.position, point.rotation);
            Destroy(gameObject);
            animator.SetBool("OhNo", true);
        }
        
    }
}
