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
	public Material IronFire, IronFire2, Gold, GoldFire, GoldFire2;

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
	}
	// When the damageCount gets to damage, it will change the material to swordType
	void levelUp (int damage, Material swordType, bool triggered){
		if (damageCount >= damage && !triggered) {
			image.material = swordType;
			triggered = true;
		}
	}
	//Increases the damage by swordDamage when it is called
	public void damage () {
		damageCount += swordDamage;
	}
}
