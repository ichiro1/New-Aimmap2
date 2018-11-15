using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {

    /*
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
    private Vector3 jump; */


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {






        /*leftmovement = new Vector3(Input.GetAxis("Horizontal") * frontSpeed, player.velocity.y);
        rightmovement = new Vector3(Input.GetAxis("Horizontal") * frontSpeed, player.velocity.y);
        frontmovement = new Vector3(0.0f, player.velocity.y, leftSpeed);
        backmovement = new Vector3(0.0f, player.velocity.y, rightSpeed);

        frontleftmovement = new Vector3(Input.GetAxis("Horizontal") * frontSpeed, player.velocity.y, leftSpeed);
        frontrightmovement = new Vector3(Input.GetAxis("Horizontal") * frontSpeed, player.velocity.y, frontSpeed);
        backleftmovement = new Vector3(Input.GetAxis("Horizontal") * backSpeed, player.velocity.y, rightSpeed);
        backrightmovement = new Vector3(Input.GetAxis("Horizontal") * backSpeed, player.velocity.y, rightSpeed);

        jump = new Vector3(player.velocity.x, Input.GetAxis("Vertical") * leftSpeed, player.velocity.z);

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
        if(Input.GetKey("d") && Input.GetKey("w")) {
            player.velocity = frontrightmovement;
        }
        if(Input.GetKey("a") && Input.GetKey("s")) {
            player.velocity = backleftmovement;
        }
        if(Input.GetKey("d") && Input.GetKey("s")) {
            player.velocity = backrightmovement;
        }
        if(Input.GetKey("space")) {
            player.velocity = jump;
        } */
	}
}
