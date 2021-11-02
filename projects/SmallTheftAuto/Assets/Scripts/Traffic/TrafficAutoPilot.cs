using System;
using UnityEngine;

public class TrafficAutoPilot : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform initialWaypoint; 
    
    private Vector3 _destination;

    public Vector3 Destination
    {
        get
        {
            return new Vector3(_destination.x, transform.position.y, _destination.z);
        }
        set => _destination = value;
    }

    private void Awake()
    {
        Destination = initialWaypoint.position;
    }

    private void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Destination, step);
    }
}
