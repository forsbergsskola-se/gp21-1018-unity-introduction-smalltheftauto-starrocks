using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CarFK : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField][Range(0.1f, 100f)] private float minDistanceToEnterCar = 5f;
    CarMovementFK carMovementFk;
    private bool playerIsInCar;
    
    void Start()
    {
        carMovementFk = GetComponent<CarMovementFK>();
        carMovementFk.enabled = false;
        
    }
    
    void Update()
    {
        if (playerIsInCar) {
            ExitCar();
        }else {
            EnterCar();
        }
    }
    void EnterCar()
    {
        if (Input.GetKeyDown(KeyCode.E) && DistanceToNearestCar() <= minDistanceToEnterCar)
        {
            carMovementFk.enabled = true;
            player.SetActive(false);
            player.transform.position = transform.position;
            playerIsInCar = true;
        }
    }

    void ExitCar()
    {
        if (Input.GetKeyDown(KeyCode.E) && DistanceToNearestCar() <= minDistanceToEnterCar)
        {
            carMovementFk.enabled = false;
            player.SetActive(true);
            player.transform.position = transform.position + new Vector3(-2,0,0);
            playerIsInCar = false;
        }
    }
    
    float DistanceToNearestCar()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        return distance;
    }
}
