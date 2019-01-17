using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public Animation anim;
	public bool ifShooting;
	public AudioSource aud;
	private float frameShotCount = 9;
    private bool isEquipped = false;
	// Use this for initialization
	void Start () {
		ifShooting = false;
		aud.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("2")) {
            if(isEquipped == false) {
                aud.mute = !aud.mute;
            }
            isEquipped = true;
        }
        else if(Input.GetKeyDown("1")) {
            if(isEquipped == true) {
                aud.mute = !aud.mute;
            }

            isEquipped = false;
        }
            
        //frameShotCount = frameShotCount * Time.deltaTime;

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
		if (frameShotCount == 15) {
			aud.Play ();
		}
		if(frameShotCount == 20) {
			frameShotCount = 1;
		}
	}
}
