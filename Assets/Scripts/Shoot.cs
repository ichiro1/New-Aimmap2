using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Animation anim;
    public int shootTickCount = 59;
	public Transform guntrans;
	private float guntransmovetest = 2f;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
		guntrans = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetMouseButtonDown (0)) {
			anim.Play ();
			shootTickCount += 1;
		}
		if (Input.GetMouseButtonUp (0) && shootTickCount >= 25) {
			anim.Stop ();
		}*/
		if (true) {
			shootTickCount += 1;
		}
		if (shootTickCount >= 60) {
			anim.Play ();
			shootTickCount = 0;
			shootTickCount += 1;
		}
		/*if (shootTickCount <= 59) {
			anim.Stop ();
			shootTickCount += 1;
		}*/
	}
}
