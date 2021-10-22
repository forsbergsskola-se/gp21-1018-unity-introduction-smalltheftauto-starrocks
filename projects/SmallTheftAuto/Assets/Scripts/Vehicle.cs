using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject player;
    public CarMovement carMovement;
    public float minDistance;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && IsVehicleInRange())
        {
            if (PlayerIsInCar())
            {
                LeaveCar();
            }
            else
            {
                EnterCar();
            }
        } 
    }

    private bool IsVehicleInRange()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= minDistance)
        {
            return true;
        }

        return false;
    }
    
    private bool PlayerIsInCar()
    {
        return !player.activeInHierarchy;
    }

    private void EnterCar()
    {
        player.SetActive(false);
        carMovement.enabled = true;
    }

    private void LeaveCar()
    {
        player.transform.position = this.transform.position;
        player.SetActive(true);
        carMovement.enabled = false;
    }
}
