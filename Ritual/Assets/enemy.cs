using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
   
    public Vector3 targetPosition;  //enemyの目的地
    public float speed;             //移動速度
    
    public int enamyState;
    float enemyTimer;//倒された時の待機時間
    bool hit;//当たったか判定

    void start(){
        enamyState = 0;
        enemyTimer = 0.0f;
        hit = false;
    } 

	// Update is called once per frame
	void Update () {

        switch(enamyState)
        {
            case 0://初期状態()
				if (GameController.isPlaying) {
					transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed);//目的地に移動
				}
                if (transform.position == targetPosition)//目的地に着いたら
                {
                    Destroy(this.gameObject);//enemy消去
                    altarState.altarCount--;
                    
                }
                break;
            case 1://倒された
                enemyTimer += Time.deltaTime;
                if (!hit)
                {
                    transform.FindChild("Enemys").gameObject.GetComponent<Animator>().SetBool("hit",true);//アニメーション切り替え
                    this.GetComponent<CircleCollider2D>().enabled = false;//Collider消去
                    hit = true;
                }

                if (enemyTimer > 2) enamyState = 2;//吸い込まれる状態に移行
                break;
            case 2://吸い込まれる状態
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * 5);//目的地に移動

                if (transform.position == targetPosition)//目的地に着いたら
                {
                    Destroy(this.gameObject);//enemy消去
                    altarState.altarCount++;

                }
                transform.RotateAround(Vector3.zero, new Vector3(0.0f, 0.0f, 1.0f), 120 * Time.deltaTime);//回転の挙動追加
                break;
        }


        
        
	}
}
