using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VehicleFK : MonoBehaviour
{
    public GameObject player;
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            if (!PlayerIsInCar()) {
                if(IsPlayerCloseToCar()) 
                    EnterCar();
            } else {
                ExitCar();
            }
        }
    }

    private bool IsPlayerCloseToCar()
    {
        return Vector3.Distance(this.player.transform.position, this.transform.position) < 5;
    }

    private void ExitCar()
    {
        this.player.transform.position = this.transform.position;
        this.player.SetActive(true);
        GetComponent<CarMovementFK>().enabled = false;
    }

    bool PlayerIsInCar()
    {
        return !this.player.activeInHierarchy;
    }

    void EnterCar()
    {
        this.player.SetActive(false);
        GetComponent<CarMovementFK>().enabled = true;
    }
}
