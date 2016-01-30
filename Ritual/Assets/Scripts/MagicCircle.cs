using UnityEngine;
using System.Collections;

public class MagicCircle : MonoBehaviour {

	Transform magicCircle;
	int filestateTemp;
	int stock;
	int count;
	int max;
	public static int fileState;
	public static int fireStoc;

	void Start() {
		magicCircle = GetComponent<Transform>();
		stock = altarState.altarCount;
		count = 0;
		fireStoc = 3;
		max = 3;
		fileState = 1;
		filestateTemp = fileState;
	}

	void Update() {

		if (altarState.altarCount != stock) {
			if (altarState.altarCount < stock) {
				fileState -= 1;
				count = 0;
				if (fileState == 0) {
					GetComponent<Renderer>().enabled = false;
					GameController.End();
				}
			} else {
				count++;
			}
			stock = altarState.altarCount;
		}

		if (count == max) {
			count = 0;
			if (fileState < 3)
				fileState += 1;

		}

		if (filestateTemp != fileState) {
			switch (fileState) {
				case 1:
					magicCircle.localScale = new Vector3(2.0f, 1.5f, 1.0f);
					fireStoc = 3;
					max = 3;
					break;
				case 2:
					fireStoc = 5;
					max = 6;
					magicCircle.localScale = new Vector3(2.5f, 1.875f, 1.0f);
					break;
				case 3:
					magicCircle.localScale = new Vector3(3.0f, 2.25f, 1.0f);
					fireStoc = 7;
					break;

			}
			filestateTemp = fileState;
		}
	}
}
