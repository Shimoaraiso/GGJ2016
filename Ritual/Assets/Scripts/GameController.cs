using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject bg1;
	public GameObject bg2;
	public GameObject bg3;
	public GameObject player;
	public GameObject timerObj;

	public main main;
	timer timer;
	TimeBar bar;  

	int state;
	public static bool isPlaying;

	void Awake () {
		timer = timerObj.GetComponent<timer>();
		isPlaying = true;
	}

	void Start () {
		
		state = 1;
	}

	void Update () {
		if (isPlaying) {
			if (state == 1 && timer.getPlaytime() >= 30) {
				bg1.SetActive(false);
				state = 2;
			} else if (state == 2 && timer.getPlaytime() >= 50) {
				bg2.SetActive(false);
				state = 3;
			}
		}
	}

	public static void End() {
        GameObject.Find("Main Camera").GetComponent<AudioSource>().Stop();
        GameObject.Find("fireParticle").GetComponent<ParticleSystem>().Stop();
        GameObject.Find("Fire").GetComponent<Renderer>().enabled=false;
        Debug.Log("end");
		isPlaying = false;
	}
}
