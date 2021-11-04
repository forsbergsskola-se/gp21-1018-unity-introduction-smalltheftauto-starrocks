using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[System.Serializable]
public class PlayerData 
{
    public int health;
    public int money;
    public int score;

    public PlayerData(PlayerStats playerStats)
    {
        health = playerStats.Health;
        money = playerStats.Money;
        score = playerStats.Score;
    }
}
