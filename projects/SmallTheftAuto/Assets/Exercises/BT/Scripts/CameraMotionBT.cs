using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraMotionBT : MonoBehaviour {
    public CarMovementBT carMovement;
    public Transform player;
    public Transform vehicle;
    public Transform camTransform;
    public Vector3 offset;
    public float SmoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    private void Start() {
        offset = camTransform.position - player.position;
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
        Vector3 targetPosition = player.position + offset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
        transform.LookAt(player);
    }
    void CameraFollowVehicle() {
        Vector3 targetPosition = vehicle.position + offset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
        transform.LookAt(vehicle);
    }
}
