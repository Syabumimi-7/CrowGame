using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator_1 : MonoBehaviour
{
    // 合計時間を加算していく
    float delta = 0;

    // 同じ爆弾を二度と発生させないように制限をかける
    int bakudanseigen = 0;

    // 複製元
    [SerializeField] private GameObject otiruBomb = null;
    [SerializeField] private GameObject hidarinitobasuBomb = null;
    [SerializeField] private GameObject miginitobasuBomb = null;

    // 複製したBombを保持するための空のオブジェクト
    Transform otiruBombs;
    Transform hidarinitobasuBombs;
    Transform miginitobasuBombs;

    void Start()
    {
        // 複製したBombを保持するための空のオブジェクトを生成
        otiruBombs = new GameObject("otiruBombs").transform;
        hidarinitobasuBombs = new GameObject("hidarinitobasuBombs").transform;
        miginitobasuBombs = new GameObject("miginitobasuBombs").transform;
    }

    void Update()
    {
        // 合計時間を加算していく
        this.delta += Time.deltaTime;

        // 時間が来たら爆弾を出現させる
        if(this.delta>16 && this.bakudanseigen == 0)
        {
            InstotiruBomb(new Vector3(-6, 6, 0), Quaternion.Euler(0, 0, 0));
            InstotiruBomb(new Vector3(6, 6, 0), Quaternion.Euler(0, 0, 0));
            //InstotiruBomb(new Vector3(0, 6, 0), Quaternion.Euler(0, 0, 0));
            
            this.bakudanseigen += 1;
        }
        if(this.delta>19 && this.bakudanseigen == 1)
        {
            //InsthidarinitobasuBomb(new Vector3(10, 5, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>21 && this.bakudanseigen == 2)
        {
            //InsthidarinitobasuBomb(new Vector3(10, 4, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>23 && this.bakudanseigen == 3)
        {
            //InsthidarinitobasuBomb(new Vector3(10, 3, 0), Quaternion.Euler(0, 0, 0));

            this.bakudanseigen += 1;
        }
        if(this.delta>29 && this.bakudanseigen == 4)
        {
            //InstotiruBomb(new Vector3(-7, 6, 0), Quaternion.Euler(0, 0, 0));
            //InstotiruBomb(new Vector3(0, 6, 0), Quaternion.Euler(0, 0, 0));
            //InstotiruBomb(new Vector3(7, 6, 0), Quaternion.Euler(0, 0, 0));

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
}
