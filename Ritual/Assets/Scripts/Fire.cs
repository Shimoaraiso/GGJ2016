using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	FireCounter fireCtr;
	int maxFire;

	void Awake() {
		fireCtr = GetComponent<FireCounter>();
	}

	void Start () {
		maxFire = 10;
	}
	
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
            //fireCtr.fireNum = maxFire;
            fireCtr.fireNum = LightSet.fireStoc+1;
            
        }
	}

}
