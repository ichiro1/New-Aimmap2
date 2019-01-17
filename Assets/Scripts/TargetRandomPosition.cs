using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRandomPosition : MonoBehaviour {
    private Transform targetTransform;
    public GameObject Targets;

	// Use this for initialization
	void Start () {
        targetTransform.GetComponent<Transform>();
        Targets.GetComponent<Transform>();

        Vector3 TargetNewPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
        Instantiate(Targets, TargetNewPosition, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
