using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void startGame() {
		SceneManager.LoadScene("Level01");
	}
}
