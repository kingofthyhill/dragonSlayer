using UnityEngine;
using System.Collections;

public class swordScript : MonoBehaviour {

	private int damageCount;
	public Material IronFire, IronFire2, Gold, GoldFire, GoldFire2;
	public object background;

	// Use this for initialization
	void Start () {
		damageCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			damageCount += 1;
		}
		levelUp (8, IronFire);
		levelUp (16, IronFire2);
		levelUp (32, Gold);
		levelUp (64, GoldFire);
		levelUp (128, GoldFire2);
	}
// When the damageCount gets to damage, it will change the material to swordType
	void levelUp (int damage, Material swordType){
		if (damageCount == damage) {
			renderer.material = swordType;
		}
	}
}
