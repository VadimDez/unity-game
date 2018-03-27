using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;

	void OnCollisionEnter(Collision collisionInfo) {
		Debug.Log(collisionInfo.collider.name);

		if (collisionInfo.collider.tag == "Obstacle") {
			this.movement.enabled = false;

			FindObjectOfType<GameManager>().endGame();
		}
	}
}
