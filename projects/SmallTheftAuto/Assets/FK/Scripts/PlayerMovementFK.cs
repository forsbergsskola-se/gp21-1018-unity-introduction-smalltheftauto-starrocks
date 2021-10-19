using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovementFK : MonoBehaviour
{
    [SerializeField][Range(1f,30f)] float moveSpeed;
    [SerializeField][Range(60f,250f)] float rotationSpeed;

    void Update() {
        transform.Translate(0f, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), 0f); //TODO /2 when going backwards
        transform.Translate( moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f, 0f);
        // transform.Rotate(0f, 0f, -180f * Time.deltaTime * Input.GetAxis("Rotate"));
        // transform.Rotate(0f, 0f, -180f*Time.deltaTime*Input.GetAxis("Rotate2"));
	    
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle -90f, Vector3.forward);
    }
}
