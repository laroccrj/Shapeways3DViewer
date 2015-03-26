using UnityEngine;
using System.Collections;

public class ModelController : MonoBehaviour {

	public float rotationSensitivity = 50;
	public Transform spinner;

	private bool grab = false;
	private Vector3 lastPosition = Vector3.zero;

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)) {
			if(!this.grab) {
				this.lastPosition = Input.mousePosition;
				this.grab = true;
			}
		}
		else {
			this.grab = false;
		}

		if(!this.grab) {
			return;
		}

		Vector3 currentMousePosition = Input.mousePosition;
		Vector3 difference = currentMousePosition - this.lastPosition;
		Vector3 movementY = new Vector3(0, difference.x * -1);
		Vector3 movementX = new Vector3(difference.y * -1, 0);

		transform.Rotate(movementX * this.rotationSensitivity * Time.deltaTime);
		this.spinner.Rotate(movementY * this.rotationSensitivity * Time.deltaTime);

		this.lastPosition = currentMousePosition;
	}
}
