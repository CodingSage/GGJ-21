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
    public GameObject shovel;

    void Start()
    {
        mover = GetComponent<Mover>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            mover.MoveWithVelocity(-Vector2.right);
            animator.SetBool("Moving", true);
            spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            mover.MoveWithVelocity(Vector2.right);
            animator.SetBool("Moving", true);
            spriteRenderer.flipX = false;
        }
        else
        {
            mover.StopMovement();
            animator.SetBool("Moving", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }
    }
}
