using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour {
    Vector3 offset;
    [SerializeField]Transform player;
    Vector3 velocity = Vector3.zero;
    [SerializeField]float smoothTime = 0.3f;
    [SerializeField]Transform vehicle;

    
    void Start() {
        offset = transform.position - player.position;
    }

    void LateUpdate() {
	    CameraFollowing();
    }

    void CameraFollowing() {
	    if (player != null) {

		    if (player.gameObject.activeInHierarchy) {
			    Vector3 targetPosition = player.position + offset;
			    transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
		    }
		    else if (!player.gameObject.activeInHierarchy) {
			    if (vehicle != null) {
				    Vector3 targetPosition = vehicle.GetChild(0).position + offset;
				    transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
			    }
			    else {
				    Debug.LogWarning("Vehicle is Null");
			    }
		    }
	    }
	    else {
		    Debug.LogWarning("Player is Null");
	    }
    }
}
