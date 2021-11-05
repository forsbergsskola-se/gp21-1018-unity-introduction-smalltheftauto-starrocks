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
    public GameObject gameSavedUi;

    private void Awake()
    {
        _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player")) return;
        StartCoroutine(DisableBoxCollider());
        SaveSystem.SavePlayer(_playerStats);
        Debug.Log("Game Saved");
    }

    IEnumerator DisableBoxCollider()
    {
        gameSavedUi.SetActive(true);
        boxCollider.enabled = false;
        yield return new WaitForSeconds(5);
        boxCollider.enabled = true;
        gameSavedUi.SetActive(false);

    }
}
