
using UnityEngine;

public class DriveAbilityBT : MonoBehaviour
{
    public GameObject player;
    public GameObject vehicle;
    public void LeaveCar() {
        player.GetComponent<CarMovementBT>().enabled = false;
        player.SetActive(true);
        player.transform.position = vehicle.transform.position;
    }
    public void EnterCar() {
        player.SetActive(false);
        player.GetComponent<CarMovementBT>().enabled = false;
    }
}
