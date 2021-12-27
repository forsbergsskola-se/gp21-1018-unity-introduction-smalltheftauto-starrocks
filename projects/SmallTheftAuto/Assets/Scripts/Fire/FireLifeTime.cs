using System;
using UnityEngine;

public class FireLifeTime : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    private float _elapsedTime;

    private void Start()
    {
        _elapsedTime = 0;
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        // TODO: consider destroying the fire, to avoid that there's more and more disabled fires in the game (the longer I play)
        if(lifeTime < _elapsedTime) gameObject.SetActive(false);
    }
}
