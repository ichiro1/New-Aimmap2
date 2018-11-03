using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {

	public float frontSpeed = 5f;
	public float backSpeed = 5f;
    public float leftSpeed = 5f;
    public float rightSpeed = 5f;

	public float moveHorizontal;
	public float moveVertical;
	public Rigidbody player;
	private Vector3 frontmovement;
	private Vector3 backmovement;
    private Vector3 leftmovement;
    private Vector3 rightmovement;
    private Vector3 frontleftmovement;
    private Vector3 frontrightmovement;
    private Vector3 backleftmovement;
    private Vector3 backrightmovement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        //if(Input.GetKey("w")) {
        //	transform.Translate(Vector3.forward * frontSpeed * Time.deltaTime);
        //}
        //if(Input.GetKey("s")) {
        //	transform.Translate(Vector3.forward * backSpeed * Time.deltaTime);
        //}

        //moveVertical = Input.GetAxis("Vertical") * backSpeed;
        //moveHorizontal = Input.GetAxis("Horizontal") * backSpeed;
        //transform.Translate(moveHorizontal, moveVertical, 0);


        leftmovement = new Vector3(Input.GetAxis("Horizontal") * frontSpeed, player.velocity.y);
        rightmovement = new Vector3(Input.GetAxis("Horizontal") * frontSpeed, player.velocity.y);
        frontmovement = new Vector3(0.0f, player.velocity.x, leftSpeed);
        backmovement = new Vector3(0.0f, player.velocity.x, rightSpeed);

        frontleftmovement = new Vector3(Input.GetAxis("Horizontal") * frontSpeed, 0.0f , leftSpeed);

        if(Input.GetKey("a")) {
			player.velocity = leftmovement;
		}
		if(Input.GetKey("d")) {
			player.velocity = rightmovement;
		}

        if(Input.GetKey("w")) {
            player.velocity = frontmovement;
        }
        if(Input.GetKey("s")) {
            player.velocity = backmovement;
        }
        if(Input.GetKey("a") && Input.GetKey("w")) {
            player.velocity = frontleftmovement;
        }
	}
}
