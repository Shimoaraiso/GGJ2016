using UnityEngine;
using System.Collections;

public class LightSet : MonoBehaviour {

    Light li;   //ライト
    Light fireLight;                //祭壇用ライト
    public float time; //制限時間
    float delta;//明るくなる間隔
    int stock;//fireの一つ前の値
    int count;
    public static int fireStoc;
    TorchPower TP;
    
    // Use this for initialization
    void Start () {
        li = GameObject.Find("DirectionalLight").GetComponent<Light>();
        fireLight = GameObject.Find("Firelight").GetComponent<Light>();
        li.intensity = 0.0f;
        delta = 1.5f / time;
        //Debug.Log(delta);
        stock = altarState.altarCount;
        count = 0;
        fireStoc = 3;
        TP = GameObject.Find("Power").GetComponent<TorchPower>();
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
                fireStoc += 1;
               
            }
        }else if(count == -3)
        {
            count = 0;
            if (fireLight.intensity > 0)
            {
                fireLight.intensity -= 1;//ライトを暗く
                fireStoc -= 1;
                
                if (fireLight.intensity == 0) {
                    end();
                }
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
    void end()//終了処理
    {
        GameObject.Find("MainGameObject").GetComponent<main>().clear = true;//enemy生成停止
        GameObject.Find("Player").GetComponent<Player>().enabled = false;//Playerスクリプト停止
        GameObject.Find("AttackArea").GetComponent<Attack>().enabled = false;//Attackスクリプト停止
        GameObject.Find("Player").GetComponent<Animator>().enabled = false;//アニメーション停止

        /*配列で取得*/
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject ene in objects)
        {
            ene.GetComponent<enemy>().enabled = false;//enemy停止
        }
    }
}
