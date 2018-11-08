using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Transform lookAt;
    public Transform cameraTransform;


    public float mouseXSpeed = 2.0f;
    public float mouseYSpeed = 2.0f;
    public Camera camera;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    public float distance = 10.0f;
    public float Sensitivity;
    // Use this for initialization
    void Start()
    {
        //camera.GetComponent<Camera>();
        cameraTransform = transform;
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update() {



       

        Vector3 mousePos = Input.mousePosition;
        cameraTransform.LookAt(lookAt.position);

    }
    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        //cameraTransform = lookAt.position + rotation * dir;
    }

    }



