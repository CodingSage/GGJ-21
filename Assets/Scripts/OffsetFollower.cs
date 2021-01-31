using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetFollower : MonoBehaviour
{
    public Transform target;
    private float yOffset;
    private float xOffset;

    private void Start()
    {
        yOffset = transform.position.y - target.position.y;
        xOffset = transform.position.x - target.position.x;
    }

    private void Update()
    {
        Vector3 targetPosition = target.position;
        Vector3 updatedPosition = new Vector3(targetPosition.x + xOffset, transform.position.y, transform.position.z);
        transform.position = updatedPosition;
    }
}
