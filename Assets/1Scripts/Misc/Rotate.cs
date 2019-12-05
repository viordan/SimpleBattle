using UnityEngine;

public class Rotate : MonoBehaviour {
	public float rotateSpeed = 10;
	public bool stopRotation = false;
	void Update() {
		if (!stopRotation) {
			RotateObject();
		}
	}
	void RotateObject() {
		transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);
	}
}
