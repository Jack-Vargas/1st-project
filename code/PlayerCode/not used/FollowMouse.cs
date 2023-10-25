using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    void Update()
    {
        Vector2 gunPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 Direction = mousePosition - gunPosition;
        transform.right = -Direction;
        //GetComponent<Camera>().tag == "MainCamera".ScreenToWorldPoint(Input.mousePosition);

           //if (transform.Rotation.z < 180)
        //{
            //transform.Rotation.y + 180;
        //}
    }
}