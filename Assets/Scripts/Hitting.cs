using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitting : MonoBehaviour
{

    public GameObject shovel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Hit()
    {
        Debug.Log("Hit Me!");
        GameObject tempHit = Instantiate(shovel, transform.position, transform.rotation) as GameObject;
        Rigidbody2D tempRigidBodyHit = tempHit.GetComponent<Rigidbody2D>();
        Destroy(tempHit, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Hit();
        }
    }
}
