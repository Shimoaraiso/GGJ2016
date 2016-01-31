using UnityEngine;
using System.Collections;

public class TimeBar : MonoBehaviour {

	public float barLength = 1.43f;
	float crntBarLength;
	float barSpan;
	float playTime;

	timer timer;

	void Awake() {
		timer = GameObject.Find("TimerObject").GetComponent<timer>();
	}
	
	void Start () {
		crntBarLength = 0;
        transform.localScale = new Vector2(crntBarLength, transform.localScale.y);
		barSpan = barLength / 330;
		StartCoroutine(Timebar());
	}

	void Update () {
		if (timer.getPlaytime() >= 70) {
			GameController.isClear = true;
			GameController.End();
		}	
	}

	private IEnumerator Timebar() {
        while (GameController.isPlaying) {
			yield return new WaitForSeconds(0.2f);
			crntBarLength += barSpan;
            transform.localScale = new Vector2(crntBarLength, transform.localScale.y);
		}
	}
}
