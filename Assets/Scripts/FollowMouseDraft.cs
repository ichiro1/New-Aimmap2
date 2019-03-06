using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseDraft : MonoBehaviour {
    [SerializeField] private string mouseXInputName, mouseYInputName;
    [SerializeField] private float mouseSensitivity;

    [SerializeField] private Transform playerBody;
    public Camera cam;
    private float fov = 50;
    private float xAxisClamp;
    private bool zoomedIn = false;
    private bool button1LetGo;

	// Use this for initialization
	void Start () {
        LockCursor();
        xAxisClamp = 0;
        cam.GetComponent<Camera>();
	}
    private void LockCursor() {
        Cursor.lockState = CursorLockMode.Locked;
    }
	// Update is called once per frame
	void Update () {
        CameraRotation();
	}
    private void CameraRotation() {
        float mouseX = Input.GetAxisRaw(mouseXInputName) * mouseSensitivity *Time.deltaTime;
        float mouseY = Input.GetAxisRaw(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if(xAxisClamp > 90.0f) {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(-270.0f);
        }
        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;
           ClampXAxisRotationToValue(270.0f);
        }

        transform.Rotate(Vector3.right * mouseY);
        playerBody.Rotate(Vector3.down * mouseX);


        if(Input.GetMouseButtonDown(1)) {
            cam.fieldOfView = fov;
            zoomedIn = true;
        }
        if(Input.GetMouseButtonUp(1)) {
            cam.fieldOfView = fov + 10;
        }

        if (Input.GetMouseButtonDown(1) && zoomedIn == true && button1LetGo == false) {

            zoomedIn = false;
        } 
    }

    private void ClampXAxisRotationToValue(float value) {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
