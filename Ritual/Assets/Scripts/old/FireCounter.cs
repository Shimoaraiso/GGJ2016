using UnityEngine;
using System.Collections;

public class FireCounter : MonoBehaviour {

	public int fireNum;
    int fireNumStock;

	TorchPower tp;

	void Awake() {
		tp = GameObject.Find("TorchObject").GetComponent<TorchPower>();
    }

    void Start () {
        fireNumStock = fireNum;
    }

	void Update () {
        if (fireNumStock != fireNum) {
            tp.show(fireNum);
            fireNumStock = fireNum;
        }       
    }
}
