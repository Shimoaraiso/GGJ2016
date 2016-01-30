using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	GameObject target;
	FireCounter fireCtr;

	bool isAttack;
	bool isHit;
    int count;

	void Awake() {
		fireCtr = GameObject.FindWithTag("Fire").GetComponent<FireCounter>();
	}

	void Start () {   
    }
	
	void Update () {

		if (count >= 4) {
			isAttack = false;
			count = 0;
		}

		if (fireCtr.fireNum != 0 && Input.GetButtonDown("Fire1")) {
			// 攻撃判定は3フレーム継続
			isAttack = true;
			count = 0;
		}

		if (isHit) {
			fireCtr.fireNum -= 1;
            isHit = false;
		}
		// フレームカウント
		count++;
    }

	void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.tag == "Enemy") {
			if (isAttack) {
				enemy enm = col.gameObject.GetComponent<enemy>();
				enm.enamyState = 1;
				isHit = true;
			}
		}
	}

}
