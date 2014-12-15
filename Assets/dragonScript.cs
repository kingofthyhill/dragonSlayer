using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class dragonScript : MonoBehaviour {

	// Creates a tracking variable for the dragon's health minus damage.
	private int dragonHealthNum;
	// Creates a bool array for all the triggers
	private bool[] trigger = new bool[6];
	public Material backgroundSkin;
	// Creates a renderer variable for the background
	public Renderer backgroundQuad;
	// Creates a text variable for displaying the dragons health
	public Text healthDisplay;
	// Creates a modifiable variable for the dragon's health
	public int dragonHealthTotal;
	public playerScript player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Sets up the events for when the dragon dies.
		killingTheDragon (dragonHealthTotal,backgroundSkin, backgroundQuad, 100, 0);
		dragonHealth (dragonHealthTotal);
	}
	/*Once the damageCount has reached the set damage level, it will change the background to backgroundSkin, give you bonusExp, and 
		 blocks it from happening again*/
	void killingTheDragon (int damage, Material backgroundSkin, Renderer background, int bonusExp, int triggerNum) {
		if (player.damageCount >= damage && !trigger[triggerNum]) {
			background.material = backgroundSkin;
			player.expCount += bonusExp;
			trigger[triggerNum] = true;
		}
	}
	// Displays the dragon's health as a changing variable.
	void dragonHealth(int maxHealth) {
		dragonHealthNum = maxHealth - player.damageCount;
		if (dragonHealthNum > 0) {
			healthDisplay.text = "Health: " + dragonHealthNum.ToString ();
		} else if (dragonHealthNum <= 0) {
			healthDisplay.text = "Health: Dead";
		}
	}
}
