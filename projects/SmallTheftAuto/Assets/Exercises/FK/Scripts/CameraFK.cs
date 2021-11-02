using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFK : MonoBehaviour
{
    
    [SerializeField]Transform target;
    [SerializeField]float smoothTime = 0.3f;

    void LateUpdate()
    {
        FollowTarget(); 
    }

    public void FollowTarget()
    {
        Vector3 offset = new Vector3(0f, 20, 0);
        Vector3 result = Vector3.Lerp(transform.position + offset, target.position + offset, smoothTime);
        transform.position = result;
    }
}
