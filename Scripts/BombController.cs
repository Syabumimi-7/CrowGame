using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    /*物理演算を使う*/
    Rigidbody2D rigid2D;

    /*Bombの初速度*/
    public float x;
    public float y;

    /*Bombが出てきてからの時間をはかる*/
    float delta = 0;

    /*tomaruBombの時に使う*/
    public float Bombspeed;

    void OnEnable()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();

        /*Bombの発射*/
        this.rigid2D.AddForce(transform.right * x);
        this.rigid2D.AddForce(transform.up*y);
    }

    void Update()
    {
        /*Bombが出てきてからの時間をはかる*/
        this.delta += Time.deltaTime;

        /*画面外に出たら非アクティブ*/
        if(transform.position.y < -8.0f || transform.position.x < -10f) 
        {
            gameObject.SetActive(false);
            //Debug.Log("b");
        }

        /*tomaruBombの時に使う。ステージとして動かす*/
        transform.Translate(-1f*Bombspeed, 0, 0);
    }

    /*Playerに当たったら非アクティブ*/
   void OnTriggerEnter2D(Collider2D collision)
   {
       if(collision.gameObject.name == "Player")
       {
           gameObject.SetActive(false);
            //Debug.Log("a");
       }
   }
}
