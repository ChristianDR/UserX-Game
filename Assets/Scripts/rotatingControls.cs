using UnityEngine;
using System.Collections;

public class rotatingControls : MonoBehaviour {

	public int maxRotation;
	public int rotationSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButton ("Left")) {

			transform.Rotate(Vector3.left*Time.deltaTime*rotationSpeed);

		}

		if (Input.GetButton ("Right")) {

			transform.Rotate(Vector3.left*Time.deltaTime*(-rotationSpeed));

		}

		if (Input.GetButton ("Up")) {

			transform.Rotate(Vector3.forward*Time.deltaTime*rotationSpeed);

		}

		if (Input.GetButton ("Down")) {

			transform.Rotate(Vector3.forward*Time.deltaTime*(-rotationSpeed));

		}

	}
}
