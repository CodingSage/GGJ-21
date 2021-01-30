using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollingEnemyController : MonoBehaviour
{
    public float speed = 1f;
    public bool MoveRight;

    public void Start()
    {
        StartCoroutine(Patrol());
    }

    void Update()
    {
        if(MoveRight == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }

    public IEnumerator Patrol()
    {
        while(true) 
        {
            MoveRight = true;
            yield return new WaitForSeconds(1f);
            MoveRight = false;
            yield return new WaitForSeconds(1f);
        }
    }
}
