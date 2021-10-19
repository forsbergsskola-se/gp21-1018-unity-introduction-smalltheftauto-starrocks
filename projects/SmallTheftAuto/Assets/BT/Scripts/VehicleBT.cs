using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleBT : MonoBehaviour {
    public GameObject player;
    public CarMovementBT carMovement;
    public VehicleBT vehicle;
    [SerializeField][Range(0.1f, 100f)] private float minVehicleDistance = 3f;
    void Update()
    { 
        bool playerIsInVehicle = !player.activeInHierarchy;
        bool vehicleInRange = minVehicleDistance > Vector3.Distance(transform.position, player.transform.position);
        bool vehicleInteracted = Input.GetKeyDown(KeyCode.E);
        
        if (vehicleInteracted) {
            if (playerIsInVehicle) {
                LeaveCar();
            }
            else if (!playerIsInVehicle && vehicleInRange) {
                EnterCar();
            }
        }
        void LeaveCar() {
            carMovement.enabled = false;
            player.SetActive(true);
            player.transform.position = vehicle.transform.position;
        }
        void EnterCar() {
            player.SetActive(false);
            carMovement.enabled = true;
        }
    }
}
