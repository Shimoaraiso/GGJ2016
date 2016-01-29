using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	GameObject target;
	FireCounter fireCtr;

	bool isAttack;

	void Awake() {
		fireCtr = GameObject.Find("FireGUI").GetComponent<FireCounter>();
	}

	void Start () {
	
	}
	
	void Update () {
		isAttack = false;

		if (fireCtr.fireNum != 0 && Input.GetButtonDown("Fire1")) {
			isAttack = true;
		}
	}


	void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.tag == "Enemy") {
			if (isAttack) {
				enemy hoge = col.gameObject.GetComponent<enemy>();
				hoge.enamyState = 1;

				//Destroy(col.gameObject);
				//fireCtr.fireNum -= -1;
			}
		}
	}

}
