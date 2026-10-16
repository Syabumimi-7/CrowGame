using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    /*Playerの速度*/
    public float autoSpeed = 0.5f;
//    public static float manualSpeed = 0.15f;

    /*移動に制限をかけるための変数*/
    public float Xmouse;
    public float Ymouse;
    public float Xsum = 0f;
    public float Ysum = 0f;
    public float Xdif = 0f;
    public float Ydif = 0f;
    private float mouseDeltax;
    private float mouseDeltay;

    /*Bombに当たってから3秒は無敵*/
    bool muteki;

    /*Bombに当たってからの時間を計測*/
    float delta = 0f;

    /*コライダーを取得*/
    PolygonCollider2D Col;

    /*アニメーションを使う*/
    Animator animator;

    /*playerのHPを設定。他クラスでHPを呼び出すとplayerHPを返し、他クラスでHPを更新するとplayerHPも更新される*/
    private int playerHP = 3;
    public int HP
    {
        get {return playerHP;}
        set {playerHP = value;}
    }

/*    Vector2 firstPos = new Vector2(0, 0);
    Vector2 secondPos;*/

    Vector2 mousePos, crowPos;

//    GameObject debug;

    void Start()
    {
//        Application.targetFrameRate = 60;  

        /*コライダーを取得*/
        Col = GetComponent<PolygonCollider2D>();

        /*アニメーションを使う*/
        this.animator = GetComponent<Animator>();

//        this.debug = GameObject.Find("debug");
    }

    void Update()
    {
        // Mouse入力の値がぶっ飛んだらなかったことにする。
/*        mouseDeltax = Mathf.Clamp(Input.GetAxisRaw("Mouse X"), -1f, 1f);
        mouseDeltay = Mathf.Clamp(Input.GetAxisRaw("Mouse Y"), -1f, 1f);*/

/*        this.secondPos = Input.mousePosition;
        this.transform.Translate((secondPos - firstPos)*SliderController.manualSpeed);
        this.firstPos = secondPos;*/

        mousePos = Input.mousePosition;
        crowPos = Camera.main.ScreenToWorldPoint(mousePos);
        this.transform.position = crowPos;

        /*左右、上下どちらに移動しているかを判断する変数*/
        float keyX = 0f;
        if(Input.GetAxis("Mouse X")>0)
        {
            keyX = 1f;
        }
        if(Input.GetAxis("Mouse X")<0)
        {
            keyX = -1f;
        }

        float keyY = 0f;
        if(Input.GetAxis("Mouse Y")>0)
        {
            keyY = 1f;
        }
        if(Input.GetAxis("Mouse Y")<0)
        {
            keyY = -1f;
        }

        /*移動に制限をかけるための変数*/
//        Xmouse = SliderController.manualSpeed*mouseDeltax;
//        Ymouse = SliderController.manualSpeed*mouseDeltay;

        /*これから動く予定の分*/
//        Xdif = Xmouse;
//        Ydif = Ymouse;

        /*Playerの移動に制限をかける*/
/*        if(Xdif+Xsum<-8f)
        {
            Xmouse = -8f-Xsum;
        }
        if(8f<Xdif+Xsum)
        {
            Xmouse = 8f-Xsum;
        }
        if(Ydif+Ysum<-3.85f)
        {
            Ymouse = -3.85f-Ysum;
        }
        if(3.85f<Ydif+Ysum)
        {
            Ymouse = 3.85f-Ysum;
        }*/

        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -4.5f, 4.5f);
        transform.position = pos;

        /*Playerの移動*/
//        this.transform.Translate(/*autoSpeed+*/Xmouse, Ymouse, 0);

        /*動いた分を加算*/
//        Xsum += Xmouse;
//        Ysum += Ymouse;

        /*動く方向に応じて反転*/
        if(keyX!=0f)
        {
            transform.localScale = new Vector3(0.15f*keyX, 0.15f, 1);
        }

        /*HPが0ならミスシーンへ遷移*/
        if(HP<=0)
        {
            SceneManager.LoadScene("MissScene_1");
        }

        /*無敵状態のとき、コライダー無効で、カラスは点滅。*/
        if(muteki==true && this.delta<3f)
        {
            this.animator.SetBool("Mutekibool", true);
            this.delta += Time.deltaTime;
        }

        /*無敵状態になって3秒経過で無敵状態解除。1フレーム早く点滅は終わる*/
        if(this.delta>=2.98f)
        {
            this.animator.SetBool("Mutekibool", false);
        }
        if(this.delta>=3f)
        {
            muteki = false;
            this.delta = 0f;
            Col.enabled = true;
        }

//        this.debug.GetComponent<TextMeshProUGUI>().text = "Xmouse:"+Xmouse.ToString("F2")+"   Ymouse:"+Ymouse.ToString("F2")+"   manualSpeed:"+SliderController.manualSpeed.ToString("F4")+"  mouseDeltax:"+mouseDeltax.ToString("F2")+"  mouseDeltay:"+mouseDeltay.ToString("F2");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        /*Bombに当たったらHPが減り、無敵状態になる*/
        if(!muteki)
        {
            if(collision.gameObject.name=="Bomb" || collision.gameObject.CompareTag("bomb"))
            {
                HP -= 1;

                GameObject director = GameObject.Find("GameDirector");
                director.GetComponent<GameDirector>().DecreaseHP();

                muteki = true;

                Col.enabled = false;
            }
        }    

        /*ゴールに着いたらクリアシーンへ遷移*/
        /*if(collision.gameObject.name=="Goal(Clone)")
        {
            SceneManager.LoadScene("ClearScene_1");
        }*/
    }
}
