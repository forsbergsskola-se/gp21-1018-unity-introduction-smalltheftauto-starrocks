using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;
    [SerializeField][Range(0f, 360f)]float rotateSpeed;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CarMove();
    }

    void CarMove()
    {
        _rigidbody.AddRelativeForce(0f,0f,moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
        //transform.Translate(0f, 0f,moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0f,rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f);
    }
}