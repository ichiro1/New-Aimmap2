using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {

    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float movementSpeed;

    private CharacterController characterController;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        PlayerMovement();

    }

    private void PlayerMovement() {
        float horizInput = Input.GetAxis(verticalInputName) * movementSpeed * Time.deltaTime;
        float vertInput = Input.GetAxis(horizontalInputName) * movementSpeed * Time.deltaTime;

        Vector3 forwardmovement = transform.forward * horizInput;
        Vector3 rightMovement = transform.right * vertInput;

        characterController.SimpleMove(forwardmovement);
        characterController.SimpleMove(rightMovement);
    }

}