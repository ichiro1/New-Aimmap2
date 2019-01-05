using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public Animation anim;
	public bool ifShooting;
	// Use this for initialization
	void Start () {
		ifShooting = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			ifShooting = true;
			anim.Play ();
		}
		if (Input.GetMouseButtonUp (0) && ifShooting == true) {
			ifShooting = false;
			anim.Stop ();
		}
	}
}
