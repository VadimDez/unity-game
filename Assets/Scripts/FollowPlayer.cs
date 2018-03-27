using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;
	public Vector3 offset = new Vector3(0, 1, -5);
	
	// Update is called once per frame
	void Update () {
		this.transform.position = this.player.position + this.offset;
	}
}
