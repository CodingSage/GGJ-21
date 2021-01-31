using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]
public class AttackAbility : MonoBehaviour
{
    public GameObject weapon;
    private CapsuleCollider2D playerCollider;

    private void Start()
    {
        playerCollider = GetComponent<CapsuleCollider2D>();
    }

    private void Hit()
    {
        float width = playerCollider.size.x * transform.localScale.x;
        Vector2 hitPos = new Vector2(transform.position.x + width / 2 + 0.09f, transform.position.y); 
        GameObject tempHit = Instantiate(weapon, hitPos, transform.rotation, transform);
        Destroy(tempHit, 0.5f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Hit();
        }
    }
}
