using UnityEngine;

public class TrafficCarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private GameObject wayPoints;

    private Transform[] _wayPoints;

    private void Awake()
    {
        _wayPoints = wayPoints.GetComponentsInChildren<Transform>();

        SpawnCars();
    }

    private void SpawnCars()
    {
        for (int i = 0; i < _wayPoints.Length; i++)
        {
            GameObject temp = Instantiate(car, _wayPoints[i].position, transform.rotation);
            temp.GetComponent<TrafficAutoPilot>().Destination = temp.transform.position;
        }
    }
}
