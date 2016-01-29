using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

    float time;

    // Use this for initialization
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    /*時間を返す*/
    public float getTime() { return time; }

    /*時間をセット*/
    public void setTime(float t) { time = t; }
}
