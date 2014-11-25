using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public static SoundManager i;

	public AudioClip breakStuff;
	public AudioClip warning;
	public AudioClip gameOver;

	void Awake () {
		i = this;
	}

	public void Play(AudioClip clip, float volume) 
	{
		audio.PlayOneShot(clip, volume);
	}
}
