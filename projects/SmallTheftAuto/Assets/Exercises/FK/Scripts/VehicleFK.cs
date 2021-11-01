using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VehicleFK : MonoBehaviour
{
    public GameObject player;
    public GameObject body;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        body = GameObject.FindGameObjectWithTag("Body");
    }

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
        return Vector3.Distance(this.body.transform.position, this.transform.position) < 5;
    }

    private void ExitCar()
    {
        this.player.transform.position = this.transform.position;
        this.body.SetActive(true);
        GetComponent<CarMovementFK>().enabled = false;
    }

    bool PlayerIsInCar()
    {
        return !this.body.activeInHierarchy;
    }

    void EnterCar()
    {
        this.body.SetActive(false);
        GetComponent<CarMovementFK>().enabled = true;
    }
}
