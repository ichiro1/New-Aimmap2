using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{

    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float sprintSpeed;

    public CharacterController characterCont;

    public float characterHeight;
    Vector3 crouchMoveSpeed;

    private CharacterController characterController;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Use this for initialization
    void Start()
    {
        characterCont.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMovement();

    }

    private void PlayerMovement()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movementSpeed = movementSpeed * 2;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift)) {
            movementSpeed = movementSpeed / 2;
        }

        float horizInput = Input.GetAxis(verticalInputName) * movementSpeed * Time.deltaTime;
        float vertInput = Input.GetAxis(horizontalInputName) * movementSpeed * Time.deltaTime;

        float horizSprintInput = Input.GetAxis(verticalInputName) * sprintSpeed * Time.deltaTime;

        Vector3 forwardmovement = transform.forward * horizInput;
        Vector3 rightMovement = transform.right * vertInput;

        characterController.SimpleMove(forwardmovement);
        characterController.SimpleMove(rightMovement);

        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            characterCont.height += -10f;
            movementSpeed = -500;
            sprintSpeed = -500;
            crouchMoveSpeed = new Vector3(movementSpeed, 0, movementSpeed);
        }
        else if(Input.GetKeyUp(KeyCode.LeftControl)) {
            characterCont.height += 10f;
            movementSpeed = -1000;
            
        }
        if(characterCont.height == 15) {
            characterCont.height += 0;
        }
        if(characterCont.height == 30) {
            characterCont.height += 0;
        }

        /*if (Input.GetKeyDown("w") && Input.GetKeyDown(KeyCode.LeftShift)) {
            Vector3 sprintforward = transform.forward * horizSprintInput; 
            characterController.SimpleMove(sprintforward);

        }*/


    }

}