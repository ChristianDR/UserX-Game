using UnityEngine;
using System.Collections;

public class MusicAnalyzer : MonoBehaviour {

	public AudioAnalyzing lyd;
	
	public float safeDelay;
	public float pitchThreshold;
	public float volumeThreshold;
	
	private float lastSafeTime;
	private float averagePitch;
	private float averageVolume;

	private bool isSafe;

	// Use this for initialization
	void Start () {
		pitches = new float[numberOfFrames];
	}
	
	// Update is called once per frame
	void Update () {
		SafeTimer();
		//averagePitch = CalculateAverage(true);
		averageVolume = CalculateAverage(false);
		//print(lyd.rmsValue);
		//print(averageVolume);
		//print(averagePitch);
		if (lyd.rmsValue > volumeThreshold && lyd.rmsValue > averageVolume * (1 + (thresholdPercentageIncrease / 100))) {

		}
		if (Time.timeSinceLevelLoad - lastSafeTime > safeDelay && lyd.rmsValue > volumeThreshold && lyd.rmsValue > averageVolume * (1 + (thresholdPercentageIncrease / 100))) {
		//if (Time.timeSinceLevelLoad - lastSafeTime > safeDelay && lyd.pitchValue > pitchThreshold && lyd.pitchValue > averagePitch * (1 + (thresholdPercentageIncrease / 100)) && lyd.rmsValue > volumeThreshold) {
			StartSafeTimer();
		}
	}

	public int numberOfFrames;
	public float thresholdPercentageIncrease;
	private float[] pitches;
	private int frameCounter;
	private float sum;

	float CalculateAverage (bool usePitch) {
		frameCounter++;
		if (usePitch)
			pitches[frameCounter % numberOfFrames] = lyd.pitchValue;
		else
			pitches[frameCounter % numberOfFrames] = lyd.rmsValue;
		sum = 0;
		for (int i = 0; i < pitches.Length; i++) {
			sum += pitches[i];
		}
		return sum / pitches.Length;
	}

	public float safeTime;
	private float timeOfSafeActivation;

	void SafeTimer () {
		if (isSafe && Time.timeSinceLevelLoad > timeOfSafeActivation + safeTime) {
			isSafe = false;
			guiTexture.color = Color.red;
		}
	}

	void StartSafeTimer () {
		isSafe = true;
		timeOfSafeActivation = Time.timeSinceLevelLoad;
		lastSafeTime = Time.timeSinceLevelLoad;
		guiTexture.color = Color.green;
	}

	public bool IsSafe {
		get {
			return isSafe;
		}
	}
}
