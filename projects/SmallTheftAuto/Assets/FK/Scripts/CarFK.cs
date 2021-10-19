using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CarFK : MonoBehaviour
{
    [SerializeField] GameObject player;
    public CarMovementFK carMovementFk;
    
    // Start is called before the first frame update
    void Start()
    {
        carMovementFk.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) EnterExitCar(player.gameObject.active);
    }

    void EnterExitCar(bool isPlayerActive)
    { 
        carMovementFk.enabled = isPlayerActive;
        player.gameObject.SetActive(!isPlayerActive);
    }
    
// When I enter a car:
// The player gameobject needs to be disabled (so he disappears)
// And on the car, the car movement script must be enabled (so we can drive)
// When I leave the car:
// The player gameobject must be moved to where the car is right now
// The player gameobject needs to be activated again (so he appears)
// And on the car, the car movement script  must be disabled (so it does not drive anymore)
// Car Physics <- But for now, maybe just use PlayerMovementMZ on the car, too (so the car moves like a human)
     
}
