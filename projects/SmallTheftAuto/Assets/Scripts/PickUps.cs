using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    private PlayerStats _playerStats;
    // TODO: Oh no, this looks like a huge violation of single responsibility.
    // This class has at leaast two responsibilities :D
    // Maybe, separate Pickup from MoneyPick and HealthPickup. Either through Inheritance or Composition.
    // One's responsibility is to have the functionality for being able to be picked up
    // The other two have effects.
    [SerializeField]private bool isMoney;
    [SerializeField]private bool isHealth;
    [SerializeField]private int amount;
    [SerializeField]private GameObject powerUpSprite;
    private BoxCollider boxCollider;

    public AudioSource healthSound;


    private void Awake()
    {
        _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (isMoney)
        {
            _playerStats.Money += amount;
        }

        if (isHealth)
        {
            if (_playerStats.Health == 100) return;
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
