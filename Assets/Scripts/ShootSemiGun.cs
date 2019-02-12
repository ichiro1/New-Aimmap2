using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSemiGun : MonoBehaviour {
    public Animation anim;
    public AudioSource aud;
    public AudioSource aud2;
    private int semigunShootFrame = 9;
    private bool isEquipped = false;
    private bool didGameStart;
    
    private int soundAfterShot = 1;

    public float damage = 10f;
	public float range = 100f;
	public Camera Cam;
	// Use this for initialization
	void Start () {
        anim.GetComponent<Animation>();
        aud.GetComponent<AudioSource>();
        aud2.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("1")) {
            if (isEquipped == false) {
                aud.mute = !aud.mute;
                aud2.mute = !aud.mute;
            }
            isEquipped = true;
        }
        else if (Input.GetKeyDown("2")) {
            if(isEquipped == true) {
                aud.mute = !aud.mute;
                aud2.mute = !aud.mute;
            }
            isEquipped = false;
        }

        semigunShootFrame = semigunShootFrame += 1;

        if(Input.GetMouseButtonDown(0) && semigunShootFrame >= 10) {
            anim.Play();
            soundAfterShot +=1;
            aud.Play();
            ShellFall();
        }
        if (Input.GetMouseButtonUp(0))
        {
            anim.Stop();
        }

        if(Input.GetButtonDown("Fire1") && isEquipped == false) {
			ShootGun();
		}
    }

    void ShootGun() {
		RaycastHit hit;
		if(Physics.Raycast(Cam.transform.position, Cam.transform.forward,out hit)) {
			Debug.Log(hit.transform.name);

            RaycastTargetHit target = hit.transform.GetComponent<RaycastTargetHit>();
			if(target != null && isEquipped == false) {
				target.TakeDamage(damage);
			}
		}
	}
    void ShellFall() {
        soundAfterShot += 1;
        if(soundAfterShot == 5) {
            aud2.Play();
            soundAfterShot =1;
        }
    }


}
