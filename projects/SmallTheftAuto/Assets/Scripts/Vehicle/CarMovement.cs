using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField][Range(1f, 200f)]float moveSpeed = 10f;
    [SerializeField][Range(0f, 360f)]float rotateSpeed;
    void Update()
    {
        CarMove();
    }

    void CarMove()
    {
        transform.Translate(0f, 0f,moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0f,rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f);
    }
}