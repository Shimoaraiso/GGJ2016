using UnityEngine;
using System.Collections;

public class TorchPower : MonoBehaviour {

    GameObject[] totch = new GameObject[10];

    
    void Start () {
        for (int i=0; i<7; i++)
        {
            totch[i] = GameObject.Find("Torch" + (i + 1));
        }
        show(0);

    }

    //更新
    public void show(int num)
    {

        for (int i = 0; i < num; i++)
        {
            totch[i].GetComponent<MeshRenderer>().enabled = true;
        }
        for (int j = num; j < 7; j++)
        {
            totch[j].GetComponent<MeshRenderer>().enabled = false;
        }
    }
	
}
