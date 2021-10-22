using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class HealthBarScale : MonoBehaviour
{
    [SerializeField] private Vector3 scaleOffset;
    [SerializeField] [Range(0, 1)] private float yellowBar;
    [SerializeField] [Range(0, 1)] private float redBar;
    
    private PlayerStats _playerStats;
    private Image _image;
    
    private void Awake()
    {
        _playerStats = GetComponentInParent<PlayerStatsLoader>().playerStats;
        _image = GetComponent<Image>();

    }

    private void Update()
    {
        transform.localScale = CalcScale();
        Tint();
    }

    private Vector3 CalcScale()
    {
        float scaleX = _playerStats.Health * scaleOffset.x;
        float scaleY = scaleOffset.y;
        float scaleZ = scaleOffset.z;

        return new Vector3(scaleX, scaleY, scaleZ);
    }

    private void Tint()
    {
        if (_playerStats.Health < redBar) _image.color = Color.red;
        else if (_playerStats.Health < yellowBar) _image.color = Color.yellow;
        else _image.color = Color.green;
    }
}
