using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

    public float spawnInterval;
    bool SpaceKey;
    GameObject ESObject;//
    enemySpawn ES;      //enemySpawnスクリプト
    timer tm;


    // Use this for initialization
    void Start () {
        SpaceKey = false;
        GameObject ESObject = GameObject.Find("EnemySpawnObject");//EnemySpawnObjectのオブジェクト取得
        ES = ESObject.GetComponent<enemySpawn>(); //EnemySpawnObjectオブジェクトの中のenemySpawnスクリプトを取得
        tm= GameObject.Find("TimerObject").GetComponent<timer>();
        tm.setTime(0.0f);
    }
	
	// Update is called once per frame
	void Update () {
/*
        if (tm.getTime() > spawnInterval) {
            ES.enemySpawnRand();//enemyをランダム発生
            tm.setTime(0.0f);
        }
        */
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
        

        
    }
}
