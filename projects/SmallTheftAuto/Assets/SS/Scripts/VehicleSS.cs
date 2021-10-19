using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSS : MonoBehaviour
{
    public GameObject player;

    public CarMovementSS carMovementSS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(player.activeInHierarchy);
            if (player.activeInHierarchy)
            {
                player.SetActive(false);
                carMovementSS.enabled = true;
            }
            else if (!player.activeInHierarchy)
            {
                player.transform.position = transform.position;
                player.SetActive(true);
                carMovementSS.enabled = false;
            }
        }
    }
}
