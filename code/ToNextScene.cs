using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextScene : MonoBehaviour
{
   void OnTriggerEnter2D (Collider2D hitInfo)
    {
        if (hitInfo.GetComponent<BoxCollider2D>().tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
