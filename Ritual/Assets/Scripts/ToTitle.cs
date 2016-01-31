using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToTitle : MonoBehaviour {

	void Update() {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)) {
			SceneManager.LoadScene("Title");
		}
	}
}
