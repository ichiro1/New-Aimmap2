using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSwitch : MonoBehaviour {
	public Transform gunbody1;
	public Transform gunbody2;
	public Transform playerTransform;
	public int gunbodytransform = 1;
	
	// Use this for initialization
	void Start () {
		gunbody1.GetComponent<Transform>();
		gunbody2.GetComponent<Transform>();
		if(true) {
		Debug.Log (gunbody1.position);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKeyDown("2")) {
			gunbody1.position = new Vector3(10,10,10);
			gunbody2.position = new Vector3(1,14,1);
			gunbody1.GetComponent<MeshRenderer>().enabled =false;
		}
		if(Input.GetKeyDown("1")) {
			gunbody1.position = new Vector3(1,14,1);
			gunbody2.position = new Vector3(10,10,10);
			gunbody1.GetComponent<MeshRenderer>().enabled = true;
			
		}*/
	}
}
