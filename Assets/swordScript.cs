using UnityEngine;
using System.Collections;

public class swordScript : MonoBehaviour {

	private int damageCount;
	public Material IronFire, IronFire2, Gold, GoldFire, GoldFire2;
	public object background;

	// Use this for initialization
	void Start () {
		damageCount = 0;
		Debug.Log ("You are a knight in the service of your lord, Senor Dragonhammer. " +
			"Unfortunately, Senor Dragonhammer has offended a dragon and they have attacked his castle. " +
			"It is your duty to fight them off. " +
			"The dragon is wise and attacked the barracks first, killing all your fellow knights. " +
		    "Now you must fight the dragon off by yourself, freeing more blades from your fellow knights from the dragons flesh.");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			damageCount += 1;
		} if (damageCount == 8) {
			renderer.material = IronFire;
			Debug.Log ("Your sword catches fire.");
		} if (damageCount == 16) {
			renderer.material = IronFire2;
			Debug.Log ("The fire around your sword get hotter.");
		} if (damageCount == 32) {
			renderer.material = Gold;
			Debug.Log ("The magic infuses your sword, turning it into gold.");
		} if (damageCount == 64) {
			renderer.material = GoldFire;
			Debug.Log ("Your gold sword catches fire and burns brightly.");
		} if (damageCount == 128) {
			renderer.material = GoldFire2;
			Debug.Log ("Your golden sword burns brighter and gets hotter.");
		}
	}
}
