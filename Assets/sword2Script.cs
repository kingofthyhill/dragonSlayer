// Declare your using.
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sword2Script : MonoBehaviour {

	// Declare your variables
	// Create a tracking variable for the damage and for the experience
	private int damageCount = 0, expCount = 0;
	// Creates a tracking variable for the damage and experience per hit of the sword
	private int swordDamage = 1, swordExperience = 1;
	// Creates an image variable the image.
	private Image image; 
	// Creates a bool array for all the triggers/
	private bool[] trigger = new bool[6];
	// Create five material variables for the different sword types.
	public Material IronFire, IronFire2, Gold, GoldFire, GoldFire2, BackgroundSkin;
	// Creates a renderer variable for the background
	public Renderer backgroundQuad;

	// Use this for initialization
	void Start () {
		image = GetComponent <Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		levelUp (8, IronFire,1,0);
		levelUp (16, IronFire2,2,1);
		levelUp (32, Gold, 4,2);
		levelUp (64, GoldFire,8,3);
		levelUp (128, GoldFire2,16,4);
		killingTheDragon (3000, BackgroundSkin, backgroundQuad, 100, 5);
	}
	/* When the expCount gets to the set experience level, it will change the material to swordType, increase the swordDamage with bonusDamage,
	 and blocks it from happening again.*/
	void levelUp (int experience, Material newMaterial,int bonusDamage, int triggerNum){
		if (expCount >= experience && !trigger[triggerNum]) {
			trigger [triggerNum] = true;
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
	//Increases the damage by swordDamage amd exp by swordExperience when it is called
	public void attack () {
		damageCount += swordDamage;
		expCount += swordExperience;
	}
}
