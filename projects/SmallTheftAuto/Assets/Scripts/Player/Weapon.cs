using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem;
    [SerializeField] private float reloadTime;
    
    private float _timeRemaing;
    
    public AudioSource fire;

    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop();

        ReloadWeapon();
    }

    private void Update()
    {
        if (_timeRemaing > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space)) StartFiring();
            if (Input.GetKeyUp(KeyCode.Space)) StopFiring();
            
            if (fire.isPlaying) _timeRemaing -= Time.deltaTime;
        }
        else
        {
            StopFiring();
            if (Input.GetKeyDown(KeyCode.R)) ReloadWeapon();
        }

        Debug.Log(_timeRemaing);
    }

    private void ReloadWeapon()
    {
        _timeRemaing = reloadTime;
    }

    private void StartFiring()
    {
        particleSystem.Play();
        fire.Play();
    }

    private void StopFiring()
    {
        particleSystem.Stop();
        fire.Stop();
    }
}
