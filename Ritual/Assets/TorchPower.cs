using UnityEngine;
using System.Collections;

public class TorchPower : MonoBehaviour {

    GameObject[] totch = new GameObject[10];

    // Use this for initialization
    void Start () {
        for (int i=0; i<10; i++)
        {
            totch[i] = GameObject.Find("Torch" + (i + 1));
        }
	}

    public void show(int num)
    {
        for (int i = 0; i < num; i++)
        {
            totch[i].GetComponent<MeshRenderer>().enabled = true;
        }
        for (int i = num; i < 10; i++)
        {
            totch[i].GetComponent<MeshRenderer>().enabled = false;
        }
    }
	
}
