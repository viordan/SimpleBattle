using UnityEngine;

public class Rotate : MonoBehaviour {
	public float rotateSpeed = 10;
	public bool allowRotation = true;
	void Update() {
		if (allowRotation) {
			RotateObject();
		}
	}
	void RotateObject() {
		transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);
	}
}
