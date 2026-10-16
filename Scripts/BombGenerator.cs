using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject otiruBombPrefab;
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
    public GameObject goalPrefab;

    // 合計時間を加算していく
    float delta = 0;

    // 同じ爆弾を二度と発生させないように制限をかける
    int bakudanseigen = 0;

    void Update()
    {
        // 合計時間を加算していく
        this.delta += Time.deltaTime;

        // 時間が来たら爆弾を出現させる
/*        if(this.delta>0.1 && this.bakudanseigen == 0)
        {
            GameObject goa = Instantiate(tomaruBombPrefab);
            goa.transform.position = new Vector3(10, 4, 0);

            GameObject gob = Instantiate(tomaruBombPrefab);
            gob.transform.position = new Vector3(10, 0, 0);

            GameObject goc = Instantiate(tomaruBombPrefab);
            goc.transform.position = new Vector3(10, -4, 0);
            
            this.bakudanseigen += 1;
        }

        if(this.delta>3 && this.bakudanseigen == 1)
        {
            GameObject goa = Instantiate(tomaruBombPrefab);
            goa.transform.position = new Vector3(10, 4, 0);

            GameObject gob = Instantiate(tomaruBombPrefab);
            gob.transform.position = new Vector3(10, -4, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>5 && this.bakudanseigen == 2)
        {
            GameObject goa = Instantiate(tomaruBombPrefab);
            goa.transform.position = new Vector3(10, 2, 0);

            GameObject gob = Instantiate(tomaruBombPrefab);
            gob.transform.position = new Vector3(10, -2, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>6 && this.bakudanseigen == 3)
        {
            GameObject goa = Instantiate(tomaruBombPrefab);
            goa.transform.position = new Vector3(10, 3, 0);

            GameObject gob = Instantiate(tomaruBombPrefab);
            gob.transform.position = new Vector3(10, -3, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>7 && this.bakudanseigen == 4)
        {
            GameObject goa = Instantiate(tomaruBombPrefab);
            goa.transform.position = new Vector3(10, 2, 0);

            GameObject gob = Instantiate(tomaruBombPrefab);
            gob.transform.position = new Vector3(10, -2, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>8 && this.bakudanseigen == 5)
        {
            GameObject goa = Instantiate(tomaruBombPrefab);
            goa.transform.position = new Vector3(10, 3, 0);

            GameObject gob = Instantiate(tomaruBombPrefab);
            gob.transform.position = new Vector3(10, -3, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>13 && this.bakudanseigen == 6)
        {
            GameObject goa = Instantiate(otiruBombPrefab);
            goa.transform.position = new Vector3(0, 6, 0);

            GameObject gob = Instantiate(otiruBombPrefab);
            gob.transform.position = new Vector3(3, 6, 0);

            GameObject goc = Instantiate(otiruBombPrefab);
            goc.transform.position = new Vector3(6, 6, 0);

            GameObject god = Instantiate(otiruBombPrefab);
            god.transform.position = new Vector3(-3, 6, 0);

            this.bakudanseigen += 1;
        }*/

        if(this.delta>16 && this.bakudanseigen == 0)
        {
            GameObject goa = Instantiate(hidarinitobasuBombPrefab);
            goa.transform.position = new Vector3(10, 0, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>18 && this.bakudanseigen == 1)
        {
            GameObject go = Instantiate(miginitobasuBombPrefab);
            go.transform.position = new Vector3(-10, 0, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>20 && this.bakudanseigen == 2)
        {
            GameObject goa = Instantiate(miginitobasuBombPrefab);
            goa.transform.position = new Vector3(-10, 3, 0);

            GameObject gob = Instantiate(hidarinitobasuBombPrefab);
            gob.transform.position = new Vector3(10, -3, 0);

            this.bakudanseigen += 1;
        }

/*        if(this.delta>22 && this.bakudanseigen == 10)
        {
            GameObject goa = Instantiate(tomaruBombPrefab);
            goa.transform.position = new Vector3(10, 3, 0);

            GameObject gob = Instantiate(tomaruBombPrefab);
            gob.transform.position = new Vector3(10, -3, 0);
        
            this.bakudanseigen += 1;
        }

        if(this.delta>24 && this.bakudanseigen == 11)
        {
            GameObject goa = Instantiate(tomaruBombPrefab);
            goa.transform.position = new Vector3(10, 3, 0);

            GameObject gob = Instantiate(tomaruBombPrefab);
            gob.transform.position = new Vector3(10, -3, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>26 && this.bakudanseigen == 12)
        {
            GameObject goa = Instantiate(otiruBombPrefab);
            goa.transform.position = new Vector3(-7, 6, 0);

            GameObject gob = Instantiate(otiruBombPrefab);
            gob.transform.position = new Vector3(7, 6, 0);

            GameObject goc = Instantiate(otiruBombPrefab);
            goc.transform.position = new Vector3(0, 6, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>27 && this.bakudanseigen == 13)
        {
            GameObject goa = Instantiate(sayuuniugokuBombPrefab);
            goa.transform.position = new Vector3(10, 0, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>29 && this.bakudanseigen == 14)
        {
            GameObject goa = Instantiate(jougeniugokuBombPrefab);
            goa.transform.position = new Vector3(10, 0, 0);

            this.bakudanseigen += 1;
        }

        if(this.delta>32 && this.bakudanseigen == 15)
        {
            GameObject goa = Instantiate(goalPrefab);
            goa.transform.position = new Vector3(10, 0, 0);

            this.bakudanseigen += 1;
        }*/
    }
}
