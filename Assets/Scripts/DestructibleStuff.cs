using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class DestructibleStuff : MonoBehaviour {

	public float delayTime = 2;
	public float explodeForce = 20;

	void Update() {
		if (Input.GetKey(KeyCode.P))
			Explode();
	}

	public void Explode() {
		foreach (Transform child in transform){
			child.rigidbody.isKinematic = false;
			child.rigidbody.AddForce(explodeForce, -explodeForce, explodeForce);
		}
		SoundManager.i.Play(SoundManager.i.breakStuff, 1);
        Invoke("Delete", delayTime);
	}

	void Delete() 
    {
		Destroy(gameObject);
    /*    foreach (Transform child in transform)
        {
			GameObject.Destroy(child.gameObject);
        }*/
	}	
}
