using UnityEngine;
using System.Collections;

public class LightSet : MonoBehaviour {

    Light li;   //ライト
    Light fireLight;                //祭壇用ライト
    public float time; //制限時間
    float delta;//明るくなる間隔
    int stock;//fireの一つ前の値
    int count;

    // Use this for initialization
    void Start () {
        li = GameObject.Find("DirectionalLight").GetComponent<Light>();
        fireLight = GameObject.Find("Firelight").GetComponent<Light>();
        li.intensity = 0.0f;
        delta = 1.5f / time;
        //Debug.Log(delta);
        stock = altarState.altarCount;
        count = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (altarState.altarCount != stock)
        {
            if (altarState.altarCount < stock)
            {
                count--;    
            }
            else
            {
                count++;  
            }
            stock = altarState.altarCount;//stock更新
        }
        
        if (count == 3)
        {
            count =0;
            if (fireLight.intensity < 7)
            {
                fireLight.intensity += 1;//ライトを明るく
            }
        }else if(count == -3)
        {
            count = 0;
            if (fireLight.intensity >0) {
                fireLight.intensity -= 1;//ライトを暗く
            }
        }
       
        time += Time.deltaTime;
        if (time >= 1.0)
        {
            if (li.intensity <= 1.5f)
            {
                li.intensity += delta;//少しづつ明るく
                time = 0.0f;
            }
        }
	}
}
