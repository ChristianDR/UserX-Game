using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Score: " + score;
	}

	public void AddToScore (int amount) {
		score =+ amount;
	}

	public int GetScore() {
		return score;
	}
}
