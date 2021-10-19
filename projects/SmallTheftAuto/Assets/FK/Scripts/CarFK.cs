using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CarFK : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] private float minDistanceToEnterCar = 5f;
    CarMovementFK carMovementFk;
    
    void Start()
    {
        carMovementFk = GetComponent<CarMovementFK>();
        carMovementFk.enabled = false;
    }
    
    void Update()
    {
        float distance = DistanceToNearestCar();
        if (Input.GetKeyDown(KeyCode.E)&&distance <= minDistanceToEnterCar) EnterExitCar(player.gameObject.active);
    }

    void EnterExitCar(bool isPlayerActive)
    { 
        carMovementFk.enabled = isPlayerActive;
        player.gameObject.SetActive(!isPlayerActive);
    }

    float DistanceToNearestCar()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        return distance;
    }
}
