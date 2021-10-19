using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarActivateSP : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private int distanceToActivate;
    
    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);


        if (Input.GetKeyDown(KeyCode.E) && distance <= distanceToActivate) InteractPlayer(player.active);
        
        if (!player.active) player.transform.position = transform.position;
    }

    private void InteractPlayer(bool isPlayerActive)
    {
        _playerMovement.enabled = isPlayerActive;
        player.SetActive(!isPlayerActive);

        if (Input.GetKey(KeyCode.E) && distance <= distanceToActivate)
        {
            player.gameObject.SetActive(false);
            this.gameObject.GetComponent<PlayerMovementSP>().enabled = true;
        }

        if (Input.GetKey(KeyCode.E) && !player.gameObject.active)
        {
            player.gameObject.SetActive(true);
            this.gameObject.GetComponent<PlayerMovementSP>().enabled = false;
        }

    }
}
