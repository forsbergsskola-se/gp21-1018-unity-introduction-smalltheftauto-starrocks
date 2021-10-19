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
        /* Old stuffs
        
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
        }*/
        
        
            // We move 5 Units scaled by the Time (per second) scaled by the User Up-Input
            transform.Translate(0f, 5f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
            // We rotate -180 Degrees scaled by the Time (per second) scaled by the User-Right-Input
            transform.Rotate(0f, 0f, -180f*Time.deltaTime*Input.GetAxis("Horizontal"));
        

        
    }
}
