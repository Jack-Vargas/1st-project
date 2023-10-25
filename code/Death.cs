using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
	bool GameOver = false;
	public float RestartDelay = 1f;




    public void Dying ()
    {
        if (GameOver == false)
	   {
		    GameOver = true;
			Invoke("Restart", RestartDelay);
	   }
    }
	 void Restart ()	
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
}
