using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PlayerMovementFK : MonoBehaviour
{
    [SerializeField][Range(1f,30f)] float speed = 10.0f;
    [SerializeField][Range(60f,250f)] float rotationSpeed = 100.0f;
    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, translation, 0);
    }

    void Rotate()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotation);
    }
}
