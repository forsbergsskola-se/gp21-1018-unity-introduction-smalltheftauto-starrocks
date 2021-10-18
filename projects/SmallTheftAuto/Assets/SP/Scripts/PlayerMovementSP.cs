using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSP : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * Time.deltaTime * _speed;
        float rotation = Input.GetAxis("Horizontal") * Time.deltaTime * _rotationSpeed;

        transform.Translate(0f, translation, 0f);
        transform.Rotate(0f,0f,-rotation);
    }
}
