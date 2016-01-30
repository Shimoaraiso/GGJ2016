using UnityEngine;
using System.Collections;

public class LightSet : MonoBehaviour {

    Light li;   //ライト
    Light firelight;//祭壇用ライト
    public float time; //制限時間
    float delta;//明るくなる間隔

    // Use this for initialization
    void Start () {
        li = GameObject.Find("DirectionalLight").GetComponent<Light>();
        firelight = GameObject.Find("Firelight").GetComponent<Light>();
        li.intensity = 0.0f;
        delta = 1.5f / time;
        //Debug.Log(delta);
    }
	
	// Update is called once per frame
	void Update () {
        
        time += Time.deltaTime;
        if (time >= 1.0)
        {
            
            firelight.range = altarState.altarCount * 20+10;
            if (li.intensity <= 1.5f)
            {
                li.intensity += delta;//少しづつ明るく
                time = 0.0f;
            }
        }
	}
}
