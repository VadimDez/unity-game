using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public Text scoreLabel;

	void Update() {
		this.scoreLabel.text = GameContoller.controller.score.ToString();
	}

	public void newGame() {
		GameContoller.controller.score = 0;
		SceneManager.LoadScene("Level01");
	}

	public void quit() {
		Application.Quit();
	}
}
