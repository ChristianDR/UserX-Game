using UnityEngine;
using System.Collections;

public class positionScript : MonoBehaviour {

	public GameObject ball;
	public GameObject plane;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = ball.transform.position;
		transform.rotation = plane.transform.rotation;

	}
}
