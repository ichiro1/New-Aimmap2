using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RaycastTargetHit : MonoBehaviour {
	public float health = 20f;
	public Transform targetTransform;
    private float targetSecondCount = 1;
    public GameObject Targets;
	private Quaternion targetRotation = Quaternion.Euler(90, 0, 0);

	private float targetTransformZ = -96;
	private float UPressed;
	private float pointValue = 100;
	public Text pointDisplay;

	public float totalPoints = 100f;
	void Update () {
		pointDisplay.GetComponent<Text>();
		
	}
	public void TakeDamage(float amount) {
		health -= amount;
		if(health <= 0f) {
			totalPoints = totalPoints += 100;
            health = 20f;
            Vector3 TargetNewPosition = new Vector3(Random.Range(-30f, 30f), Random.Range(3f, 15f), targetTransformZ);
            Instantiate(Targets, TargetNewPosition, targetRotation);
			
			Die();
			
		}
	}
	
	void Die() {
		Destroy(gameObject);
		pointDisplay.text = "Points: " + totalPoints;
		Debug.Log(totalPoints);
	}
}
