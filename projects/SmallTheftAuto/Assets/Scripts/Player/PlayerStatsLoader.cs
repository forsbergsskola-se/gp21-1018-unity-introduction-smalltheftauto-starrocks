using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsLoader : MonoBehaviour
{
    public PlayerStats playerStats;

    private void Awake()
    {
        // TODO: h, I see, you are not doing anything with the result here. Too bad.
        SaveSystem.LoadPlayer();
    }
}
