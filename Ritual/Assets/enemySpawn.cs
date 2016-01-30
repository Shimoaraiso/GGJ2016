using UnityEngine;
using System.Collections;

public class enemySpawn : MonoBehaviour {

    public float leftPositon;   //画面左側のenemy生成場所(X軸)
    public float rightPositon;  //画面右側のenemy生成場所(X軸)
    public float topPositon;    //画面上側のenemy生成場所(Y軸)
    public float bottomPositon; //画面下側のenemy生成場所(Y軸)
    public GameObject enemy;    //敵のオブジェクト
    public float Espeed;
    /*enemyをランダムでで生成*/
    public void enemySpawnRand()
    {
        switch (Random.Range(0, 4))
        {
            case 0: spawnSide(leftPositon); break;
            case 1: spawnSide(rightPositon); break;
            case 2: spawnTopAndBottom(topPositon); break;
            case 3: spawnTopAndBottom(bottomPositon); break;
        }
    }

    /*左右画面外で生成*/
    void spawnSide(float PositionX)
    {
        GameObject enemys = GameObject.Instantiate(enemy, new Vector3(PositionX, Random.Range(bottomPositon, topPositon), 0.0f), transform.rotation) as GameObject;//敵(enemy)生成
        enemys.gameObject.GetComponent<enemy>().speed += Espeed; 
    }
    

    /*上下画面外で生成*/
    void spawnTopAndBottom(float PositionY)
    {
        GameObject enemys =Instantiate(enemy, new Vector3(Random.Range(leftPositon, rightPositon), PositionY), transform.rotation)as GameObject;//敵(enemy)生成
        enemys.gameObject.GetComponent<enemy>().speed += Espeed;
    }
}
