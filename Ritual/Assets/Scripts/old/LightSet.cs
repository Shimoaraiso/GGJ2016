using UnityEngine;
using System.Collections;

public class LightSet : MonoBehaviour {
    bool End;
    int filestateTemp;
    Transform magicCircle;
    //Light li;   //ライト
    //Light fireLight;                //祭壇用ライト
    public float time; //制限時間
    //float delta;//明るくなる間隔
    int stock;//fireの一つ前の値
    int count;
    public static int fireStoc;
    int max;
    int fileState;

	void Start () {
        //li = GameObject.Find("DirectionalLight").GetComponent<Light>();
        //fireLight = GameObject.Find("Firelight").GetComponent<Light>();
        magicCircle = GameObject.Find("MagicCircle").GetComponent<Transform>();
        //li.intensity = 0.0f;
        //delta = 1.5f / time;
        //Debug.Log(delta);
        stock = altarState.altarCount;
        count = 0;
        fireStoc = 3;
        max = 3;
        fileState=1;
        filestateTemp = fileState;
    }
	
	void Update () {
        
        if (altarState.altarCount != stock)
        {
            if (altarState.altarCount < stock)
            {
                fileState -=1;
                count = 0;
                if (fileState == 0){
                    GameObject.Find("MagicCircle").GetComponent<Renderer>().enabled = false;
					GameController.End();
				}
            }
            else
            {
                count++;  
            }
            stock = altarState.altarCount;//stock更新
        }
        
        if (count == max)
        {
            count = 0;
            if(fileState<3)fileState += 1;

        }

        if (filestateTemp != fileState)
        {
            switch (fileState)
            {
                case 1:
                    magicCircle.localScale = new Vector3(2.0f,1.5f,1.0f);
                    fireStoc = 3;
                    max = 3; break;
                case 2:
                    fireStoc = 5; max = 6;
                    magicCircle.localScale = new Vector3(3.0f, 2.25f, 1.0f);
                    break;
                case 3:
                    magicCircle.localScale = new Vector3(4.0f, 3.0f, 1.0f);
                    fireStoc = 7;
                    break;

            }
            filestateTemp = fileState;
        }
    }

}
