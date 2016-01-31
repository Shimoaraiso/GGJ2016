using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

	public int offSet_stage1_X;
	public int offSet_stage1_Y;

	public Texture button1;

	void OnGUI() {
		if (GUI.Button(new Rect(Screen.width / 2 + offSet_stage1_X, Screen.height / 2 + offSet_stage1_Y, 220, 80), button1)) {
			SceneManager.LoadScene("Guide");
		}
		//if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 110, 200, 50), "Stage 2")) {

		//}
		//if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 170, 200, 50), "Stage 3")) {

		//}
	}
}
