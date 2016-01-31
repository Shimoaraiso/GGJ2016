using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class StageChange : MonoBehaviour {
	
	void Update () {
		if (Input.GetButtonDown("Jump")){
			SceneManager.LoadScene("Stage1");
		}
	}
}
