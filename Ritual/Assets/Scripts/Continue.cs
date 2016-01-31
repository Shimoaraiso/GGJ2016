using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Continue : MonoBehaviour {

	void Update () {
		if (Input.GetButtonDown("Jump")) {
			SceneManager.LoadScene("Stage1");
		}
	}
}
