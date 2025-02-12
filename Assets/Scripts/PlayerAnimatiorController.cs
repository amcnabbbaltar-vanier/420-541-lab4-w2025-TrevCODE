using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Animator animator;
    private CharacterMovement movement;

    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        movement = GetComponent<CharacterMovement>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("CharacterSpeed", rb.linearVelocity.magnitude);
        animator.SetBool("IsGrounded", movement.IsGrounded);

        if (Input.GetButtonUp("Fire1")) {
            animator.SetTrigger("doRoll");
        }
    }
}
