using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject bg1;
	public GameObject bg2;
	public GameObject bg3;
	int state;
	timer tm;

	void Start () {
		state = 1;
        tm= GameObject.Find("TimerObject").GetComponent<timer>();
	}

	void Update () {
		if (state == 1 && tm.getPlaytime() >= 30) {
			bg1.SetActive(false);
			state = 2;
		} else if (state == 2 && tm.getPlaytime() >= 50) {
			bg2.SetActive(false);
			state = 3;
		}
	}
}
