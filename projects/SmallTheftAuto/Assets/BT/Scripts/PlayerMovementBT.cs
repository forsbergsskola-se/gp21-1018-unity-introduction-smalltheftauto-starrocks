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
        transform.Translate(0f, 5f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        transform.Translate(5f*Time.deltaTime*Input.GetAxis("Horizontal"), 0f, 0f);
        transform.Rotate( 0f, 0f, -180f*Time.deltaTime*Input.GetAxis("Rotate"));
        // transform.Rotate(0f, 0f, -180f*Time.deltaTime*Input.GetAxis("Rotate2"));
        
        RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
		if(Physics.Raycast(ray,out hit,100))
		{
			transform.LookAt(new Vector3(hit.point.x,transform.position.y,hit.point.z));
		}
    }
}
