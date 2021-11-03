using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFK : MonoBehaviour
{
    private PlayerStats _playerStats;
    [SerializeField]private bool isMoney;
    [SerializeField]private bool isHealth;
    //TODO: Add amount with serializedflield

    private void Awake()
    {
        _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Has Collided");
        if (isMoney)
        {
            _playerStats.Money += 50;
        }

        if (isHealth)
        {
            _playerStats.Health += 50;
        }
        //If health pickup give player health
        Destroy(this.gameObject);
    }
}
