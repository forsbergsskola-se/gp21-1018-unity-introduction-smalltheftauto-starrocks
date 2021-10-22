using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScale : MonoBehaviour
{
    private PlayerStats _playerStats;
    [SerializeField] private Vector3 scaleOffset;

    private void Awake()
    {
        _playerStats = GetComponentInParent<PlayerStatsLoader>().playerStats;
    }

    private void Update()
    {
        transform.localScale = CalcScale();
    }

    private Vector3 CalcScale()
    {
        float scaleX = _playerStats.Health * scaleOffset.x;
        float scaleY = scaleOffset.y;
        float scaleZ = scaleOffset.z;

        return new Vector3(scaleX, scaleY, scaleZ);
    }
}
