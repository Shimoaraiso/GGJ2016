using UnityEngine;
using System.Collections;

public class FireCounter : MonoBehaviour {

	public GUIText fireGUI;
	public int fireNum;
    int fireNumStock;

    void Start () {
        fireNumStock = fireNum;
    }

	void Update () {
        if (fireNumStock != fireNum)
        {
            fireGUI.text = "" + fireNum;
            GameObject.Find("TorchObject").GetComponent<TorchPower>().show(fireNum);
            fireNumStock = fireNum;
        }
       
    }


}
