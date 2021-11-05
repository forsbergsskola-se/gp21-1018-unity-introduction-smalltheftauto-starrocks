using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField][Range(1f, 20f)]float moveSpeed = 10f;
    [SerializeField][Range(0f, 360f)]float rotateSpeed;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        PlayerMove();
        AnimatePlayer();
    }

    void PlayerMove()
    {
        //transform.Translate(0f, 0f,moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0f,rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f);
    }

    void AnimatePlayer()
    {
        _animator.SetFloat("walkSpeed" ,Input.GetAxis("Vertical"));
        Debug.Log(_animator.GetFloat("walkSpeed"));
    }
}
