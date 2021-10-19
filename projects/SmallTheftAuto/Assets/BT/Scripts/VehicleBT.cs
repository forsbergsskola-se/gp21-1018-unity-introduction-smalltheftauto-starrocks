using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleBT : MonoBehaviour {
    GameObject player;
    CarMovementBT carMovement;
    VehicleBT vehicle;
    void Update()
    { 
        bool PlayerIsInCar = player.activeInHierarchy;
        bool CarIsInRange = (Vector3.Distance(transform.position, player.transform.position)) < 10;

        if (Input.GetKeyDown(KeyCode.E)) {
            if (PlayerIsInCar) {
                LeaveCar();
            }
            else if (!PlayerIsInCar && CarIsInRange) {
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
