using System;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float verticalThreshold;
    public float smoothSpeed = 5f;
    
    void FixedUpdate()
    {
        Vector3 newPosition = transform.position;
        
        if (Mathf.Abs(player.position.y - transform.position.y) > verticalThreshold)
        {
            newPosition.y = player.position.y + offset.y;
        }
        
        newPosition.x = player.position.x + offset.x;
        newPosition.z = -10;

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * smoothSpeed);
    }
}
