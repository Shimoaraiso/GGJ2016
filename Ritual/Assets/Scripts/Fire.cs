using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	//FireCounter fireCtr;

	public int fireNum;
	int fireNumStock;

	TorchPower tp;

	void Awake() {
		tp = GameObject.Find("TorchObject").GetComponent<TorchPower>();
		//fireCtr = GetComponent<FireCounter>();
	}

	void Start() {
		fireNumStock = fireNum;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
            fireNum = LightSet.fireStoc;
            //fireCtr.fireNum = LightSet.fireStoc;
        }
	}

	void Update() {
		if (fireNumStock != fireNum) {
			tp.show(fireNum);
			fireNumStock = fireNum;
		}
	}

}
