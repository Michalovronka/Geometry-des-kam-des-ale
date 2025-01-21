using UnityEngine;

public class GroundFollow : MonoBehaviour
{
    public Transform player;

    void FixedUpdate()
    {
        
        Vector3 newPosition = transform.position;
        newPosition.x = player.position.x;
        newPosition.y = transform.position.y;
        newPosition.z = transform.position.z;         
        
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * 5f);
    }
}
