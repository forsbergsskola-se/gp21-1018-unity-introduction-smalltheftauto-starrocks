using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class SpawnFire : MonoBehaviour
{
    [SerializeField] private GameObject fire;
    
    private CarHealth _carHealth;
    private TrafficCarHealth _trafficCarHealth;

    private void Awake()
    {
        _carHealth = GetComponent<CarHealth>();
        _trafficCarHealth = GetComponent<TrafficCarHealth>();
    }

    private void Update()
    {
        if(_carHealth != null &&_carHealth.Health <= 0) SummonFire();
        if(_trafficCarHealth != null &&_trafficCarHealth.Health <= 0) SummonFire();
    }

    private void SummonFire()
    {
        Instantiate(fire, transform.position, transform.rotation);
    }
}
