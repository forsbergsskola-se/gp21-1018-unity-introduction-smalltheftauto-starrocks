using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCompanionSpawnerFK : MonoBehaviour
{
    public GameObject dogPrefab;

    GameObject dogInstance;
    // Start is called before the first frame update
    void Start()
    {
        dogInstance = Instantiate(dogPrefab);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        Destroy(dogInstance);
    }
}
