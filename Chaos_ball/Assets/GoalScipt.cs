using UnityEngine;
using System.Collections;

public class GoalScipt : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		GameObject collideWidth = collider.gameObject;
		if (collideWidth.tag == gameObject.tag) {
			GetComponent<Light> ().intensity = 0;
			Destroy (collideWidth);
		}
	}
}
