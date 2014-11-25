using UnityEngine;
using System.Collections;

public class TheGame : MonoBehaviour {

	public float gameTime = 506;
	public float gravity = 20;

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, -gravity, 0);
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
		CheckGameOver();
		CheckQuit();
	}

	private bool gameOver;

	void CheckGameOver() {
		if(!gameOver && Time.timeSinceLevelLoad > gameTime) {
			GameObject.Find("Game Over").SendMessage("GameOver");
			gameOver = true;
		}
	}

	void CheckQuit() {
		if (Input.GetKey(KeyCode.Q)) {
			GameObject.Find("Game Over").SendMessage("GameOver");
			gameOver = true;
		}
	}
}
