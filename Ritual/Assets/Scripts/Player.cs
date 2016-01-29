using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float moveSpeed = 10;
	float inputX;
	float inputY;

	public Rigidbody2D rb2d;

	FireCounter fireCtr;

	void Awake() {
		fireCtr = GameObject.Find("FireGUI").GetComponent<FireCounter>();
	}

	void Start() {

	}

	void Update() {	
		UserInput();
	}

	void FixedUpdate() {
		Move();
	}

	void Move() {
		rb2d.velocity = new Vector2(inputX * moveSpeed, inputY * moveSpeed);
		if(inputX < 0) transform.eulerAngles = new Vector3(0, 0, 90);
		if(inputX > 0) transform.eulerAngles = new Vector3(0, 0, -90);
		if(inputY > 0) transform.eulerAngles = new Vector3(0, 0, 0);
		if(inputY < 0) transform.eulerAngles = new Vector3(0, 0, 180);
	}

	void UserInput() {
		inputX = Input.GetAxisRaw("Horizontal");
		inputY = Input.GetAxisRaw("Vertical");
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Enemy") {
			//if (fireCtr.fireNum > 0) {
			//	fireCtr.fireNum -= 1;
			//}
		}

	}
}