using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;

public class buttonScript : MonoBehaviour {

	public Button button1;
	private int count = 1;

	// Use this for initialization
	void Start () {
		button1 = GetComponent <Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		//button1.onClick.AddListener (yay)  ;
	}
	public void countForMe () {
		Debug.Log (count);
		count += 1;
		}
}