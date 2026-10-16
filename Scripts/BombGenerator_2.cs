using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator_2 : MonoBehaviour
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
/*        quadrupleBombGenerator(otiruBombPrefab, -7, 6, otiruBombPrefab, -3, 6, otiruBombPrefab, 3, 6, otiruBombPrefab, 7, 6, 10f, 0);
        tripleBombGenerator(otiruBombPrefab, -6, 6, otiruBombPrefab, 0, 6, otiruBombPrefab, 6, 6, 11f, 1);
        singleBombGenerator(migisitanitobasuBombPrefab, -9, 6, 13.5f, 2);
        singleBombGenerator(hidarisitanitobasuBombPrefab, 9, 6, 14f, 3);
        singleBombGenerator(migiuenitobasuBombPrefab, -9, -6, 14.5f, 4);
        singleBombGenerator(hidariuenitobasuBombPrefab, 9, -6, 15f, 5);
        quadrupleBombGenerator(sitanitobasuBombPrefab, -7, 6, otiruBombPrefab, -3, 6, otiruBombPrefab, 3, 6, sitanitobasuBombPrefab, 7, 6, 21f, 6);
        singleBombGenerator(goalPrefab, 10, 0, 30f, 7);
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

    // 複製したBombを保持するための空のオブジェクト
    Transform otiruBombs;
    Transform hidariuenitobasuBombs;
    Transform migiuenitobasuBombs;
    Transform hidarisitanitobasuBombs;
    Transform migisitanitobasuBombs;

    void Start()
    {
        // 複製したBombを保持するための空のオブジェクトを生成
        otiruBombs = new GameObject("otiruBombs").transform;
        hidariuenitobasuBombs = new GameObject("hidariuenitobasuBombs").transform;
        migiuenitobasuBombs = new GameObject("migiuenitobasuBombs").transform;
        hidarisitanitobasuBombs = new GameObject("hidarisitanitobasuBombs").transform;
        migisitanitobasuBombs = new GameObject("migisitanitobasuBombs").transform;
    }

    void Update()
    {
        // 合計時間を加算していく
        this.delta += Time.deltaTime;

        // 時間が来たら爆弾を出現させる
        if(this.delta>13 && this.bakudanseigen == 0)
        {
            InstotiruBomb(new Vector3(-7, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(-5, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(-3, 6, 0), Quaternion.Euler(0, 0, 0));
            //InstotiruBomb(new Vector3(-1, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>14 && this.bakudanseigen == 1)
        {
            InstotiruBomb(new Vector3(7, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(5, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(3, 6, 0), Quaternion.Euler(0, 0, 0));
            //InstotiruBomb(new Vector3(1, 6, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>16.5f && this.bakudanseigen == 2)
        {
            //InsthidariuenitobasuBomb(new Vector3(11, -6, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>17 && this.bakudanseigen == 3)
        {
            //InsthidariuenitobasuBomb(new Vector3(7, -6, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>17.5 && this.bakudanseigen == 4)
        {
            //InsthidariuenitobasuBomb(new Vector3(3, -6, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>18 && this.bakudanseigen == 5)
        {
            //InsthidariuenitobasuBomb(new Vector3(-1, -6, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        /*if(this.delta>24 && this.bakudanseigen == 6)
        {
            InstotiruBomb(new Vector3(-7, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(-2, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(2, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(7, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }*/
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
}
