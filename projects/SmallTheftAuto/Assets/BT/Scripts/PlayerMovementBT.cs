using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0) {
            transform.Translate(0f, 5f * Time.deltaTime, 0f);
        }
        if (Input.GetAxis("Vertical") < 0) {
            transform.Translate(0f, -5f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0f, 0f, -180f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(0f, 0f, 180f * Time.deltaTime);
        }
    }
}
