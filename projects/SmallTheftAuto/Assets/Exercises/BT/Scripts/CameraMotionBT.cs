
using UnityEngine;

public class CameraMotionBT : MonoBehaviour {
    public Transform player;
    public Transform vehicle;
    public Vector3 offset;
    public float SmoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    private void Start() {
        offset = transform.position - player.position;
    }
    private void LateUpdate() {
        if (FindObjectOfType<CarMovementBT>().enabled) {
            CameraFollowVehicle();
        }
        else {
            CameraFollowPlayer();
        }
    }
    void CameraFollowPlayer() {
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, 0.02f);
    }
    void CameraFollowVehicle() {
        Vector3 targetPosition = vehicle.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
    }
}
