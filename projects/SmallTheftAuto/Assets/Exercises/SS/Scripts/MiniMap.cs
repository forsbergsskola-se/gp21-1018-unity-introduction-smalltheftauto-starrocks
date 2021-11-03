using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Transform miniMapCameraTransform;
    public Transform playerTransform;
    private Vector3 cameraFromPlayerOffset;

    // Start is called before the first frame update
    void Start()
    {
        cameraFromPlayerOffset = new Vector3(0, 14, 0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        miniMapCameraTransform.position = playerTransform.position + cameraFromPlayerOffset;
    }
}
