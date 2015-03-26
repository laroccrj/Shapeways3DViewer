using UnityEngine;
using System.Collections;

public class ModelLoader : MonoBehaviour {

	public GameObject objectToLoad;
	public Transform spinner;

	void Start () {
		this.LoadModel(this.objectToLoad);
	}
	
	void LoadModel(GameObject obj) {
		GameObject model = (GameObject) GameObject.Instantiate(obj, Vector3.zero, Quaternion.identity);
		model.AddComponent<ModelController>();
		ModelController modelController = (ModelController) model.GetComponent<ModelController>();
		modelController.spinner = this.spinner;
		model.transform.parent = this.spinner;
	}
}
