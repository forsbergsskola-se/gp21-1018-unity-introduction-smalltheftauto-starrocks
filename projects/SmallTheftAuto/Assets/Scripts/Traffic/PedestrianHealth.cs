using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// Note:
// Composition-wise I would say having a class called PedestrianHealth inheriting from TrafficCarHealth is a little confusing
// I suggest extracting the logic inside TrafficCarHealth that's shared by both TrafficCar and Pedestrian into a different base class
// and then have TrafficCar and Pedestrian inherit from it

public class PedestrianHealth : TrafficCarHealth
{
    private void LateUpdate()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            _playerStats.Money += damage;
        }
    }
}
