using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	private int highScore;

	// Use this for initialization
	void Update () {
		highScore = PlayerPrefs.GetInt("HighScore");
		guiText.text = "High Score: " + highScore;
	}
}
