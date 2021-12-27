using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField][Range(1f, 20f)]float moveSpeed = 10f;
    [SerializeField][Range(0f, 360f)]float rotateSpeed;
    
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        // TODO: It surprises me, that this is the Movement Code, because the controls feel very physically, as if moving through space.
        transform.Translate(0f, 0f,moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0f,rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f);
    }
}
