using System;
using UnityEngine;

public class TrafficAutoPilot : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Vector3 _destination;

    public Vector3 Destination
    {
        get => new Vector3(_destination.x, transform.position.y, _destination.z);
        set => _destination = value;
    }

    private void Update()
    {
        float step = speed * Time.deltaTime;
        MoveTowardsTarget(step);
        LookAtTarget(step);
    }

    private void MoveTowardsTarget(float step)
    {
        transform.position = Vector3.MoveTowards(transform.position, Destination, step);
    }

    private void LookAtTarget(float step)
    {
        transform.LookAt(Destination, Vector3.up);
    }

    
}
