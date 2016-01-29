using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

    public Vector3 targetPosition;  //enemyの目的地
    public float speed;             //移動速度

    public int enamyState;
    float enemyTimer;//倒された時の待機時間

    void start(){
        enamyState = 0;
        enemyTimer = 0.0f;
    } 

	// Update is called once per frame
	void Update () {

        switch(enamyState)
        {
            case 0:
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed);//目的地に移動

                if (transform.position == targetPosition)//目的地に着いたら
                {
                    Destroy(this.gameObject);//enemy消去
                }
                break;
            case 1:
                enemyTimer += Time.deltaTime;
                if (enemyTimer > 2) enamyState = 2;//吸い込まれる状態に移行
                break;
            case 2:
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * 5);//目的地に移動

                if (transform.position == targetPosition)//目的地に着いたら
                {
                    Destroy(this.gameObject);//enemy消去
                }
                transform.RotateAround(Vector3.zero, new Vector3(0.0f, 0.0f, 1.0f), 120 * Time.deltaTime);//回転の挙動追加
                break;
        }


        
        
	}
}
