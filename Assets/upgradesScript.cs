using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class upgradesScript : MonoBehaviour {

	//Declare an array for the buttons.
	public Button[] upgrades = new Button[2]; 
	//Declare an array for the costs.
	public int[] cost = new int[2]; 
	public string[] ED = new string[2];
	public int[] bonus = new int[2]; 
	//Create a variable to insert the playerScript
	public playerScript player;
	public soundScript sound; 
	//Create a variable to control the text for the gold Counter
	public Text goldCounter;

	// Update is called once per frame
	void Update () {
		buttonAvailable (0);
		buttonAvailable (1);
		goldCount ();
	}
	/*Takes buttonNum and costNum. References them with arrays to make the choice available only if you have enough gold. Uses playerScript*/
	public void buttonAvailable (int buttonNum){
		if (cost[buttonNum] <= player.goldCount) {
			upgrades[buttonNum].interactable = true;
		} else if (cost[buttonNum] > player.goldCount) {
			upgrades[buttonNum].interactable = false;
		}
	}
	// Runs when you buy an item. Plays a sound for the buying, and increases either sword damage per hit or sword experience per hit.
	public void buyItem (int buttonNum){
		sound.playSound (1);
		if (ED [buttonNum] == "D") {
			player.bonusDPH(bonus[buttonNum]);
			player.goldCount = player.goldCount - cost[buttonNum];
		} else if (ED [buttonNum] == "E") {
			player.bonusEPH(bonus[buttonNum]);
			player.goldCount = player.goldCount - cost[buttonNum];
		}
	}
	/*Changes the text for the gold counter to however much gold you have.*/
	void goldCount() {
		if (player.goldCount > 0) {
			goldCounter.text = "Gold: " + player.goldCount.ToString ();
		} else if (player.goldCount <= 0) {
			goldCounter.text = "Gold: Broke";
		}
	}
}
