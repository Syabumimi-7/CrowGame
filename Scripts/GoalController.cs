using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalController : MonoBehaviour
{
    /*Playerを取得*/
    GameObject player;

    void Start()
    {
        /*Playerを取得*/
        this.player = GameObject.Find("Player");
    }

    void Update()
    {
        /*PlayerがGoalを超えたらクリア*/
        if(this.player.transform.position.x > transform.position.x)
        {
            SceneManager.LoadScene("ClearScene_1");
        }
    }
}
