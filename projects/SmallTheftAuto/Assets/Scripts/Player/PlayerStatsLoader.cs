using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsLoader : MonoBehaviour
{
    public PlayerStats playerStats;

    private void Awake()
    {
        SaveSystem.LoadPlayer();
    }
}
