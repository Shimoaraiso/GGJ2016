using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float moveSpeed = 10;
	float inputX;
	float inputY;

	public Rigidbody2D rb2d;
	public Animator anmtr;
	Fire fire;

	void Awake() {
		fire = GameObject.FindWithTag("Fire").GetComponent<Fire>();
	}

	void Start() {

	}

	void Update() {
		UserInput();
		MecCheck();
	}

	void FixedUpdate() {
		if (GameController.isPlaying) {
			Move();
		} else {
			rb2d.velocity = Vector2.zero;
        }
		Clamp();
	}

	void Move() {
		rb2d.velocity = new Vector2(inputX * moveSpeed, inputY * moveSpeed);
		if (inputY > 0f && inputX < 0.5f) {		// 上
			transform.eulerAngles = new Vector3(0, 0, 0);
			anmtr.SetInteger("RotateZ", 1);
		}
		if (inputX > 0f) {						// 右
			transform.eulerAngles = new Vector3(0, 0, -90);
			anmtr.SetInteger("RotateZ", 2);
		}
		if (inputY < 0f && inputX > -0.5f) {	// 下
			transform.eulerAngles = new Vector3(0, 0, 180);
			anmtr.SetInteger("RotateZ", 3);
		}
		if (inputX < 0f) {						// 左
			transform.eulerAngles = new Vector3(0, 0, 90);
			anmtr.SetInteger("RotateZ", 4);
		}
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
		anmtr.SetFloat("Horizontal", inputX);
		anmtr.SetFloat("Vertical", inputY);
	}
}