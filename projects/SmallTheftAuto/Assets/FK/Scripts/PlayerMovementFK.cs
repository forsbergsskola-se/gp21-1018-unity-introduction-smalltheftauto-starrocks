using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovementFK : MonoBehaviour
{
    [SerializeField][Range(1f,30f)] float moveSpeed;
    [SerializeField][Range(60f,250f)] float rotationSpeed;
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0);
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
    }
}
