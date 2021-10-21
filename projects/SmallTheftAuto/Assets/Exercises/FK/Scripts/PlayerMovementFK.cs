using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovementFK : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField][Range(60f,250f)] float rotationSpeed;

    [SerializeField] [Range(0f, 1f)] [Tooltip("0 = 0% and 1 = 100% of moveSpeed")] private float precentOfMoveSpeed;
    private Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        
        transform.Translate(0f, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), 0f); //TODO /2 when going backwards
        transform.Translate( moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f, 0f);
        LookAt();
        //Move();
        // transform.Rotate(0f, 0f, -180f * Time.deltaTime * Input.GetAxis("Rotate"));
        // transform.Rotate(0f, 0f, -180f*Time.deltaTime*Input.GetAxis("Rotate2"));
	    
        // Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        // Vector3 dir = Input.mousePosition - pos;
        // float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.AngleAxis(angle -90f, Vector3.forward);
    }

    void Move()
    {
        
        if (Input.GetAxis("Horizontal") >= 0)
        {
            rigidbody.velocity = new Vector2(0.0f, moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            rigidbody.velocity = new Vector2(0.0f, moveSpeed * precentOfMoveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }
        
        //input from user
        //
    }

    void LookAt()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        transform.LookAt(dir);
    }
}
