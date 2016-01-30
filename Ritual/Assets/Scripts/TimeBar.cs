using UnityEngine;
using System.Collections;

public class TimeBar : MonoBehaviour {

	public float barLength = 1.42f;
	float crntBarLength;
	float barSpan;
	float playTime;
	bool isPlaying;

	timer tm;

	void Awake() {
		tm = GameObject.Find("TimerObject").GetComponent<timer>();
	}

	void Start () {
		crntBarLength = 0;
        transform.localScale = new Vector2(crntBarLength, transform.localScale.y);
		barSpan = barLength / 60;
		isPlaying = true;
		StartCoroutine(Timebar());
	}

	void Update () {
		if (tm.getPlaytime() >= 60) {
			isPlaying = false;
		}
		
	}


	private IEnumerator Timebar() {
		while (isPlaying) {
			yield return new WaitForSeconds(1f);
			crntBarLength += barSpan;
            transform.localScale = new Vector2(crntBarLength, transform.localScale.y);
		}
	}
}
