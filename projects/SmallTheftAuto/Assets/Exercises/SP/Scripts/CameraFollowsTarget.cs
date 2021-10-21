using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsTarget : MonoBehaviour
{
    public Transform player;
    
    void Update()
    {
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, 0.03f);
    }
}
