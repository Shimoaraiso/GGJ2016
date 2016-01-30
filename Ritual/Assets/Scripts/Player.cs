using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float moveSpeed = 10;
	float inputX;
	float inputY;

	public Rigidbody2D rb2d;
	public Animator anmtr;
	FireCounter fireCtr;

	void Awake() {
		fireCtr = GameObject.Find("FireGUI").GetComponent<FireCounter>();
	}

	void Start() {

	}

	void Update() {
		UserInput();
		MecCheck();
	}

	void FixedUpdate() {
		Move();
		Clamp();
	}

	void Move() {
		rb2d.velocity = new Vector2(inputX * moveSpeed, inputY * moveSpeed);
		if (inputX < 0)
			transform.eulerAngles = new Vector3(0, 0, 90);
		if (inputX > 0)
			transform.eulerAngles = new Vector3(0, 0, -90);
		if (inputY > 0)
			transform.eulerAngles = new Vector3(0, 0, 0);
		if (inputY < 0)
			transform.eulerAngles = new Vector3(0, 0, 180);

		//if (transform.localScale.x > 0 && h < 0 || (transform.localScale.x < 0 && h > 0)) {
		//	transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
		//}
	}

	void Clamp() {
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

		Vector2 pos = transform.position;

		pos.x = Mathf.Clamp(pos.x, min.x, max.x);
		pos.y = Mathf.Clamp(pos.y, min.y, max.y);

		transform.position = pos;
	}

	void UserInput() {
		inputX = Input.GetAxisRaw("Horizontal");
		inputY = Input.GetAxisRaw("Vertical");
	}

	void MecCheck() {
		//velocityX = cRigidbody2D.velocity.x;
		//velocityY = cRigidbody2D.velocity.y;
		//isRunning = Mathf.Abs(velocityX) > 0.1 ? true : false;
		//isJumping = (velocityY > 0.1 && isGrounded) ? true : false;
		//isFalling = (velocityY < 0 && isGrounded) ? true : false;
		anmtr.SetFloat("Horizontal", inputX);
		anmtr.SetFloat("Vertical", inputY);

		//anmtr.SetBool("isRunning", isRunning);
		//anmtr.SetBool("isJumping", isJumping);
		//anmtr.SetBool("isFalling", isFalling);
		//anmtr.SetBool("isGrounded", isGrounded);
	}
}