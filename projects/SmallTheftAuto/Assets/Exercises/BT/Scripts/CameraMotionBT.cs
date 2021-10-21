using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotionBT : MonoBehaviour {
    public CarMovementBT carMovement;
    public Transform Player;
    public Transform Vehicle;
    public Transform camTransform;
    public Vector3 Offset;
    public float SmoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    private void Start() {
        Offset = camTransform.position - Player.position;
    }
    private void LateUpdate() {
        if (carMovement.enabled) {
            CameraFollowVehicle();
        }
        else {
            CameraFollowPlayer();
        }
    }
    void CameraFollowPlayer() {
        Vector3 targetPosition = Player.position + Offset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
        transform.LookAt(Player);
    }
    void CameraFollowVehicle() {
        Vector3 targetPosition = Vehicle.position + Offset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
        transform.LookAt(Vehicle);
    }
}
