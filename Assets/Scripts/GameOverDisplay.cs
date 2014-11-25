using UnityEngine;
using System.Collections;

public class GameOverDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guiText.enabled = false;
	}

	public void GameOver() {
		guiText.text = "Score: " + GameObject.Find("Score").GetComponent<Score>().GetScore();
		guiText.enabled = true;
		//SoundManager.i.Play(SoundManager.i.GameOver, 1);
		if (GameObject.Find("Score").GetComponent<Score>().GetScore() > PlayerPrefs.GetInt("HighScore")) {
			PlayerPrefs.SetInt("HighScore", GameObject.Find("Score").GetComponent<Score>().GetScore());
		}
		Invoke("LoadMenu", 4);
	}

	public void LoadMenu() {
		Application.LoadLevel("Menu");
	}	
}
