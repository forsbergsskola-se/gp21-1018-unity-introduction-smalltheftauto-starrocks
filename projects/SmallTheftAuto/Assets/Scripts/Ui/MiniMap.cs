using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Transform miniMapCameraTransform;
    public Transform playerTransform;
    public Transform vehicleTransform;
    private Vector3 cameraFromPlayerOffset;
    public GameObject player;
    public GameObject vehicle;

    // Start is called before the first frame update
    void Start()
    {
        cameraFromPlayerOffset = new Vector3(0, 14, 0);
    }

    //Your code could give a cleaner impression if you all used the same convention for
    //where to put brackets
    
    // Update is called once per frame
    void LateUpdate()
    {
        if (playerTransform != null)
        {
            if (player.gameObject.activeInHierarchy) {
                miniMapCameraTransform.position = playerTransform.position + cameraFromPlayerOffset;
            }
            else {
                if (vehicleTransform != null) {
                    miniMapCameraTransform.position = vehicleTransform.position + cameraFromPlayerOffset;
                }
                else {
                    Debug.LogWarning("Vehicle.Transform value is Null");
                }
            }
        }
        else
        {
            Debug.LogWarning("Payer.Transform value is Null");
        }
    }
}
