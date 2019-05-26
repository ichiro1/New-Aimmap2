using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSwitch : MonoBehaviour {
	public Transform gunbody1;
	public Transform gunbody2;
	public Transform playerTransform;
	public int gunbodytransform = 1;
	public Renderer Ak;
	public Renderer Colt;
	public Renderer AkMagazine;
	public Renderer AkShell;
	public Renderer ColtShell;
	public Renderer ColtMagazine;
	public Renderer ColtSlide;
	public Renderer AkLeftHand;
	public Renderer BerettaRightHand;
	private bool gunSwitcher;

	// Use this for initialization
	void Start () {
		gunbody1.GetComponent<Transform>();
		gunbody2.GetComponent<Transform>();
		if(true) {
			Ak.GetComponent<MeshRenderer> ();
			Colt.GetComponent<MeshRenderer> ();
			Colt.enabled = false;

			AkMagazine.GetComponent<MeshRenderer> ();
			AkShell.GetComponent<MeshRenderer> ();
			ColtShell.GetComponent<MeshRenderer> ();
			ColtMagazine.GetComponent<MeshRenderer> ();
			ColtSlide.GetComponent<MeshRenderer> ();
			AkLeftHand.GetComponent<MeshRenderer>();
			BerettaRightHand.GetComponent<MeshRenderer>();

			ColtShell.enabled = false;
			ColtMagazine.enabled = false;
			ColtSlide.enabled = false;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown ("1")) {
            gunSwitcher = false;
		}
		if (Input.GetKeyDown ("2")) {
            gunSwitcher = true;
		}
		if (gunSwitcher == false) {
			Ak.enabled = true;
			AkMagazine.enabled = true;
			AkShell.enabled = true;
			AkLeftHand.enabled = true;

			Colt.enabled = false;
            ColtShell.enabled = false;
            ColtMagazine.enabled = false;
            ColtSlide.enabled = false;
			BerettaRightHand.enabled = false;

		} 
		else if(gunSwitcher == true){
			Colt.enabled = true;
			ColtShell.enabled = true;
			ColtMagazine.enabled = true;
			ColtSlide.enabled = true;
			BerettaRightHand.enabled = true;

			Ak.enabled = false;
            AkMagazine.enabled = false;
            AkShell.enabled = false;
			AkLeftHand.enabled = false;
			
		}

	}
}
