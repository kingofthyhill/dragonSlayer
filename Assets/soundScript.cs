using UnityEngine;
using System.Collections;

public class soundScript : MonoBehaviour {

	public AudioClip[] soundFiles = new AudioClip[2];
	public float[] volume = new float[2];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// Makes it play a sound at a certain loudness.
	public void playSound (int clipNum) {
		audio.PlayOneShot (soundFiles [clipNum], volume [clipNum]);
		Debug.Log ("Playing sound file: " + clipNum.ToString());
	}
}
