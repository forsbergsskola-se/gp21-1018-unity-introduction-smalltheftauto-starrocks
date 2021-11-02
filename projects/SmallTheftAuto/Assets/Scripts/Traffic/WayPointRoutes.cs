using Unity.VisualScripting;
using UnityEngine;

public class WayPointRoutes : MonoBehaviour
{
    [SerializeField] private Transform[] routes;

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.GetComponent(typeof(TrafficAutoPilot)) != null)
        {
            other.gameObject.GetComponent<TrafficAutoPilot>().Destination = routes[0].position;
        }
    }
    
}
