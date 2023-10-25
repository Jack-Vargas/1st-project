using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    private Animator animator;
    private bool cam1 = true;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void CutTo()
    {
        if (cam1)
        {
            animator.Play("Cam2");
        }
        else 
        {
            animator.Play("Cam1");
        }
        cam1 = !cam1;
    }

    void Update()
    {
        
    }
}
