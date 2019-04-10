using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRandomPosition : MonoBehaviour {
    public Transform targetTransform;
    private float targetSecondCount = 1;
    public GameObject Targets;

    private Quaternion targetRotation = Quaternion.Euler(90,0,0);
	private float targetTransformZ = -96;

    private bool hasTargetSpawned = false;
    private float uPressed;
	// Use this for initialization
	void Start () {
        targetTransform.GetComponent<Transform>();
        Targets.GetComponent<Transform>();


    }
    
    

    // Update is called once per frame
    void Update () {
		targetSecondCount += 1;
        if(Input.GetKeyDown("u")) {
            targetTransformZ -= 20;
            uPressed += 1;
            if(uPressed >= 20) {
            uPressed = 0;
        }
        if(uPressed < 20) {
            targetTransformZ -= 0f;
        }
		}
        
        if (targetSecondCount == 75)
        {
            
            Vector3 TargetNewPosition = new Vector3(Random.Range(-20f, 30f), Random.Range(10f, 18f), targetTransformZ);
            Instantiate(Targets, TargetNewPosition, targetRotation);
            targetSecondCount = 1;
            hasTargetSpawned = true;
            Destroy(gameObject);
	}
    }
}
