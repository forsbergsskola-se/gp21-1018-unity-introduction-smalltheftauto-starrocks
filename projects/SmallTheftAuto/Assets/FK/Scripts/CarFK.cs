using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFK : MonoBehaviour
{
    [SerializeField] GameObject player;
    public CarMovementFK _carMovementFk;
    private bool isInCar = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _carMovementFk.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        EnterCar();
    }

    void EnterCar()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.SetActive(false);
            _carMovementFk.enabled = true;
        }
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
