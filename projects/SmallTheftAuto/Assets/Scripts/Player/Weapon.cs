using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem;
    private float counter;

    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            particleSystem.Play();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            particleSystem.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        throw new NotImplementedException();
    }
}
