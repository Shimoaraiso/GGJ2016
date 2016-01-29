using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	GameObject target;
	FireCounter fireCtr;

	bool isAttack;
	bool isHit;

	int count;

	void Awake() {
		fireCtr = GameObject.Find("FireGUI").GetComponent<FireCounter>();
	}

	void Start () {
	
	}
	
	void Update () {
		//isAttack = false;

		if (count >= 4) {
			isAttack = false;
			count = 0;
		}

		if (fireCtr.fireNum != 0 && Input.GetButtonDown("Fire1")) {
			isAttack = true;
			count = 0;
		}


		if (isHit) {
			fireCtr.fireNum -= 1;
			isHit = false;
		}

		count++;
    }

	

	void OnTriggerStay2D(Collider2D col) {
		Debug.Log("hogehoge");
		if (col.gameObject.tag == "Enemy") {
			if (isAttack) {
				enemy enm = col.gameObject.GetComponent<enemy>();
				enm.enamyState = 1;
				isHit = true;
				//fireCtr.fireNum -= 1;
			}
		}
	}

}
