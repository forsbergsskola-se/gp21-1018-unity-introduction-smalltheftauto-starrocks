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

    // Update is called once per frame
    void LateUpdate()
    {
        if (playerTransform != null)
        {
            if (player.gameObject.activeInHierarchy) {
                miniMapCameraTransform.position = playerTransform.position + cameraFromPlayerOffset;
            }
            else {
                miniMapCameraTransform.position = vehicleTransform.position + cameraFromPlayerOffset;
            }
        }
        else
        {
            Debug.LogWarning("Payer.Transform value is Null");
        }
    }
}
