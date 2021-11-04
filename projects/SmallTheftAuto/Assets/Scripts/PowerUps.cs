using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    private PlayerStats _playerStats;
    [SerializeField]private bool isMoney;
    [SerializeField]private bool isHealth;
    [SerializeField]private int amount;
    [SerializeField]private GameObject powerUpSprite;
    private BoxCollider boxCollider;

    public AudioSource healthSound;


    private void Awake()
    {
        _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
        BoxCollider boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DullVehicle")) return;
        if (isMoney)
        {
            _playerStats.Money += amount;
        }

        if (isHealth)
        {
            _playerStats.Health += amount;
        }
        healthSound.Play();
        boxCollider.enabled = false;
        powerUpSprite.SetActive(false);
        destroy();
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Pick up destroyed");
        Destroy(this);
        Destroy(this.gameObject);
    }
}
