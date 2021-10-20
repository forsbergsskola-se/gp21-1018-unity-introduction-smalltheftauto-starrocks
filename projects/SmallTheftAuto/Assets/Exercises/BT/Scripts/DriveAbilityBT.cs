using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveAbilityBT : MonoBehaviour
{
    public GameObject player;
    public CarMovementBT carMovement;
    public VehicleBT vehicle;
    public void LeaveCar() {
        carMovement.enabled = false;
        player.SetActive(true);
        player.transform.position = vehicle.transform.position;
    }
    public void EnterCar() {
        player.SetActive(false);
        carMovement.enabled = true;
    }
}
