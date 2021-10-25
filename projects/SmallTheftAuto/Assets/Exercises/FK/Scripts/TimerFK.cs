using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerFK : MonoBehaviour
{
    private float timePassed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

     
     void Update()
     {
         timePassed += Time.deltaTime;
         GetComponent<Text>().text=timePassed.ToString("0.00s");
     }
}
