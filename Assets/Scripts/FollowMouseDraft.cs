using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseDraft : MonoBehaviour {
    [SerializeField] private string mouseXInputName, mouseYInputName;
    [SerializeField] private float mouseSensitivity;
	// Use this for initialization
	void Start () {
        LockCursor();
	}
    private void LockCursor() {
        Cursor.lockState = CursorLockMode.Locked;
    }
	// Update is called once per frame
	void Update () {
        CameraRotation();
	}
    private void CameraRotation() {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity *Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        transform.Rotate(-transform.right * mouseY);
    }
}
