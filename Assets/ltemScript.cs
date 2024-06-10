using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ltemScript : MonoBehaviour
{

    private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        // DestroySelf();
        animator.SetTrigger("Get");
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
