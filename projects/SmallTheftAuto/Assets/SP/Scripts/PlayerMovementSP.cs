using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSP : MonoBehaviour
{
    void Update()
    {
      if(Input.GetKey(KeyCode.W)) transform.Translate(0f, 0.01f, 0); 
      if(Input.GetKey(KeyCode.S)) transform.Translate(0f, -0.01f, 0);
      if (Input.GetKey(KeyCode.A)) transform.Rotate(0f,0f, 0.1f);
      if (Input.GetKey(KeyCode.D)) transform.Rotate(0f,0f, -0.1f);
      
    }
}
