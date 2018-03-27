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
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
