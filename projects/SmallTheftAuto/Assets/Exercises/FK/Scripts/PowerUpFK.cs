using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFK : MonoBehaviour
{
    private PlayerStats _playerStats;
    [SerializeField]private bool isMoney;
    [SerializeField]private bool isHealth;
    [SerializeField]private int amount;

    private void Awake()
    {
        _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Has Collided"); //TODO: REMOVE
        if (isMoney)
        {
            _playerStats.Money += amount;
        }

        if (isHealth)
        {
            _playerStats.Health += amount;
        }
        Destroy(this.gameObject);
    }
}
