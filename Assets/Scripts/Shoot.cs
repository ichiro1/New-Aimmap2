using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public Animation anim;
	public bool ifShooting;
	public AudioSource aud;
	private float frameShotCount = 9;
	// Use this for initialization
	void Start () {
		ifShooting = false;
		aud.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			ifShooting = true;
			anim.Play ();
			frameShotCount += 1;
		}
		if (Input.GetMouseButtonUp (0) && ifShooting == true) {
			ifShooting = false;
			anim.Stop ();
			aud.Stop ();
		}
		if (frameShotCount == 10) {
			aud.Play ();
		}
		if(frameShotCount == 15) {
			frameShotCount = 1;
		}
	}
}
