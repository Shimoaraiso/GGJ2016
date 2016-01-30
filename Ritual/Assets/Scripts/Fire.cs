using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public int fireNum;
	int fireNumStock;

	TorchPower tp;
	Animator anim;

	void Awake() {
		tp = GameObject.Find("Torches").GetComponent<TorchPower>();
		anim = GetComponent<Animator>();
    }

	void Start() {
		fireNumStock = fireNum;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
            fireNum = MagicCircle.fireStoc;
			tp.show(fireNum);
		}
	}

	void Update() {
		if (fireNumStock != fireNum) {
			tp.show(fireNum);
			fireNumStock = fireNum;
		}
		anim.SetInteger("FireState", MagicCircle.fileState);
	}

}
