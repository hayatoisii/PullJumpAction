using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ltemScript : MonoBehaviour
{

    private Animator animator;
    private AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        // DestroySelf();
        animator.SetTrigger("Get");
        audioSource.Play();
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
