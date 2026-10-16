using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator_3 : MonoBehaviour
{
/*    public GameObject otiruBombPrefab;
    public GameObject tomaruBombPrefab;
    public GameObject miginitobasuBombPrefab;
    public GameObject hidarinitobasuBombPrefab;
    public GameObject uenitobasuBombPrefab;
    public GameObject sitanitobasuBombPrefab;
    public GameObject migiuenitobasuBombPrefab;
    public GameObject migisitanitobasuBombPrefab;
    public GameObject hidariuenitobasuBombPrefab;
    public GameObject hidarisitanitobasuBombPrefab;
    public GameObject sayuuniugokuBombPrefab;
    public GameObject jougeniugokuBombPrefab;
    public GameObject kaitenBombPrefab;
    public GameObject goalPrefab;*/

    // 合計時間を加算していく
//    float delta = 0;

    // 同じ爆弾を二度と発生させないように制限をかける
/*    int bakudanseigen = 0;

    void Update()
    {*/
        // 合計時間を加算していく
//        this.delta += Time.deltaTime;

        // 時間が来たら爆弾を出現させる
/*        singleBombGenerator(miginitobasuBombPrefab, -10, 3, 1f, 0);
        singleBombGenerator(hidarinitobasuBombPrefab, 10, -2, 1.5f, 1);
        singleBombGenerator(hidarinitobasuBombPrefab, 10, 0, 2.5f, 2);
        singleBombGenerator(miginitobasuBombPrefab, -10, 1, 3f, 3);
        doubleBombGenerator(hidarinitobasuBombPrefab, 10, -3, migisitanitobasuBombPrefab, -7, 6, 4f, 4);
        singleBombGenerator(hidarisitanitobasuBombPrefab, 8, 6, 5f, 5);
        doubleBombGenerator(miginitobasuBombPrefab, -10, 3, miginitobasuBombPrefab, -10, -1, 5.5f, 6);
        quadrupleBombGenerator(otiruBombPrefab, -7, 6, otiruBombPrefab, -3, 6, otiruBombPrefab, 3, 6, otiruBombPrefab, 7, 6, 7f, 7);
        tripleBombGenerator(otiruBombPrefab, -6, 6, otiruBombPrefab, 0, 6, otiruBombPrefab, 6, 6, 8f, 8);
        quadrupleBombGenerator(otiruBombPrefab, -7, 6, otiruBombPrefab, -3, 6, otiruBombPrefab, 3, 6, otiruBombPrefab, 7, 6, 9f, 9);
        tripleBombGenerator(otiruBombPrefab, -6, 6, otiruBombPrefab, 0, 6, otiruBombPrefab, 6, 6, 10f, 10);
        singleBombGenerator(sitanitobasuBombPrefab, -8, 6, 19f, 11);
        singleBombGenerator(sitanitobasuBombPrefab, -7, 6, 19.4f, 12);
        singleBombGenerator(sitanitobasuBombPrefab, -5, 6, 19.8f, 13);
        singleBombGenerator(sitanitobasuBombPrefab, -3, 6, 20.2f, 14);
        singleBombGenerator(sitanitobasuBombPrefab, -1, 6, 20.6f, 15);
        singleBombGenerator(sitanitobasuBombPrefab, 1, 6, 21f, 16);
        singleBombGenerator(sitanitobasuBombPrefab, 3, 6, 21.4f, 17);
        singleBombGenerator(sitanitobasuBombPrefab, 5, 6, 21.8f, 18);
        singleBombGenerator(sitanitobasuBombPrefab, 7, 6, 22.2f, 19);
        singleBombGenerator(sitanitobasuBombPrefab, 8, 6, 22.6f, 20);
        doubleBombGenerator(sitanitobasuBombPrefab, -8, 6, hidarinitobasuBombPrefab, 10, 6, 23f, 21);
        doubleBombGenerator(sitanitobasuBombPrefab, -7, 6, hidarinitobasuBombPrefab, 10, 3, 23.4f, 22);
        doubleBombGenerator(sitanitobasuBombPrefab, -5, 6, hidarinitobasuBombPrefab, 10, 0, 23.8f, 23);
        doubleBombGenerator(sitanitobasuBombPrefab, -3, 6, hidarinitobasuBombPrefab, 10, -3, 24.2f, 24);
        doubleBombGenerator(sitanitobasuBombPrefab, -1, 6, hidarinitobasuBombPrefab, 10, -6, 24.6f, 25);
        doubleBombGenerator(sitanitobasuBombPrefab, 1, 6, hidarinitobasuBombPrefab, 10, 6, 25f, 26);
        doubleBombGenerator(sitanitobasuBombPrefab, 3, 6, hidarinitobasuBombPrefab, 10, 3, 25.4f, 27);
        doubleBombGenerator(sitanitobasuBombPrefab, 5, 6, hidarinitobasuBombPrefab, 10, 0, 25.8f, 28);
        doubleBombGenerator(sitanitobasuBombPrefab, 7, 6, hidarinitobasuBombPrefab, 10, -3, 26.2f, 29);
        doubleBombGenerator(sitanitobasuBombPrefab, 8, 6, hidarinitobasuBombPrefab, 10, -6, 26.6f, 30);
    }

    void singleBombGenerator(GameObject a, int ax, int ay, float when, int seigen)
    {
        if(this.delta>when && this.bakudanseigen == seigen)
        {
            GameObject goa = Instantiate(a);
            goa.transform.position = new Vector3(ax, ay, 0);

            this.bakudanseigen += 1;
        }
    }

    void doubleBombGenerator(GameObject a, int ax, int ay, GameObject b, int bx, int by, float when, int seigen)
    {
        if(this.delta>when && this.bakudanseigen == seigen)
        {
            GameObject goa = Instantiate(a);
            goa.transform.position = new Vector3(ax, ay, 0);
            GameObject gob = Instantiate(b);
            gob.transform.position = new Vector3(bx, by, 0);

            this.bakudanseigen += 1;
        }
    }

    void tripleBombGenerator(GameObject a, int ax, int ay, GameObject b, int bx, int by, GameObject c, int cx, int cy, float when, int seigen)
    {
        if(this.delta>when && this.bakudanseigen == seigen)
        {
            GameObject goa = Instantiate(a);
            goa.transform.position = new Vector3(ax, ay, 0);
            GameObject gob = Instantiate(b);
            gob.transform.position = new Vector3(bx, by, 0);
            GameObject goc = Instantiate(c);
            goc.transform.position = new Vector3(cx, cy, 0);

            this.bakudanseigen += 1;
        }
    }

    void quadrupleBombGenerator(GameObject a, int ax, int ay, GameObject b, int bx, int by, GameObject c, int cx, int cy, GameObject d, int dx, int dy, float when, int seigen)
    {
        if(this.delta>when && this.bakudanseigen == seigen)
        {
            GameObject goa = Instantiate(a);
            goa.transform.position = new Vector3(ax, ay, 0);
            GameObject gob = Instantiate(b);
            gob.transform.position = new Vector3(bx, by, 0);
            GameObject goc = Instantiate(c);
            goc.transform.position = new Vector3(cx, cy, 0);
            GameObject god = Instantiate(d);
            god.transform.position = new Vector3(dx, dy, 0);

            this.bakudanseigen += 1;
        }
    }*/

    // 合計時間を加算していく
    float delta = 0;

    // 同じ爆弾を二度と発生させないように制限をかける
    int bakudanseigen = 0;

    // 複製元
    [SerializeField] private GameObject otiruBomb = null;
    [SerializeField] private GameObject hidariuenitobasuBomb = null;
    [SerializeField] private GameObject migiuenitobasuBomb = null;
    [SerializeField] private GameObject hidarisitanitobasuBomb = null;
    [SerializeField] private GameObject migisitanitobasuBomb = null;
    [SerializeField] private GameObject hidarinitobasuBomb = null;
    [SerializeField] private GameObject miginitobasuBomb = null;
    [SerializeField] private GameObject sitanitobasuBomb = null;

    // 複製したBombを保持するための空のオブジェクト
    Transform otiruBombs;
    Transform hidariuenitobasuBombs;
    Transform migiuenitobasuBombs;
    Transform hidarisitanitobasuBombs;
    Transform migisitanitobasuBombs;
    Transform hidarinitobasuBombs;
    Transform miginitobasuBombs;
    Transform sitanitobasuBombs;

    void Start()
    {
        // 複製したBombを保持するための空のオブジェクトを生成
        otiruBombs = new GameObject("otiruBombs").transform;
        hidariuenitobasuBombs = new GameObject("hidariuenitobasuBombs").transform;
        migiuenitobasuBombs = new GameObject("migiuenitobasuBombs").transform;
        hidarisitanitobasuBombs = new GameObject("hidarisitanitobasuBombs").transform;
        migisitanitobasuBombs = new GameObject("migisitanitobasuBombs").transform;
        hidarinitobasuBombs = new GameObject("hidarinitobasuBombs").transform;
        miginitobasuBombs = new GameObject("miginitobasuBombs").transform;
        sitanitobasuBombs = new GameObject("sitanitobasuBombs").transform;
    }

    void Update()
    {
        // 合計時間を加算していく
        this.delta += Time.deltaTime;

        // 時間が来たら爆弾を出現させる
        if(this.delta>4 && this.bakudanseigen == 0)
        {
            InstmiginitobasuBomb(new Vector3(-10, 3, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>4.5f && this.bakudanseigen == 1)
        {
            InsthidarinitobasuBomb(new Vector3(10, -2, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>5.5f && this.bakudanseigen == 2)
        {
            InsthidarinitobasuBomb(new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>6 && this.bakudanseigen == 3)
        {
            InstmiginitobasuBomb(new Vector3(-10, 1, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>7 && this.bakudanseigen == 4)
        {
            InstmigisitanitobasuBomb(new Vector3(-7, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, -3, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>8 && this.bakudanseigen == 5)
        {
            InsthidarisitanitobasuBomb(new Vector3(8, 6, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>8.5f && this.bakudanseigen == 6)
        {
            InstmiginitobasuBomb(new Vector3(-10, 3, 0), Quaternion.Euler(0, 0, 0));
            InstmiginitobasuBomb(new Vector3(-10, 1, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>10 && this.bakudanseigen == 7)
        {
            InstotiruBomb(new Vector3(-7, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(-5, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(-3, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>10.5 && this.bakudanseigen == 8)
        {
            InstotiruBomb(new Vector3(7, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(5, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(3, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>11 && this.bakudanseigen == 9)
        {
            InstotiruBomb(new Vector3(2, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(-2, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>12 && this.bakudanseigen == 10)
        {
            InstotiruBomb(new Vector3(-7, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(-2, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(2, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(7, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>13 && this.bakudanseigen == 11)
        {
            InstotiruBomb(new Vector3(-6, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(0, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(6, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>22 && this.bakudanseigen == 12)
        {
            InstsitanitobasuBomb(new Vector3(-8, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>22.4f && this.bakudanseigen == 13)
        {
            InstsitanitobasuBomb(new Vector3(-7, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>22.8f && this.bakudanseigen == 14)
        {
            InstsitanitobasuBomb(new Vector3(-5, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>23.2f && this.bakudanseigen == 15)
        {
            InstsitanitobasuBomb(new Vector3(-3, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>23.6f && this.bakudanseigen == 16)
        {
            InstsitanitobasuBomb(new Vector3(-1, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>24 && this.bakudanseigen == 17)
        {
            InstsitanitobasuBomb(new Vector3(1, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>24.4f && this.bakudanseigen == 18)
        {
            InstsitanitobasuBomb(new Vector3(3, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>24.8f && this.bakudanseigen == 19)
        {
            InstsitanitobasuBomb(new Vector3(5, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>25.2f && this.bakudanseigen == 20)
        {
            InstsitanitobasuBomb(new Vector3(7, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>25.6f && this.bakudanseigen == 21)
        {
            InstsitanitobasuBomb(new Vector3(8, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>26 && this.bakudanseigen == 22)
        {
            InstsitanitobasuBomb(new Vector3(-8, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>26.4f && this.bakudanseigen == 23)
        {
            InstsitanitobasuBomb(new Vector3(-7, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, 3, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>26.8f && this.bakudanseigen == 24)
        {
            InstsitanitobasuBomb(new Vector3(-5, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>27.2f && this.bakudanseigen == 25)
        {
            InstsitanitobasuBomb(new Vector3(-3, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, -3, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>27.6f && this.bakudanseigen == 26)
        {
            InstsitanitobasuBomb(new Vector3(-1, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, -6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>28 && this.bakudanseigen == 27)
        {
            InstsitanitobasuBomb(new Vector3(1, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>28.4f && this.bakudanseigen == 28)
        {
            InstsitanitobasuBomb(new Vector3(3, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, 3, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>28.8f && this.bakudanseigen == 29)
        {
            InstsitanitobasuBomb(new Vector3(5, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>29.2f && this.bakudanseigen == 30)
        {
            InstsitanitobasuBomb(new Vector3(7, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, -3, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>29.6f && this.bakudanseigen == 31)
        {
            InstsitanitobasuBomb(new Vector3(8, 6, 0), Quaternion.Euler(0, 0, 0));
            InsthidarinitobasuBomb(new Vector3(10, -6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
    }

    // Bomb生成関数
    void InstotiruBomb(Vector3 pos, Quaternion rotation)
    {
        // アクティブではないオブジェクトを保持するためのオブジェクトから探す
        foreach(Transform t in otiruBombs)
        {
            if (!t.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置を設定
                t.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                t.gameObject.SetActive(true);
                return;
            }
        }

        //非アクティブなオブジェクトがない場合新規生成
        //生成時にbulletsの子オブジェクトにする
        Instantiate(otiruBomb, pos, rotation, otiruBombs);
    }

    void InsthidariuenitobasuBomb(Vector3 pos, Quaternion rotation)
    {
        // アクティブではないオブジェクトを保持するためのオブジェクトから探す
        foreach(Transform t in hidariuenitobasuBombs)
        {
            if (!t.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置を設定
                t.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                t.gameObject.SetActive(true);
                return;
            }
        }

        //非アクティブなオブジェクトがない場合新規生成
        //生成時にbulletsの子オブジェクトにする
        Instantiate(hidariuenitobasuBomb, pos, rotation, hidariuenitobasuBombs);
    }

    void InstmigiuenitobasuBomb(Vector3 pos, Quaternion rotation)
    {
        // アクティブではないオブジェクトを保持するためのオブジェクトから探す
        foreach(Transform t in migiuenitobasuBombs)
        {
            if (!t.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置を設定
                t.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                t.gameObject.SetActive(true);
                return;
            }
        }

        //非アクティブなオブジェクトがない場合新規生成
        //生成時にbulletsの子オブジェクトにする
        Instantiate(migiuenitobasuBomb, pos, rotation, migiuenitobasuBombs);
    }

    void InsthidarisitanitobasuBomb(Vector3 pos, Quaternion rotation)
    {
        // アクティブではないオブジェクトを保持するためのオブジェクトから探す
        foreach(Transform t in hidarisitanitobasuBombs)
        {
            if (!t.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置を設定
                t.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                t.gameObject.SetActive(true);
                return;
            }
        }

        //非アクティブなオブジェクトがない場合新規生成
        //生成時にbulletsの子オブジェクトにする
        Instantiate(hidarisitanitobasuBomb, pos, rotation, hidarisitanitobasuBombs);
    }

    void InstmigisitanitobasuBomb(Vector3 pos, Quaternion rotation)
    {
        // アクティブではないオブジェクトを保持するためのオブジェクトから探す
        foreach(Transform t in migisitanitobasuBombs)
        {
            if (!t.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置を設定
                t.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                t.gameObject.SetActive(true);
                return;
            }
        }

        //非アクティブなオブジェクトがない場合新規生成
        //生成時にbulletsの子オブジェクトにする
        Instantiate(migisitanitobasuBomb, pos, rotation, migisitanitobasuBombs);
    }

    void InstmiginitobasuBomb(Vector3 pos, Quaternion rotation)
    {
        // アクティブではないオブジェクトを保持するためのオブジェクトから探す
        foreach(Transform t in miginitobasuBombs)
        {
            if (!t.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置を設定
                t.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                t.gameObject.SetActive(true);
                return;
            }
        }

        //非アクティブなオブジェクトがない場合新規生成
        //生成時にbulletsの子オブジェクトにする
        Instantiate(miginitobasuBomb, pos, rotation, miginitobasuBombs);
    }

    void InsthidarinitobasuBomb(Vector3 pos, Quaternion rotation)
    {
        // アクティブではないオブジェクトを保持するためのオブジェクトから探す
        foreach(Transform t in hidarinitobasuBombs)
        {
            if (!t.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置を設定
                t.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                t.gameObject.SetActive(true);
                return;
            }
        }

        //非アクティブなオブジェクトがない場合新規生成
        //生成時にbulletsの子オブジェクトにする
        Instantiate(hidarinitobasuBomb, pos, rotation, hidarinitobasuBombs);
    }

    void InstsitanitobasuBomb(Vector3 pos, Quaternion rotation)
    {
        // アクティブではないオブジェクトを保持するためのオブジェクトから探す
        foreach(Transform t in sitanitobasuBombs)
        {
            if (!t.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置を設定
                t.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                t.gameObject.SetActive(true);
                return;
            }
        }

        //非アクティブなオブジェクトがない場合新規生成
        //生成時にbulletsの子オブジェクトにする
        Instantiate(sitanitobasuBomb, pos, rotation, sitanitobasuBombs);
    }
}
