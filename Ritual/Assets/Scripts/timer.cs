using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

    float time;
    float Playtime;

    // Use this for initialization
    void Start()
    {
        time = 0.0f;
        Playtime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Playtime += Time.deltaTime;
    }

    /*時間を返す*/
    public float getTime() { return time; }

    /*時間をセット*/
    public void setTime(float t) { time = t; }

    /*プレイ時間を返す*/
    public float getPlaytime() { return Playtime; }

    /*プレイ時間をセット*/
    public void setPlaytime(float t) { Playtime = t; }
}
