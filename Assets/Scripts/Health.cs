using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	public Text healthText;

	void Update () {
		Debug.Log("ASD");
		string str = "";
		for (int i = GameContoller.controller.fails; i < 3; i++) {
			str += "♥";
		}
		this.healthText.text = str;
	}
}
