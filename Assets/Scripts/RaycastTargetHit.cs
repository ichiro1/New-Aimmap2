using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTargetHit : MonoBehaviour {
	public float health = 20f;
	public Transform targetTransform;
    private float targetSecondCount = 1;
    public GameObject Targets;
	private Quaternion targetRotation = Quaternion.Euler(90, 0, 0);

	public void TakeDamage(float amount) {
		health -= amount;
		if(health <= 0f) {
			Vector3 TargetNewPosition = new Vector3(Random.Range(-30f, 30f), Random.Range(3f, 8f), -96);
            Instantiate(Targets, TargetNewPosition, targetRotation);

			Die();
		}
	}
	
	void Die() {
		Destroy(gameObject);
	}
}
