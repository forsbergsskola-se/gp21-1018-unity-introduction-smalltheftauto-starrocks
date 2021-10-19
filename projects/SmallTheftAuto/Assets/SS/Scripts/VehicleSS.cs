using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSS : MonoBehaviour
{
    public GameObject player;

    public CarMovementSS carMovementSS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
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

    private void LeaveCar()
    {
        player.transform.position = transform.position;
        player.SetActive(true);
        carMovementSS.enabled = false;
    }

    private void EnterCar()
    {
        
        
        player.SetActive(false);
        carMovementSS.enabled = true;
    }

    private bool PlayerIsInCar()
    {
        return !player.activeInHierarchy;
    }
}
