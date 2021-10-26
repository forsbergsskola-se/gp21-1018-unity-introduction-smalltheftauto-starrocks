using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    private PlayerStats _playerStats;

    private void Awake()
    {
        _playerStats = GetComponentInParent<PlayerStatsLoader>().playerStats;
    }

    private void LateUpdate()
    {
        float health  = _playerStats.Health;
        Vector3 scaleHealthBar = new Vector3(health /50, 0.2f, 1);
        transform.localScale = scaleHealthBar;
    }
}
