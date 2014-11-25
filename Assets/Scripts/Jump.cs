using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public int jumpPower;
	public float gravity;
	private bool grounded;

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, -gravity, 0);
		distanceToGround = collider.bounds.extents.y;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private float distanceToGround;
	
	bool CanJump() {
		return Physics.Raycast(transform.position, -Vector3.up, distanceToGround + 0.1f);;
	}
	
	void JumpNow () {
		rigidbody.AddForce(Vector3.up*jumpPower);
	}
}
