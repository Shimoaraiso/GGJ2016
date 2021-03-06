﻿using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

    public int playtime;
    public float spawnInterval;
    public float espeed;
    bool SpaceKey;
    GameObject ESObject;//
    enemySpawn ES;      //enemySpawnスクリプト
    timer tm;
    int point;
    int state;
    public bool clear;

    void Start () {

        SpaceKey = false;
        GameObject ESObject = GameObject.Find("EnemySpawnObject");//EnemySpawnObjectのオブジェクト取得
        ES = ESObject.GetComponent<enemySpawn>(); //EnemySpawnObjectオブジェクトの中のenemySpawnスクリプトを取得
        tm= GameObject.Find("TimerObject").GetComponent<timer>();
        tm.setTime(0.0f);
        point = playtime / 3;
        state = 0;
        clear = false;
        ES.Espeed = 0.0f;
        GameObject.Find("Main Camera").GetComponent<AudioSource>().Play();
    }
	
	void Update () {
        if (point <= tm.getPlaytime() &&  point*2> tm.getPlaytime() && state == 0)
        {

            spawnInterval = spawnInterval / 2.0f;
            state++;
            ES.Espeed = 0.005f;
        }
        else if(point * 2<= tm.getPlaytime() && playtime  > tm.getPlaytime() && state == 1)
        {
            spawnInterval = spawnInterval / 2.0f;
            state++;
            ES.Espeed = 0.01f;
        }
        else if (playtime <= tm.getPlaytime() && state == 2)
        {
            if (tm.getPlaytime() >= playtime)
            {
                Debug.Log("クリア");
                clear = true;
            }
        }

        if (tm.getTime() > spawnInterval && !clear && GameController.isPlaying) {
            ES.enemySpawnRand();//enemyをランダム発生
            tm.setTime(0.0f);
        }
        
        
        /*
        if (Input.GetKey(KeyCode.A))
        {
            if (!SpaceKey)
            {
                ES.enemySpawnRand();//enemyをランダム発生
                SpaceKey = true;
            }
        }
        else
        {
            SpaceKey = false;
        }
        */

        
    }
   
   
}
