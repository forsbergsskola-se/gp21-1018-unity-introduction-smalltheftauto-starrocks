using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //only, if the Z-key is currently pressed...
        if (Input.GetKey(KeyCode.W))
        {
            //Translate the player on the y-axis (wich points up)
            transform.Translate(0,0.1f,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Translate the player on the y-axis (wich points up)
            transform.Translate(0,-0.1f,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Translate the player on the y-axis (wich points up)
            transform.Rotate(0,0.1f,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Translate the player on the y-axis (wich points up)
            transform.Rotate(0,-0.1f,0);
        }
        
    }
}
