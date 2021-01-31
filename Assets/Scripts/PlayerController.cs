using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    private Mover mover;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    void Start()
    {
        mover = GetComponent<Mover>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            mover.AccelarateInDirection(-Vector2.right);
            animator.SetBool("Moving", true);
            spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            mover.AccelarateInDirection(Vector2.right);
            animator.SetBool("Moving", true);
            spriteRenderer.flipX = false;
        }

        if(Input.anyKey == false)
        {
            animator.SetBool("Moving", false);
        }
    }
}
