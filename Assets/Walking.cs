using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {

	public float frontSpeed = 5f;
	public float backSpeed = 5f;

	public float moveHorizontal;
	public float moveVertical;
	public Rigidbody player;
	private Vector3 frontmovement;
	private Vector3 backmovement;
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


		frontmovement = new Vector3(Input.GetAxis("Horizontal") * frontSpeed, player.velocity.y, Input.GetAxis("Vertical") * frontSpeed);
		backmovement = new Vector3(Input.GetAxis("Horizontal") * frontSpeed, player.velocity.y, Input.GetAxis("Vertical") * backSpeed);

		if(Input.GetKey("w")) {
			player.velocity = frontmovement;
		}
		if(Input.GetKey("s")) {
			player.velocity = backmovement;
		}
		
	}
}
