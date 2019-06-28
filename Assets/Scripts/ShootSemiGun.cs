using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootSemiGun : MonoBehaviour {
    public Animator anim;
    public AudioSource aud;
    public AudioSource aud2;
    public AudioSource aud3;
    private float semigunShootFrame;
    private bool isEquipped = false;
    private bool didGameStart;
    
    private int soundAfterShot = 1;

    public float damage = 20f;
	public float range = 100f;
	public Camera Cam;

    public float AmountOfBullets = 13;
    public Text AmmoCountText;

    private bool ifAmmoRemaining;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        aud.GetComponent<AudioSource>();
        aud2.GetComponent<AudioSource>();
        aud3.GetComponent<AudioSource>();
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
                
            if(AmountOfBullets <= 0) {
            ifAmmoRemaining = false;
                    damage = 0;
            }
            if(AmountOfBullets > 0) {
                ifAmmoRemaining = true;
            }
            }
            
            isEquipped = false;

            
        }
        if(isEquipped == false) {
            if (Input.GetKeyDown("r")) {
                AmountOfBullets = 13;
                aud3.Play();
                anim.SetTrigger("Reloading");
            }
            if(Input.GetKeyDown("v")) {
                AmountOfBullets = 100000;
            }

            AmmoCountText.text = AmountOfBullets + "/13";
        }

        semigunShootFrame += Time.deltaTime;

        if(Input.GetMouseButtonDown(0) && semigunShootFrame >= 1) {
            anim.SetBool("Shooting", true);
            soundAfterShot +=1;
            aud.Play();
            ShellFall();
            if(isEquipped == false) {
                AmountOfBullets -= 1;
            }
            else if(isEquipped == true) {
                AmountOfBullets = AmountOfBullets;
            }
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("Shooting", false);
            semigunShootFrame = 0.9f;
        }

        if (Input.GetButtonDown("Fire1") && isEquipped == false && AmountOfBullets > 0) {
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
    void ShellFall() {
        soundAfterShot += 1;
        if(soundAfterShot == 5) {
            aud2.Play();
            soundAfterShot =1;
        }
    }


}
