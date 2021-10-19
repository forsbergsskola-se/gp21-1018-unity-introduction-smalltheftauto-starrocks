using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCompanionSpawnerSP : MonoBehaviour
{
    public GameObject dogPrefab;
    
    private GameObject dogInstance;
    
    private void OnEnable()
    {
        dogInstance = Instantiate(dogPrefab);
    }

    private void OnDisable()
    {
        Destroy(dogInstance);
    }
}
