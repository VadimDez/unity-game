using UnityEngine;

public class GameContoller : MonoBehaviour {
	public static GameContoller controller;

	public int fails = 0;

	void Awake() {
		if (controller == null) {
			DontDestroyOnLoad(gameObject);
			controller = this;
		} else if (controller != this) {
			Destroy(gameObject);
		}
	}

	public void reset() {
		this.fails = 0;
	}
}
