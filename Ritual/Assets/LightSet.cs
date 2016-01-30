using UnityEngine;
using System.Collections;

public class LightSet : MonoBehaviour {
    bool End;
    int filestateTemp;
    Transform magicCircle;
    Light li;   //ライト
    Light fireLight;                //祭壇用ライト
    public float time; //制限時間
    float delta;//明るくなる間隔
    int stock;//fireの一つ前の値
    int count;
    public static int fireStoc;
    int max;
    int fileState;
    // Use this for initialization
    void Start () {
        //End = false;
        li = GameObject.Find("DirectionalLight").GetComponent<Light>();
        fireLight = GameObject.Find("Firelight").GetComponent<Light>();
        magicCircle = GameObject.Find("MagicCircle").GetComponent<Transform>();
        li.intensity = 0.0f;
        delta = 1.5f / time;
        //Debug.Log(delta);
        stock = altarState.altarCount;
        count = 0;
        fireStoc = 3;
        max = 3;
        fileState=1;
        filestateTemp = fileState;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (altarState.altarCount != stock)
        {
            if (altarState.altarCount < stock)
            {
                fileState -=1;
                count = 0;
<<<<<<< HEAD
				if (fileState == 0) GameController.End();
=======
                if (fileState == 0)
                {
                    GameObject.Find("MagicCircle").GetComponent<Renderer>().enabled = false;
                    end();
                }
>>>>>>> 7107d684b9c94dc00f069b06a97a952f319ae399
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
            /*if (fireLight.intensity < 7)
            {
                fireLight.intensity += 1;//ライトを明るく
                fireStoc += 1;
               
            }*/
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
      
        //print("FS"+fireStoc+"M"+ max+"C"+count+"ST"+fileState);
        /*
        else if(count == -1)
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
       */
        /*
         time += Time.deltaTime;
         if (time >= 1.0)
         {
             if (li.intensity <= 1.5f)
             {
                 li.intensity += delta;//少しづつ明るく
                 time = 0.0f;
             }
         }
         */
    }
    void end()//終了処理
    {
		//Debug.Log("end");
  //      GameObject.Find("MainGameObject").GetComponent<main>().clear = true;//enemy生成停止
  //      GameObject.Find("Player").GetComponent<Player>().enabled = false;//Playerスクリプト停止
  //      GameObject.Find("AttackArea").GetComponent<Attack>().enabled = false;//Attackスクリプト停止
  //      GameObject.Find("Player").GetComponent<Animator>().enabled = false;//アニメーション停止
  //      GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f,0.0f);//吹っ飛び防止
  //      /*配列で取得*/
  //      /*
  //      GameObject[] objects;
  //      while ((objects = GameObject.FindGameObjectsWithTag("Enemy")) == null)
  //      {
            
  //      }
  //      foreach (GameObject ene in objects)
  //      {
  //          ene.GetComponent<enemy>().enabled = false;//enemy停止
  //      }
  //      */
  //      GameObject[] objects = GameObject.FindGameObjectsWithTag("Enemy");
  //      foreach (GameObject ene in objects)
  //      {
			
  //          ene.GetComponent<enemy>().enabled = false;//enemy停止
		//	Debug.Log("hogehoge");
		//}
    }
}
