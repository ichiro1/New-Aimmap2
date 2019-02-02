using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRandomPosition : MonoBehaviour {
    public Transform targetTransform;
    private float targetSecondCount = 1;
    public GameObject Targets;

	// Use this for initialization
	void Start () {
        targetTransform.GetComponent<Transform>();
        Targets.GetComponent<Transform>();

        InvokeRepeating("CreateTarget", 5.0f, 5.0f);

    }

    void CreateTarget()
    {
        targetSecondCount += 1;

        if (targetSecondCount == 50)
        {
            Vector3 TargetNewPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-3f, 8f), 30);
            Instantiate(Targets, TargetNewPosition, Quaternion.identity);
        }

    }
    

    // Update is called once per frame
    void Update () {
		
	}
}
