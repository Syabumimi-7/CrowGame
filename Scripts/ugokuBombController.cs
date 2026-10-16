using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ugokuBombController : MonoBehaviour
{
    /*ugokuBombの往復スピード*/
    public float moveSpeed = 10f;
    
    /*どこからどこまで動くか*/
    [SerializeField] Transform movingStart; 
    [SerializeField] Transform movingGoal; 

    /*startに向かっているかgoalに向かっているか*/
    private bool Move;

    /*Bombが出てきてからの時間をはかる*/
    float delta = 0;

    void Update()
    {
        /*Bombが出てきてからの時間をはかる*/
        this.delta += Time.deltaTime;

        /*startかgoalに向かう*/
        if (Move)
        {
            transform.position = Vector2.MoveTowards(transform.position, movingStart.position, moveSpeed * Time.deltaTime);
        }
        else if (!Move)
        {
            transform.position = Vector2.MoveTowards(transform.position, movingGoal.position, moveSpeed * Time.deltaTime);
        }

        /*画面外に出たら消去*/
        if(transform.position.y < -8.0f || transform.position.x < -10f)
        {
            // Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    /*startかgoalに着いたら行き先を切り替える*/
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("start"))
        {
            Move = true;
        }
        else if (other.gameObject.CompareTag("goal"))
        {
            Move = false;
        }

        /*Playerに当たったら消去*/
        if(other.gameObject.name == "Player")
        {
            // Destroy(gameObject);
            gameObject.SetActive(false);
            //Debug.Log("a");
        }
    }
}
