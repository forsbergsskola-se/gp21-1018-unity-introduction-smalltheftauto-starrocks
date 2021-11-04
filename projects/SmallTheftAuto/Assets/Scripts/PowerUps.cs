using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    private PlayerStats _playerStats;
    [SerializeField]private bool isMoney;
    [SerializeField]private bool isHealth;
    [SerializeField]private int amount;

    public AudioSource healthSound;

    private void Awake()
    {
        _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isMoney)
        {
            _playerStats.Money += amount;
        }

        if (isHealth)
        {
            _playerStats.Health += amount;
        }
        healthSound.Play();
        this.gameObject.SetActive(false);
    }
}
