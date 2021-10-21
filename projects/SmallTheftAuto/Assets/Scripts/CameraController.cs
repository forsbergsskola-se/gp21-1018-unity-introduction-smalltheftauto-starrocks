using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    Vector3 offset;
    [SerializeField]Transform player;
    Vector3 velocity = Vector3.zero;
    [SerializeField]float smoothTime = 0.3f;
    void Start() {
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
	    CameraFollowsPlayer(); //This needs to change when VEH is added
	}

	void CameraFollowsPlayer() {
	    Vector3 targetPosition = player.position + offset;
	    transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
	}
}
