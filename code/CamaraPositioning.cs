using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPositioning : MonoBehaviour
{
    public GameObject player;
    public GameObject MainCamara;

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        
        if (hitInfo.GetComponent<BoxCollider2D>().tag == "Finish")
        {
           Vector3 CamaraPosition = player.transform.position;
           //MainCamara.transform.position = CamaraPosition;
        }
        
    }

    void FixedUpdate()
    {
        Vector3 CamaraPosition = player.transform.position;
        MainCamara.transform.position = CamaraPosition;
    }



    public float fixedPosition = -10;
 	void Update ()
	{
		Vector3 eulerAngles = transform.eulerAngles;
		MainCamara.transform.position = new Vector3( MainCamara.transform.position.x , MainCamara.transform.position.y , fixedPosition );
	}
}
