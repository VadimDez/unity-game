using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;

	// Use this for initialization
	void OnTriggerEnter() {
		this.gameManager.completeLevel();
	}
}
