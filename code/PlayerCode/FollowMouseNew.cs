using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseNew : MonoBehaviour
{
    public GameObject Gun;
   void Update()
    {
        Vector3 gunPosition = transform.position;
        Vector3 mousePosition = new Vector3 (Input.mousePosition.x - 770, Input.mousePosition.y - 390);
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 Direction = worldPos - transform.position;
        transform.right = -Direction;

    }

    //void update()
        //{
            //Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Vector3 mouseForwardPoint = mouseWorldPoint + (Camera.main.transform.forward * 10.0f); // Replace 10.0f with whatever value
            //Vector3 direction = mouseForwardPoint - transform.position;
            //transform.right = -direction;
        //}
}
