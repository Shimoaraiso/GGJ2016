using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {
    AudioPlay SE;
	public int fireNum;
	int fireNumStock;

	TorchPower tp;
	Animator anim;

	void Awake() {
		tp = GameObject.Find("Torches").GetComponent<TorchPower>();
		anim = GetComponent<Animator>();
    }

	void Start() {
        SE = GameObject.Find("AudioObject").GetComponent<AudioPlay>();
		fireNumStock = fireNum;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
            if(fireNum!= MagicCircle.fireStoc)
            {
                SE.playSE(2);
            }
           
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
