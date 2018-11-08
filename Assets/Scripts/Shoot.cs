using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Animation anim;
	// Use this for initialization
	void Start () {
        anim.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)) {
            anim.Play();
        }
        if(Input.GetMouseButtonUp(0)) {
            anim.Stop();
        }
	}
}
