using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sword2Script : MonoBehaviour {

	//Declare your variables
	// Create a tracking variable for the damage
	private int damageCount = 0;
	// Creates a tracking variable for the damage per hit of the sword
	private int swordDamage = 1;
	// Creates an image variable the image.
	private Image image;
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
		levelUp (8, IronFire, false);
		levelUp (16, IronFire2, false);
		levelUp (32, Gold, false);
		levelUp (64, GoldFire, false);
		levelUp (128, GoldFire2, false);
		killingTheDragon (256, BackgroundSkin, backgroundQuad, false);
	}
	// When the damageCount gets to damage, it will change the material to swordType
	void levelUp (int damage, Material newMaterial, bool triggered){
		if (damageCount >= damage && !triggered) {
			image.material = newMaterial;
			triggered = true;
		}
	}
	void killingTheDragon (int damage, Material backgroundSkin, Renderer background, bool triggered) {
		if (damageCount >= damage && !triggered) {
			background.material = backgroundSkin;
			triggered = true;
		}
	}
	//Increases the damage by swordDamage when it is called
	public void damage () {
		damageCount += swordDamage;
	}
}
