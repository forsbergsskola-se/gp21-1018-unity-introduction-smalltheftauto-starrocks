using UnityEngine;

// TODO: Nice, simple traffic system! :)
public class WayPointRoutes : MonoBehaviour
{
    [SerializeField] private Transform[] routes;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent(typeof(TrafficAutoPilot)) != null)
        {
            other.gameObject.GetComponent<TrafficAutoPilot>().Destination = SetNewRandomPossibleDestination();
        }
    }

    public Vector3 SetNewRandomPossibleDestination()
    {
        return routes[Random.Range(0, routes.Length)].position;
    }
}
