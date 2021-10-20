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
        
        if (Input.GetKeyDown(KeyCode.E) && distance <= distanceToActivate) InteractPlayer(player.activeInHierarchy);
        if (!player.activeInHierarchy) player.transform.position = transform.position;
    }
    
    void InteractPlayer(bool isPlayerActive)
    { 
        GetComponent<PlayerMovementSP>().enabled = isPlayerActive;
        player.SetActive(!isPlayerActive);
    }
}
