using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 2f;

	public GameObject completeLevelUI;

	public void endGame() {

		if (!this.gameHasEnded) {
			this.gameHasEnded = true;

			Invoke ("restart", this.restartDelay);
		}
	}

	public void completeLevel() {
		this.completeLevelUI.SetActive(true);
	}

	void restart() {
		GameContoller.controller.fails++;

		string sceneName;

		if (GameContoller.controller.fails >= 3) {
			sceneName = "GameOver";
			GameContoller.controller.reset();
		} else {
			sceneName = SceneManager.GetActiveScene().name;
		}

		SceneManager.LoadScene(sceneName);
	}

}
