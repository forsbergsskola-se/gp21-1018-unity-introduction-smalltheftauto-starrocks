using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DogCompanionSpawnerBT : MonoBehaviour {
    [FormerlySerializedAs("DogPrefab")]
    public GameObject dogPrefab;
    private GameObject dogInstance;
    
    // Start is called before the first frame update
    void OnEnable() {
        dogInstance = Instantiate(dogPrefab);
    }
    private void OnDisable() {
        Destroy(dogInstance);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
