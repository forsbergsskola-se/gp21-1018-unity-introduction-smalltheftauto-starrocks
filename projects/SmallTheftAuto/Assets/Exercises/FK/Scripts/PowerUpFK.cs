using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFK : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Has Collided");
        //If money pickup give player money
        //If health pickup give player health
        Destroy(this.gameObject);
    }
}
