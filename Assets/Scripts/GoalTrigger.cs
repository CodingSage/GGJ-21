using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class GoalTrigger : MonoBehaviour
{
    private bool goalReached = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!goalReached && collision.gameObject.GetComponent<PlayerController>() != null)
        {
            goalReached = true;
        }
    }

    public bool GoalReached()
    {
        return goalReached;
    }
}
