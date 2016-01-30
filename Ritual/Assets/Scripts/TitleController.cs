using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class TitleController : MonoBehaviour {

	void OnGUI() {
		if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 50, 200, 50), "Stage 1")) {
			SceneManager.LoadScene("Stage1");
		}
		//if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 110, 200, 50), "Stage 2")) {

		//}
		//if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 170, 200, 50), "Stage 3")) {

		//}
	}
}
