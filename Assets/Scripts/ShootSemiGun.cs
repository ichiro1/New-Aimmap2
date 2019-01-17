using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSemiGun : MonoBehaviour {
    public Animation anim;
    public AudioSource aud;
    private int semigunShootFrame = 9;
    private bool isEquipped = false;
    private bool didGameStart;
	// Use this for initialization
	void Start () {
        anim.GetComponent<Animation>();
        aud.GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("1")) {
            if (isEquipped == false) {
                aud.mute = !aud.mute;
            }
            isEquipped = true;
        }
        else if (Input.GetKeyDown("2")) {
            if(isEquipped == true) {
                aud.mute = !aud.mute;
            }
            isEquipped = false;
        }

        semigunShootFrame = semigunShootFrame += 1;

        if(Input.GetMouseButtonDown(0) && semigunShootFrame >= 10) {
            anim.Play();
            semigunShootFrame = 1;
            aud.Play();
        }
        if (Input.GetMouseButtonUp(0))
        {
            anim.Stop();
        }
    }
}
