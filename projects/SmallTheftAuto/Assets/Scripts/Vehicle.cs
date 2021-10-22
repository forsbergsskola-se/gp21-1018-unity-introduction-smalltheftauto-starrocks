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
        if (Input.GetButtonDown("Interact-Vehicle") && IsVehicleInRange())
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
        if (Vector3.Distance(transform.GetChild(0).position, player.transform.position) <= minDistance)
        {
            return true;
        }

        return false;
    }
    
    public bool PlayerIsInCar()
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
        player.transform.position = transform.GetChild(0).position;
        player.SetActive(true);
        carMovement.enabled = false;
    }
}
