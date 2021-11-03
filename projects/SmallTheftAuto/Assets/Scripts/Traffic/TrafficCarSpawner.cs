using System;
using UnityEngine;
using UnityEngine.Serialization;

public class TrafficCarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private GameObject wayPoints;

    private Transform[] _wayPointsTransform;

    private void Awake()
    {
        _wayPointsTransform = wayPoints.GetComponentsInChildren<Transform>();

        SpawnCars();
    }

    private void SpawnCars()
    {
        for (int i = 0; i < _wayPointsTransform.Length; i++)
        {
            if (i % 2 == 0) Instantiate(car, _wayPointsTransform[i].position, transform.rotation);
        }
    }
}
