using UnityEngine;
using System.Collections;

public class FireCounter : MonoBehaviour {

	public GUIText fireGUI;
	public int fireNum;
    int fireNumStock;

    void Start () {
        fireNumStock = fireNum;
        GameObject.Find("Power").GetComponent<TorchPower>().show(0);
    }

	void Update () {
        if (fireNumStock != fireNum)
        {
            fireGUI.text = "" + fireNum;
            GameObject.Find("Power").GetComponent<TorchPower>().show(fireNum);
            fireNumStock = fireNum;
        }
       
    }


}
