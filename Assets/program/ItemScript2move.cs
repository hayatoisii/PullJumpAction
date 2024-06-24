using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript2move : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // DestroySelf();
        animator.SetTrigger("Get");
    }
}
