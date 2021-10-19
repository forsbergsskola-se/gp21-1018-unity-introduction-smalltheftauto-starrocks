using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarActivateSP : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private int distanceToActivate;
    private PlayerMovementSP _playerMovement;

    private void Awake()
    {
        _playerMovement = gameObject.GetComponent<PlayerMovementSP>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (Input.GetKeyDown(KeyCode.E) && distance <= distanceToActivate) EnterExitCar(player.active);
        
        if (!player.active) player.transform.position = transform.position;
    }

    private void EnterExitCar(bool isPlayerActive)
    {
        _playerMovement.enabled = isPlayerActive;
        player.SetActive(!isPlayerActive);
    }
}
