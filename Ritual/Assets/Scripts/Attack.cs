using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	Fire fire;
<<<<<<< HEAD
	public bool isAttack;
=======
    AudioPlay SE;
	bool isAttack;
>>>>>>> 9dde0199e1b1716e430b37c7f227533e8e0ca13c
	bool isHit;
    int count;

	void Awake () {
		fire = GameObject.FindWithTag("Fire").GetComponent<Fire>();
	}

	void Start () {
<<<<<<< HEAD
	}
=======
        SE = GameObject.Find("AudioObject").GetComponent<AudioPlay>();
    }
>>>>>>> 9dde0199e1b1716e430b37c7f227533e8e0ca13c
	
	void Update () {

		if (count >= 4) {
			isAttack = false;
			count = 0;
		}

		if (GameController.isPlaying && fire.fireNum != 0 && Input.GetButtonDown("Fire1")) {
            SE.playSE(1);
            
			// 攻撃判定は3フレーム継続
			isAttack = true;
			count = 0;
		}

		if (isHit) {
            SE.playSE(0);
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
