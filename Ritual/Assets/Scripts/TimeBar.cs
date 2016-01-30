using UnityEngine;
using System.Collections;

public class TimeBar : MonoBehaviour {

	public float barLength = 1.42f;
	float barSec;

	timer tm;

	void Awake() {
		tm = GameObject.Find("TimerObject").GetComponent<timer>();
	}

	void Start () {
		barSec = barLength / 60;
	}
	
	void Update () {

		transform.localScale = new Vector2(barSec, transform.localScale.y);
	}
}
