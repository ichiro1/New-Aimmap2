using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Animation anim;
    public int shootTickCount = 24;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)) {
            shootTickCount += 1;

        }


        if(shootTickCount == 25) {
            anim.Play();
            shootTickCount = 0;
        }
        if(Input.GetMouseButtonUp(0)) {
            anim.Stop();
        }
	}
}
