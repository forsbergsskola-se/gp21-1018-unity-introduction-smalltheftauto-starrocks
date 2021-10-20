using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotionBT : MonoBehaviour {
    public CarMovementBT carMovement;

    void Update()
    {
        if (carMovement.enabled) {
            GetComponent<CameraFollowPlayerBT>().enabled = false;
            GetComponent<CameraFollowVehicleBT>().enabled = true;
        }
        else {
            GetComponent<CameraFollowVehicleBT>().enabled = false;
            GetComponent<CameraFollowPlayerBT>().enabled = true;
        }

    }
}
