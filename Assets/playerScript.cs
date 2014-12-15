using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerScript : MonoBehaviour {

	
	// Declare your variables
	// Create a tracking variable for the gold and for the experience
	private int goldCount;
	//Creates a tracking variable for the gold timer.
	private int goldTimer;
	// Creates a tracking variable for the damage and experience per hit of the sword and sets them both to 1
	private int swordDamage = 1, swordExperience = 1; 
	// Creates an interger for the level.
	private int levelGlobal;
	// Create five material variables for the different sword types.
	public Material[] swordType = new Material[5];
	// Creates an image variable the image.
	public Image[] swords = new Image[2];
	// Creates a refrenceable variable for the damage and exp
	public int expCount, damageCount;
	
	// Update is called once per frame
	void Update () {
		// Sets the first five levels of swords
		levelUp (8, 0, 1, 1);
		levelUp (16, 1, 2, 2);
		levelUp (32, 2, 4, 3);
		levelUp (64, 3, 8, 4);
		levelUp (128, 4, 16, 5);
		
	}
	/* When the expCount gets to the set experience level, it will change the material to swordType, increase the swordDamage with bonusDamage,
		 and blocks it from happening again.*/
	void levelUp (int experience, int materialNum ,int bonusDamage, int level){
		if (expCount >= experience && level > levelGlobal) {
			levelGlobal  += 1;
			for (int i=0; i < swords.Length; i++) {
				swords[i].material = swordType[materialNum];
			}
			swordDamage += bonusDamage;
			Debug.Log ("You leveled up!");
		}
	}
	//Increases the damage by swordDamage amd exp by swordExperience when it is called
	public void attack () {
		damageCount += swordDamage;
		expCount += swordExperience;
		if (goldTimer == 5) {
			goldCount += 1;
		} else {
			goldTimer += 1;
		}
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
