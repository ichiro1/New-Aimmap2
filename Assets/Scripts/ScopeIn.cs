using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeIn : MonoBehaviour {

	float m_FieldOfView = 60f;

	// Use this for initialization
	void Start () {
		Debug.Log(Camera.main.fieldOfView);

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(1)) {
			Camera.main.fieldOfView = m_FieldOfView;
		}
	}
}
