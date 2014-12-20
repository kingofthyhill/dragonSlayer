using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {


	//Creating arrays for the position of the stages, the position of the menus, and the hex codes of the colors
	//0 refers to Chateau. 1 referes to Wald.
	private Vector2[]  stages = new Vector2[2];
	//0 refers to Main, 1 refers to stageSelect, 2 refers to upgrades, and 3 refers to credits.
	private Vector2[] menus = new Vector2[4];
	//0 refers to black. 1 refers to a bluish that is the normal.
	private Color[] colors = new Color[2]; 

	// Use this for initialization
	void Start () {
		//Setting the position of the menus
		menus [0] = new Vector2 (1000, 0);
		menus [1] = new Vector2 (1000, 350);
		menus [2] = new Vector2 (2000, 0);
		menus [3] = new Vector2 (2000, 350);
		//Setting the position of the stages
		stages[0] = new Vector2 (0, 0);
		stages [1] = new Vector2 (0, 350);
		//Setting the colors
		colors [0] = new Color (0, 0, 0);
		colors [1] = new Color (0, .2392f, .4784f);
	}
	//Brings the camera to the numbered battle zone.
	public void battle (int stage){
		transform.position = stages[stage];
	}
	// Brings the camera to the numbered menu
	public void menu (int menuNum){
		transform.position = menus [menuNum];
	}
	// Sets the camera's background color to the numbered value.
	public void backgroundColor (int colorType) {
		camera.backgroundColor = colors [colorType];
	}
}