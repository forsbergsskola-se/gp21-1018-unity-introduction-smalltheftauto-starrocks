using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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
