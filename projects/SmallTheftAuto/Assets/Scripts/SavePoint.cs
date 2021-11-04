using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    private PlayerStats _playerStats;
    private BoxCollider boxCollider;

    private void Awake()
    {
        _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player")) return;
        DisableBoxCollider();
        SaveSystem.SavePlayer(_playerStats);
        Debug.Log("Game Saved");
    }

    IEnumerator DisableBoxCollider()
    {
        boxCollider.enabled = false;
        yield return new WaitForSeconds(5);
        boxCollider.enabled = true;
    }
}
