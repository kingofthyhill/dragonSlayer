// Declare your using.
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sword2Script : MonoBehaviour {

		// Declare your variables
		// Create a tracking variable for the damage and for the experience
	private int damageCount = 0, expCount = 0;
		// Creates a tracking variable for the damage and experience per hit of the sword and sets them both to 1
	private int swordDamage = 1, swordExperience = 1;
		// Creates an image variable the image.
	private Image image; 
		// Creates an interger for the level.
	private int levelGlobal;
		/* Creates a tracking variable for the dragon's health and dragon's health minus damage.
		Sets the dragons total health to 3000.*/
	private int dragonHealthTotal = 3000, dragonHealthNum;
		// Creates a bool array for all the triggers
	private bool[] trigger = new bool[6];
		// Create five material variables for the different sword types.
	public Material IronFire, IronFire2, Gold, GoldFire, GoldFire2, BackgroundSkin;
		// Creates a renderer variable for the background
	public Renderer backgroundQuad;
		// Creates a text variable for displaying the dragons health
	public Text healthDisplay;
	
	void Start () {
			// Sets the image component to image.
		image = GetComponent <Image> ();
	}
	
	// Update is called once per frame
	void Update () {
			// Sets the first five levels of swords
		levelUp (8, IronFire, 1, 1);
		levelUp (16, IronFire2, 2, 2);
		levelUp (32, Gold, 4, 3);
		levelUp (64, GoldFire, 8, 4);
		levelUp (128, GoldFire2, 16, 5);
			// Sets up the events for when the dragon dies.
		killingTheDragon (dragonHealthTotal , BackgroundSkin, backgroundQuad, 100, 0);
		dragonHealth (dragonHealthTotal);

	}
		/* When the expCount gets to the set experience level, it will change the material to swordType, increase the swordDamage with bonusDamage,
		 and blocks it from happening again.*/
	void levelUp (int experience, Material newMaterial,int bonusDamage, int level){
		if (expCount >= experience && level > levelGlobal) {
			levelGlobal  += 1;
			image.material = newMaterial;
			swordDamage += bonusDamage;
			Debug.Log ("You leveled up!");
		}
	}
		/*Once the damageCount has reached the set damage level, it will change the background to backgroundSkin, give you bonusExp, and 
		 blocks it from happening again*/
	void killingTheDragon (int damage, Material backgroundSkin, Renderer background, int bonusExp, int triggerNum) {
		if (damageCount >= damage && !trigger[triggerNum]) {
			background.material = backgroundSkin;
			expCount += bonusExp;
			trigger[triggerNum] = true;
		}
	}
		// Displays the dragon's health as a changing variable.
	void dragonHealth(int maxHealth) {
		dragonHealthNum = maxHealth - damageCount;
		if (dragonHealthNum > 0) {
			healthDisplay.text = "Health: " + dragonHealthNum.ToString ();
		} else if (dragonHealthNum <= 0) {
			healthDisplay.text = "Health: Dead";
		}
	}
		//Increases the damage by swordDamage amd exp by swordExperience when it is called
	public void attack () {
		damageCount += swordDamage;
		expCount += swordExperience;
	}
		// Allows for increases of swordDamage.
	public void bonusDPH (int bonus) {
			swordDamage += bonus;
	}
		// Allows for increases of swordExperience
	public void bonusEPH (int bonus) {
		swordExperience += bonus;
	}
}
