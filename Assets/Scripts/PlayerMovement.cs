using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	public float jumpForce = 200f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0, 0, this.forwardForce * Time.deltaTime);

		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			rb.AddForce(this.sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}


		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			rb.AddForce(-1 * this.sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey(KeyCode.Space) && this.rb.position.y > 1 && this.rb.position.y < 1.1) {
			rb.AddForce(0, this.jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
		}

		if (this.rb.position.y < -1f) {
			FindObjectOfType<GameManager>().endGame();
		}
	}
}
