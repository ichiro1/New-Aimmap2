using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {
	public Animator anim;
	public bool ifShooting;
	public AudioSource aud;
	public AudioSource aud2;
    public AudioSource aud3;
	private float frameShotCount = 9;
    private bool isEquipped = false;

	public float damage = 100f;
	public float range = 100f;
	public Camera Cam;
	public float AmountOfBullets = 30;
	public Text AmmoCountText;
	public bool ifAmmoRemaining;
	public bool rPressed = false;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		ifShooting = false;
		aud.GetComponent<AudioSource> ();
		aud2.GetComponent<AudioSource> ();
        aud3.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("2")) {
            if(isEquipped == false) {
                aud.mute = !aud.mute;
				anim.SetBool("Equip", false);
            }
            isEquipped = true;
        }
        else if(Input.GetKeyDown("1")) {
            if(isEquipped == true) {
                aud.mute = !aud.mute;
                isEquipped = false;
				
                if (AmountOfBullets <= 0) {
            ifAmmoRemaining = false;
                aud2.Play();
            }
            if(AmountOfBullets > 0) {
                ifAmmoRemaining = true;
            }
            }
        }
		if(isEquipped == false) {
			AmmoCountText.text = AmountOfBullets + "/30";
			anim.SetBool("Equip", true);
            if (Input.GetKeyDown("r"))
            {
                AmountOfBullets = 30;
                aud3.Play();
				rPressed = true;
				anim.SetBool("Reloading", true);
				
				//AkInspectChallenge was supposed to be for an inspect, but it looked better as a reload. 
            }
			if(Input.GetKeyUp("r") && rPressed == true) {
				rPressed = false;
				anim.SetBool("Reloading", false);
			}
				
            if (Input.GetKeyDown("v")) {
                AmountOfBullets = 10000;
            }
        }
        //frameShotCount = frameShotCount * Time.deltaTime;

		if (Input.GetMouseButton (0)) {
			ifShooting = true;
			// anim.Play ();
			frameShotCount += 1;

			anim.SetBool("Shooting", true);
		}
		if (Input.GetMouseButtonUp (0) && ifShooting == true) {
			ifShooting = false;
			// anim.Stop ();
			anim.SetBool("Shooting", false);
			aud.Stop ();
            frameShotCount = 14;
		}
		if (frameShotCount == 15) {
			aud.Play ();
			if(isEquipped == false) {
				AmountOfBullets -=1;
				anim.SetBool("Shooting", true);
			}
			if(isEquipped == true) {
				AmountOfBullets = AmountOfBullets;
			}
			
		}
		if(frameShotCount >= 20) {
			frameShotCount = 1;
		}

        if(Input.GetButton("Fire1") && frameShotCount == 15 && isEquipped == false && AmountOfBullets > 0) {
			ShootGun();
		}
		

	}
	void ShootGun() {
		RaycastHit hit;
		if(Physics.Raycast(Cam.transform.position, Cam.transform.forward,out hit)) {

			RaycastTargetHit target = hit.transform.GetComponent<RaycastTargetHit>();
			if(target != null && isEquipped == false) {
				target.TakeDamage(damage);


			}
		}
	}
}
