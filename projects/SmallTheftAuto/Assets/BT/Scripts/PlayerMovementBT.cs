using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class PlayerMovementBT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
	    transform.Translate(0f, 5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
	    transform.Translate(5f * Time.deltaTime * Input.GetAxis("Horizontal"), 0f, 0f);
	    // transform.Rotate(0f, 0f, -180f * Time.deltaTime * Input.GetAxis("Rotate"));
	    // transform.Rotate(0f, 0f, -180f*Time.deltaTime*Input.GetAxis("Rotate2"));
	    
	    Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
	    Vector3 dir = Input.mousePosition - pos;
	    float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
	    transform.rotation = Quaternion.AngleAxis(angle -90f, Vector3.forward);
    }
}
