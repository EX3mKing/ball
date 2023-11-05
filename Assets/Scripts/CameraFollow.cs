using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followTarget;

    [SerializeField]
    private Transform secondPivot;
    public float rotationSpeed = 1;
    public float verticalRotationLimit = 40;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        transform.position = followTarget.transform.position;
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * rotationSpeed);
        
        Camera.main.transform.Rotate(Vector3.right, -Input.GetAxis("Mouse Y") * rotationSpeed);
        
        float verticalRotation = Camera.main.transform.localRotation.eulerAngles.x;
        
        if (verticalRotation > verticalRotationLimit && verticalRotation < 180)
            verticalRotation = verticalRotationLimit;
        if (verticalRotation < 360 - verticalRotationLimit && verticalRotation > 180) 
            verticalRotation = 360 - verticalRotationLimit;
        
        //Debug.Log(verticalRotation);

        //float secondPivotRotation = 0;
        //if (verticalRotation > 180) secondPivotRotation = Mathf.Abs(verticalRotation - 360) / 2;
        //else secondPivotRotation = 360 - verticalRotation;


        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 
            Camera.main.transform.localRotation.eulerAngles.y, Camera.main.transform.localRotation.eulerAngles.z);
        
        //secondPivot.localRotation = Quaternion.Euler(secondPivotRotation, 0, 0);
    }
}
