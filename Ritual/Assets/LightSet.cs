using UnityEngine;
using System.Collections;

public class LightSet : MonoBehaviour {

    Light li;
    public float time;//制限時間
    float delta;//1フレーム

    // Use this for initialization
    void Start () {
        
        time = time/2;
        li = GameObject.Find("DirectionalLight").GetComponent<Light>();
        print(time);
        delta = 1.0f / time;
       
    }
	
	// Update is called once per frame
	void Update () {
        li.intensity -=delta*Time.deltaTime;
        print(li.intensity);
        if (li.intensity <= 0.0f)
        {
            delta = -delta;
        } else if (li.intensity >= 1.5f)
        {
            delta = -delta;
        }
	}
}
