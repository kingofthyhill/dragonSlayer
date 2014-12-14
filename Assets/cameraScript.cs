using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void battleChateau (){
		transform.position = new Vector3 (0, 0, transform.position.z);
	}
	public void stageSelect () {
		transform.position = new Vector3 (1000, 350, transform.position.z);
	}
}