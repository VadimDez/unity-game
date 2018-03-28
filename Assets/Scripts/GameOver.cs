using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public void newGame() {
		SceneManager.LoadScene("Level01");
	}

	public void quit() {
		Application.Quit();
	}
}
