using UnityEngine;

public class VehicleBT : MonoBehaviour {
    public GameObject player;

    [SerializeField][Range(1f, 10f)] private float minVehicleDistance = 3f;
    void Update()
    { 
        bool playerIsInVehicle = !player.activeInHierarchy;
        bool vehicleInRange = minVehicleDistance > Vector3.Distance(transform.position, player.transform.position);
        
        if (Input.GetButtonDown("Interact-Vehicle")) {
            if (playerIsInVehicle) {
                player.GetComponent<DriveAbilityBT>().LeaveCar();
            }
            else if (!playerIsInVehicle && vehicleInRange) {
                player.GetComponent<DriveAbilityBT>().EnterCar();
            }
        }
    }
}
