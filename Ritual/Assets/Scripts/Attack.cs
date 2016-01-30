using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	Fire fire;

	bool isAttack;
	bool isHit;
    int count;

	void Awake () {
		fire = GameObject.FindWithTag("Fire").GetComponent<Fire>();
	}

	void Start () {   
    }
	
	void Update () {

		if (count >= 4) {
			isAttack = false;
			count = 0;
		}

		if (GameController.isPlaying && fire.fireNum != 0 && Input.GetButtonDown("Fire1")) {
			// 攻撃判定は3フレーム継続
			isAttack = true;
			count = 0;
		}

		if (isHit) {
			fire.fireNum -= 1;
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
