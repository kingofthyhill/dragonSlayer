using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	private Vector2[]  stages = new Vector2[6]; 
	private Vector2[] menus = new Vector2[3];
	private int stage = -1;

	// Use this for initialization
	void Start () {
		//Setting the position of the menus
		menus [0] = new Vector2 (1000, 0);
		menus [1] = new Vector2 (1000, 350);
		menus [2] = new Vector2 (1500, 0);
		//Setting the position of the stages
		stages[0] = new Vector2 (0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void battle (){
		if (stage != -1) {
			transform.position = stages[stage];
		}
	}
	public void stageSet (int stageSet){
		stage = stageSet;
	}
	public void menu (int menuNum){
		transform.position = menus [menuNum];
	}
}