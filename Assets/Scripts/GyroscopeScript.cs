using UnityEngine;
using System.Collections;

public class GyroscopeScript : MonoBehaviour {

	//public GUIText debug;
	//public string input;
	private Gyroscope gyro;
	private bool gyroBool;
	//private Quaternion rotFix = new Quaternion(0,0,0,0);
	private float rotFixX;
	private float rotFixY;
	private float rotFixZ;
	private float rotFixW;

	// Use this for initialization
	void Start () {
		gyroBool = SystemInfo.supportsGyroscope;
		if (gyroBool){
			Input.gyro.enabled=true;
			gyro = Input.gyro;


		}
		//rotFix = Quaternion.Euler(90, 90, 90);

	}
	
	// Update is called once per frame
	void Update () {

		rotFixX = gyro.attitude.x*(-1);
		rotFixY = gyro.attitude.y*(-1);
		rotFixZ = gyro.attitude.z*(-1);
		rotFixW = gyro.attitude.w;

		transform.rotation = new Quaternion (rotFixX,rotFixZ,rotFixY,rotFixW);
		//gameObject.transform.rotation.x = rotFixX;
		//gameObject.transform.rotation.y = rotFixY;
		//gameObject.transform.rotation.z = rotFixZ;
		//gameObject.transform.rotation.w = rotFixW;
		//transform.rotation = gyro.attitude;
	

	}

}
