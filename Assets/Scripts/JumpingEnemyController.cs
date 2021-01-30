using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(GroundDetector))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Jumper))]


public class JumpingEnemyController : MonoBehaviour
{
    private Rigidbody2D myRigidBody2D;
    private GroundDetector groundDetector;
    private Jumper jumper;
    private Animator animator;
    float lastTimeJumped;

    public float jumpForce = 6f;
    private bool hasJumped = false;



    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        groundDetector = GetComponent<GroundDetector>();
        animator = GetComponent<Animator>();
        jumper = GetComponent<Jumper>();
    }

    public void Jump()
    {

        lastTimeJumped = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if (Mathf.Floor(Time.time) % 3 == 0)
        {
            if (hasJumped == false)
            {
                myRigidBody2D.velocity += new Vector2(0f, jumpForce);
                hasJumped = true;
            }
            animator.SetTrigger("EnemyJump");


        }

        else
        {
            hasJumped = false;
        }

    }
}