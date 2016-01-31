using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
   
    public Vector3 targetPosition;  //enemyの目的地
    public float speed;             //移動速度
    AudioPlay SE;
    public int enamyState;
    float enemyTimer;//倒された時の待機時間
    bool hit;//当たったか判定

	Animator animator;

    void Start(){
        enamyState = 0;
        enemyTimer = 0.0f;
        hit = false;
		animator = transform.FindChild("Enemys").gameObject.GetComponent<Animator>();
        SE = GameObject.Find("AudioObject").GetComponent<AudioPlay>();
    } 

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
                    animator.SetBool("hit",true);//アニメーション切り替え
                    this.GetComponent<CircleCollider2D>().enabled = false;//Collider消去
                    hit = true;
                    transform.FindChild("AttackEfect").GetComponent<ParticleSystem>().Emit(30);
                }
                if (enemyTimer > 0.1) transform.FindChild("AttackEfect").GetComponent<ParticleSystem>().Stop();
                if (enemyTimer > 2) enamyState = 2;//吸い込まれる状態に移行
                break;
            case 2://吸い込まれる状態
               
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * 5);//目的地に移動

                if (transform.position == targetPosition)//目的地に着いたら
                {
                    Destroy(this.gameObject);//enemy消去
                    altarState.altarCount++;
                    SE.playSE(5);
                }
                transform.RotateAround(Vector3.zero, new Vector3(0.0f, 0.0f, 1.0f), 120 * Time.deltaTime);//回転の挙動追加
                break;
        }


        
        
	}
}
