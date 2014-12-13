using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour {

	public bool touching;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		touching = Physics.Raycast (transform.position, Vector3.down, 0.5f);
	}
}
