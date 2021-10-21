using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]float moveSpeed =10f;
    [SerializeField]float rotateSpeed = 180f;
    void Update()
    {
        transform.Translate(0f, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
        transform.Rotate(0f,0f,rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
