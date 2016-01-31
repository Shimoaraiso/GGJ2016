using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Continue : MonoBehaviour {



    void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)) {
            
            SceneManager.LoadScene("Stage1");	
		}
	}
}
