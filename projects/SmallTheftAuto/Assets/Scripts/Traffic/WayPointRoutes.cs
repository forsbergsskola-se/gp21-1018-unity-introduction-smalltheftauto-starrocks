using UnityEngine;

public class WayPointRoutes : MonoBehaviour
{
    [SerializeField] private Transform[] routes;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent(typeof(TrafficAutoPilot)) != null)
        {
            other.gameObject.GetComponent<TrafficAutoPilot>().Destination = routes[Random.Range(0, routes.Length)].position;
        }
    }
    
}
