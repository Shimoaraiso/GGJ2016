using UnityEngine;
using System.Collections;

public class FireCounter : MonoBehaviour {

	public GUIText fireGUI;
	public int fireNum;

	void Start () {

	}

	void Update () {
		fireGUI.text = "" + fireNum;
	}


}
