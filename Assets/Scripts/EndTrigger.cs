using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter() {
		GameContoller.controller.score += (int) this.transform.position.z;
		this.gameManager.completeLevel();
	}
}
