using UnityEngine;
using System.Collections;
using System.Reflection;

public class DestroyStuff : MonoBehaviour {

	public int pointReward = 100;
	public int pointPenalty = -100;

	void OnCollisionEnter(Collision col){;
		if(col.gameObject.tag == "destructibleObject"){
			if(GameObject.Find("Safe Indicator").GetComponent<MusicAnalyzer>().IsSafe == true) {
				col.gameObject.SendMessage("Explode");
				GameObject.Find ("Score").GetComponent<Score>().AddToScore(pointReward);
				Destroy(col.gameObject, 1.5f);
				//col.gameObject.animation.Play("Take 001");
			}
			else {
				GameObject.Find ("Score").GetComponent<Score>().AddToScore(pointPenalty);
				//SoundManager.i.Play(SoundManager.i.warning, 1);
			}
		}
	}
}
