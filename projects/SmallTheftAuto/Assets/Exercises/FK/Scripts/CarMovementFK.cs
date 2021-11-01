using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementFK : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField][Range(60f,250f)] float rotationSpeed;
    Rigidbody rigidbody;


    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }
    void Move()
    {
        
        // float speed = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // Vector3 forwardSpeed = new Vector3(0f, 0f, speed);
        // Vector3 backwardSpeed = new Vector3(0f, 0f, speed * 0.5f);
        // if (speed < 0)
        // {
        //     rigidbody.AddForce(backwardSpeed );
        // }
        //
        // if (speed >= 0)
        // {
        //     rigidbody.AddForceAtPosition(forwardSpeed, this.transform.position);
        // }
        
        transform.Translate(0f,0f,Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        transform.Rotate(0f, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0f);
    }
}
