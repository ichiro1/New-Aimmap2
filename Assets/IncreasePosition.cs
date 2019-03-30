using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasePosition : MonoBehaviour {
	public Transform wallTransform;
	private float wallTransformX;
	private float wallTransformY;
	private float wallTransformZ;
	private float uPressed;
	// Use this for initialization
	void Start () {
		wallTransform.GetComponent<Transform>();
		wallTransformX = wallTransform.position.x;
		wallTransformY = wallTransform.position.y;
		wallTransformZ = wallTransform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("u")) {
			wallTransform.position = new Vector3(wallTransformX, wallTransformY, wallTransformZ += -20);
			uPressed += 1;
		}
		if(uPressed == 20) {
			wallTransformZ = -96f;
			uPressed = 0;
		}
	}
}
