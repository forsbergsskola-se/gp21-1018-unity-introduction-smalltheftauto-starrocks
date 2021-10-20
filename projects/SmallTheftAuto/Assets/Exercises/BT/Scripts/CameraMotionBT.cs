using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotionBT : MonoBehaviour {
    private Quaternion myRotation;
    public CarMovementBT carMovement;
    public CameraFollowVehicleBT cameraFollowVehicleBT;
    public CameraFollowPlayerBT cameraFollowPlayerBT;
    // Start is called before the first frame update
    void Start()
    {
        myRotation = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (carMovement.enabled) {
            cameraFollowPlayerBT.enabled = false;
            cameraFollowVehicleBT.enabled = true;
        }
        else {
            cameraFollowVehicleBT.enabled = false;
            cameraFollowPlayerBT.enabled = true;
        }
        this.transform.rotation = myRotation;

    }
}
