using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class endScene : MonoBehaviour {

	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Title");
        }
	}
}
