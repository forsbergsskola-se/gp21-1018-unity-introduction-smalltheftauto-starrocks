using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // TODO: Try avoiding the `new` keyword. Rather rename the field.
    [SerializeField]
    new ParticleSystem particleSystem;
    [SerializeField] private float reloadTime;
    
    private float _timeRemaing; // TODO: remaining (spelling error)

    public GameObject reloadWarning;
    
    public AudioSource fireSound;
    public AudioSource reloadSound;

    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop();

        ReloadWeapon();
    }

    private void Update()
    {
        // TODO: looks good! :)
        if (_timeRemaing > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space)) StartFiring();
            if (Input.GetKeyUp(KeyCode.Space)) StopFiring();
            
            if (fireSound.isPlaying) _timeRemaing -= Time.deltaTime;
        }
        else
        {
            StopFiring();
            reloadWarning.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R)) ReloadWeapon();
        }
    }
    
    /// <summary>
    /// Method for reloding weapon and disabling reloadWarning
    /// </summary>
    /// <returns></returns>

    private void ReloadWeapon()
    {
        _timeRemaing = reloadTime;
        reloadSound.Play();
        reloadWarning.SetActive(false);
    }

    private void StartFiring()
    {
        particleSystem.Play();
        fireSound.Play();
    }

    private void StopFiring()
    {
        particleSystem.Stop();
        fireSound.Stop();
    }
}
