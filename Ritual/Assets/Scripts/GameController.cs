using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

	public GameObject bg1;
	public GameObject bg2;
	public GameObject bg3;
	public GameObject player;
	public GameObject timerObj;

	public main main;
	timer timer;
	TimeBar bar;
	GUIText clearText;

	int state;
	public static bool isPlaying;
	public static bool isClear;
	public static bool isGameOver;

	void Awake () {
		timer = timerObj.GetComponent<timer>();
		clearText = GameObject.Find("ClearText").GetComponent<GUIText>();
		isPlaying = true;
		isClear = false;
		isGameOver = false;
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

		if (isClear) {
			clearText.enabled = true;
			Invoke("Clear", 2.0f);
		}
		if (isGameOver) {
			Invoke("GameOver", 3.0f);
		}

		// デバッグ用裏コマンド
		if (Input.GetKey("p") && Input.GetKey("l")) {
			isClear = true;
        }
    }

	public static void End() {
        GameObject.Find("Main Camera").GetComponent<AudioSource>().Stop();
        GameObject.Find("fireParticle").GetComponent<ParticleSystem>().Stop();
        GameObject.Find("Fire").GetComponent<Renderer>().enabled=false;
        Debug.Log("end");
		isPlaying = false;
	}

	void Clear() {
		SceneManager.LoadScene("Clear");
	}
	void GameOver() {
		SceneManager.LoadScene("GameOver");
	}

}
