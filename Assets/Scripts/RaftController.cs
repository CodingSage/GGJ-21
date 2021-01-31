using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class RaftController : MonoBehaviour
{
    public float speed;
    public float leftX;
    public float rightX;
    private bool goLeft = false;

    void Update()
    {
        float currentX = transform.position.x;
        if (currentX > rightX) goLeft = true;
        else if(currentX < leftX) goLeft = false;

        float diff = goLeft ? -1 * speed : speed;
        transform.position = 
            new Vector3(transform.position.x + diff * Time.deltaTime, transform.position.y, transform.position.z);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            collision.gameObject.transform.parent = transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            collision.gameObject.transform.parent = null;
        }
    }
}
