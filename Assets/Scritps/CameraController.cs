using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float scrollSensitivity;
	
	// Update is called once per frame
	void Update () {
		float scroll = Input.GetAxis("Mouse ScrollWheel");

		this.transform.position += (Vector3.forward * scroll * this.scrollSensitivity * Time.deltaTime);
	}
}
