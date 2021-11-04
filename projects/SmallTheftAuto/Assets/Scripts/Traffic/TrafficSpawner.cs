using UnityEngine;
using UnityEngine.Serialization;

public class TrafficSpawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private GameObject wayPoints;

    private Transform[] _wayPoints;

    private void Awake()
    {
        _wayPoints = wayPoints.GetComponentsInChildren<Transform>();

        SpawnObjects();
    }

    private void SpawnObjects()
    {
        for (int i = 0; i < _wayPoints.Length; i++)
        {
            if (i % 2 == 0)
            {
                GameObject temp = Instantiate(objectToSpawn, _wayPoints[i].position, objectToSpawn.transform.rotation);
                temp.GetComponent<TrafficAutoPilot>().Destination = temp.transform.position;    
            }
        }
    }
}
